using Contratos;
using UI.Web.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<SesionService>();
builder.Services.AddScoped<Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider>(
    sp => sp.GetRequiredService<SesionService>());
builder.Services.AddScoped<IApiTokenProvider>(sp => sp.GetRequiredService<SesionService>());

var apiBaseUrl = builder.Configuration["Api:BaseUrl"] ?? "http://localhost:5006/";
builder.Services.AddHttpClient<AuthClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<EspecialidadClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<PlanClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<MateriaClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<ComisionClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<CursoClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<PersonaClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<UsuarioClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<DocenteCursoClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<InscripcionClient>(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddHttpClient<ReporteClient>(c => c.BaseAddress = new Uri(apiBaseUrl));

var app = builder.Build();

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
