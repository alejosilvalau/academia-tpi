using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Servicios;
using Repositorio;
using UI.Web.Auth;
using UI.Web.Services;
using UI.Web;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<AcademiaContext>();
builder.Services.AddScoped<IUsuarioContexto, UsuarioContextoWeb>();
builder.Services.AddScoped<EspecialidadServicio>();
builder.Services.AddScoped<PlanServicio>();
builder.Services.AddScoped<ComisionServicio>();
builder.Services.AddScoped<MateriaServicio>();
builder.Services.AddScoped<CursoServicio>();
builder.Services.AddScoped<PersonaServicio>();
builder.Services.AddScoped<UsuarioServicio>();
builder.Services.AddScoped<DocenteCursoServicio>();
builder.Services.AddScoped<InscripcionServicio>();
builder.Services.AddScoped<ReporteServicio>();
builder.Services.AddScoped<SesionService>();

builder.Services.AddScoped<JwtTokenService>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie(options =>
    {
        options.Cookie.Name = "AcademiaTPI.Auth";
        options.Cookie.HttpOnly = true;
        options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
        options.Cookie.SameSite = SameSiteMode.Strict;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/login";
    });
builder.Services.AddAuthorization();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AcademiaContext>();
    context.Database.EnsureCreated();
}

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapPost("/api/auth/login", async (LoginRequest req, HttpContext http, UsuarioServicio servicio, JwtTokenService jwt) =>
{
    var usuario = servicio.Login(req.NombreUsuario, req.Clave);
    if (usuario == null)
        return Results.Unauthorized();

    var token = jwt.GenerarToken(usuario);

    var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, usuario.NombreUsuario),
        new Claim(ClaimTypes.NameIdentifier, (usuario.PersonaId ?? 0).ToString()),
        new Claim(ClaimTypes.Role, (usuario.Persona?.Tipo ?? Dominio.Persona.TiposPersonas.Alumno).ToString()),
        new Claim("Nombre", usuario.Persona?.Nombre ?? ""),
        new Claim("Apellido", usuario.Persona?.Apellido ?? ""),
        new Claim("PersonaId", (usuario.PersonaId ?? 0).ToString()),
        new Claim("jwt", token)
    };
    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
    await http.SignInAsync(
        CookieAuthenticationDefaults.AuthenticationScheme,
        new ClaimsPrincipal(identity));

    return Results.Ok(new { token });
});

app.MapPost("/api/auth/logout", async (HttpContext http) =>
{
    await http.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    return Results.Ok();
});

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

public record LoginRequest(string NombreUsuario, string Clave);
