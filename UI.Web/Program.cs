using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Servicios;
using Repositorio;
using UI.Web.Services;
using UI.Web;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

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
builder.Services.AddSingleton<SesionService>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
