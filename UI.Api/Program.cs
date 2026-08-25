using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Repositorio;
using Servicios;
using UI.Api.Auth;
using UI.Api.Endpoints;
using UI.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<AcademiaContext>();
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

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
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

app.UseHttpsRedirection();
app.UseCors("Permisiva");
app.UseAuthentication();
app.UseAuthorization();

app.MapPost("/api/auth/login", (LoginRequest req, UsuarioServicio servicio, JwtTokenService jwt) =>
{
    var usuario = servicio.Login(req.NombreUsuario, req.Clave);
    if (usuario == null)
        return Results.Unauthorized();

    var token = jwt.GenerarToken(usuario);
    return Results.Ok(new { token });
});

app.MapApiEndpoints();

app.Run();

public record LoginRequest(string NombreUsuario, string Clave);