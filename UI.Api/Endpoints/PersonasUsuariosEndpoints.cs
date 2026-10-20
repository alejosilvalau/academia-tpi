using Contratos;
using Dominio;
using Servicios;
using UI.Api.Mapping;

namespace UI.Api.Endpoints
{
    public static class PersonasUsuariosEndpoints
    {
        public static IEndpointRouteBuilder MapPersonasUsuariosEndpoints(this IEndpointRouteBuilder app)
        {
            MapPersonas(app);
            MapUsuarios(app);
            return app;
        }

        private static void MapPersonas(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/personas").WithTags("Personas").RequireAuthorization();

            g.MapGet("", (PersonaServicio s) => Results.Ok(s.GetAll().Select(p => p.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, PersonaServicio s) =>
                s.GetOne(id) is Persona p ? Results.Ok(p.ADto()) : Results.NotFound());
            g.MapGet("/basico/{id:int}", (int id, PersonaServicio s) =>
                s.GetOneBasico(id) is Persona p ? Results.Ok(p.ADto()) : Results.NotFound());
            g.MapGet("/por-tipo/{tipo}", (TipoPersona tipo, PersonaServicio s) =>
                Results.Ok(s.GetByTipo(tipo).Select(p => p.ADto()).ToList()));
            g.MapGet("/por-legajo/{legajo:int}", (int legajo, PersonaServicio s) =>
                s.GetByLegajo(legajo) is Persona p ? Results.Ok(p.ADto()) : Results.NotFound());
            g.MapPost("", (PersonaRequest cuerpo, PersonaServicio s) =>
            {
                var entidad = cuerpo.AEntidad();
                s.Save(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapPut("/{id:int}", (int id, PersonaRequest cuerpo, PersonaServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapDelete("/{id:int}", (int id, PersonaServicio s) =>
            {
                var p = s.GetOne(id);
                if (p == null) return Results.NotFound();
                s.Delete(p);
                return Results.NoContent();
            });
        }

        private static void MapUsuarios(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/usuarios").WithTags("Usuarios").RequireAuthorization();

            g.MapGet("", (UsuarioServicio s) => Results.Ok(s.GetAll().Select(u => u.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, UsuarioServicio s) =>
                s.GetOne(id) is Usuario u ? Results.Ok(u.ADto()) : Results.NotFound());
            g.MapGet("/por-usuario/{nombreUsuario}", (string nombreUsuario, UsuarioServicio s) =>
                s.GetByUsername(nombreUsuario) is Usuario u ? Results.Ok(u.ADto()) : Results.NotFound());
            g.MapPost("", (UsuarioRequest cuerpo, UsuarioServicio s) =>
            {
                var entidad = cuerpo.AEntidad();
                s.Save(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapPut("/{id:int}", (int id, UsuarioRequest cuerpo, UsuarioServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapDelete("/{id:int}", (int id, UsuarioServicio s) =>
            {
                var u = s.GetOne(id);
                if (u == null) return Results.NotFound();
                s.Delete(u);
                return Results.NoContent();
            });
        }
    }
}
