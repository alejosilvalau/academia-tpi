using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Repositorio;
using Servicios;
using Servicios.Excepciones;
using System.Text;
using System.Text.Json.Serialization;
using UI.Api.Auth;
using UI.Api.Endpoints;
using UI.Api.Middleware;
using UI.Api.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContextPool<AcademiaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUsuarioContexto, UsuarioContextoApi>();
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
builder.Services.AddScoped<JwtTokenService>();

builder.Services.AddCors(options =>
    options.AddPolicy("Permisiva", policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidateAudience = true,
            ValidAudience = builder.Configuration["Jwt:Audience"],
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)),
            ClockSkew = TimeSpan.FromMinutes(1)
        };
    });
builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Academia TPI API",
        Version = "v1",
        Description = "API REST de la Academia (TPI). Autenticación mediante JWT: POST /api/auth/login."
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Ingrese el token JWT obtenido en POST /api/auth/login."
    });

    options.OperationFilter<QuitarSeguridadParaAnonimos>();
});

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AcademiaContext>();
    context.Database.EnsureCreated();
}

app.UseManejadorErrores();

app.UseSwagger();
app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "Academia TPI API v1"));

if (!app.Environment.IsDevelopment())
    app.UseHttpsRedirection();
app.UseCors("Permisiva");
app.UseAuthentication();
app.UseAuthorization();

app.MapPost("/api/auth/login", (Contratos.LoginRequest req, UsuarioServicio servicio, JwtTokenService jwt) =>
{
    Dominio.Usuario? usuario;
    try
    {
        usuario = servicio.Login(req.NombreUsuario, req.Clave);
    }
    catch (AccesoNoAutorizadoException ex)
    {
        return Results.Json(new { error = ex.Message }, statusCode: StatusCodes.Status401Unauthorized);
    }

    if (usuario == null)
        return Results.Json(new { error = "Usuario o clave incorrectos." }, statusCode: StatusCodes.Status401Unauthorized);

    var token = jwt.GenerarToken(usuario);
    return Results.Ok(new Contratos.LoginResponse(
        token,
        usuario.NombreUsuario,
        usuario.PersonaId,
        usuario.Persona?.Tipo,
        usuario.Persona?.Legajo,
        usuario.Persona?.Nombre,
        usuario.Persona?.Apellido,
        usuario.Habilitado));
}).WithTags("Login").AllowAnonymous();

app.MapApiEndpoints();

app.Run();
