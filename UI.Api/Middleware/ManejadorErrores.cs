using Servicios.Excepciones;

namespace UI.Api.Middleware
{
    public static class ManejadorErroresExtensions
    {
        public static IApplicationBuilder UseManejadorErrores(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                try
                {
                    await next();
                }
                catch (Exception ex) when (ex is ServicioException or ArgumentException)
                {
                    if (context.Response.HasStarted)
                        throw;

                    var (status, cuerpo) = Clasificar(ex, context);
                    context.Response.Clear();
                    context.Response.StatusCode = status;
                    context.Response.ContentType = "application/json; charset=utf-8";
                    await context.Response.WriteAsJsonAsync(cuerpo);
                }
            });
        }

        private static (int Status, object Cuerpo) Clasificar(Exception ex, HttpContext context)
        {
            switch (ex)
            {
                case AccesoNoAutorizadoException:
                    var autenticado = context.User?.Identity?.IsAuthenticated == true;
                    return (autenticado ? StatusCodes.Status403Forbidden : StatusCodes.Status401Unauthorized,
                            new { error = ex.Message });
                case ValidacionException v:
                    return (StatusCodes.Status400BadRequest,
                            string.IsNullOrWhiteSpace(v.Campo)
                                ? new { error = v.Message }
                                : new { error = v.Message, campo = v.Campo });
                case ReglaNegocioException:
                case ServicioException:
                    return (StatusCodes.Status400BadRequest, new { error = ex.Message });
                case ArgumentException a:
                    return (StatusCodes.Status400BadRequest, new { error = a.Message });
                default:
                    return (StatusCodes.Status500InternalServerError, new { error = "Ocurrió un error inesperado." });
            }
        }
    }
}