using Dominio;
using Servicios;

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

            g.MapGet("", (PersonaServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, PersonaServicio s) =>
                s.GetOne(id) is Persona p ? Results.Ok(p) : Results.NotFound());
            g.MapGet("/por-tipo/{tipo}", (Persona.TiposPersonas tipo, PersonaServicio s) => s.GetByTipo(tipo));
            g.MapGet("/por-legajo/{legajo:int}", (int legajo, PersonaServicio s) =>
                s.GetByLegajo(legajo) is Persona p ? Results.Ok(p) : Results.NotFound());
            g.MapPost("", (Persona cuerpo, PersonaServicio s) =>
            {
                s.Save(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapPut("/{id:int}", (int id, Persona cuerpo, PersonaServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
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

            g.MapGet("", (UsuarioServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, UsuarioServicio s) =>
                s.GetOne(id) is Usuario u ? Results.Ok(u) : Results.NotFound());
            g.MapGet("/por-usuario/{nombreUsuario}", (string nombreUsuario, UsuarioServicio s) =>
                s.GetByUsername(nombreUsuario) is Usuario u ? Results.Ok(u) : Results.NotFound());
            g.MapPost("", (Usuario cuerpo, UsuarioServicio s) =>
            {
                s.Save(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapPut("/{id:int}", (int id, Usuario cuerpo, UsuarioServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
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