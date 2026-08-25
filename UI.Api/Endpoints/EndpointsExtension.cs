namespace UI.Api.Endpoints
{
    public static class EndpointsExtension
    {
        public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapCatalogoEndpoints();
            app.MapPersonasUsuariosEndpoints();
            app.MapAsignacionesEndpoints();
            app.MapReportesEndpoints();
            return app;
        }
    }
}