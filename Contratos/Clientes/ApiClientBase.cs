using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Contratos
{
    public abstract class ApiClientBase
    {
        protected static readonly JsonSerializerOptions JsonOpciones = new()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter() }
        };

        protected readonly HttpClient Http;
        protected readonly IApiTokenProvider TokenProvider;

        protected ApiClientBase(HttpClient http, IApiTokenProvider tokenProvider)
        {
            Http = http;
            TokenProvider = tokenProvider;
        }

        protected async Task<T> GetAsync<T>(string url)
        {
            using var respuesta = await EnviarAsync(HttpMethod.Get, url, null);
            return await LeerAsync<T>(respuesta);
        }

        protected async Task<T?> GetOrNullAsync<T>(string url) where T : class
        {
            using var respuesta = await Http.SendAsync(ConstruirRequest(HttpMethod.Get, url));
            if (respuesta.StatusCode == System.Net.HttpStatusCode.NotFound) return null;
            if (!respuesta.IsSuccessStatusCode) await LanzarApiExceptionAsync(respuesta);
            return await LeerAsync<T>(respuesta);
        }

        protected async Task<T> PostAsync<T>(string url, object cuerpo)
        {
            using var respuesta = await EnviarAsync(HttpMethod.Post, url, cuerpo);
            return await LeerAsync<T>(respuesta);
        }

        protected async Task<T> PutAsync<T>(string url, object cuerpo)
        {
            using var respuesta = await EnviarAsync(HttpMethod.Put, url, cuerpo);
            return await LeerAsync<T>(respuesta);
        }

        protected async Task SendAsync(string url, object cuerpo)
        {
            using var respuesta = await EnviarAsync(HttpMethod.Post, url, cuerpo);
        }

        protected async Task SendPutAsync(string url, object cuerpo)
        {
            using var respuesta = await EnviarAsync(HttpMethod.Put, url, cuerpo);
        }

        protected async Task DeleteAsync(string url)
        {
            using var respuesta = await EnviarAsync(HttpMethod.Delete, url, null);
        }

        protected async Task<byte[]> GetBytesAsync(string url)
        {
            using var respuesta = await EnviarAsync(HttpMethod.Get, url, null);
            return await respuesta.Content.ReadAsByteArrayAsync();
        }

        private async Task<HttpResponseMessage> EnviarAsync(HttpMethod metodo, string url, object? cuerpo)
        {
            var request = ConstruirRequest(metodo, url);
            if (cuerpo != null)
            {
                request.Content = JsonContent.Create(cuerpo, options: JsonOpciones);
            }
            var respuesta = await Http.SendAsync(request);
            if (!respuesta.IsSuccessStatusCode)
            {
                using (respuesta)
                {
                    await LanzarApiExceptionAsync(respuesta);
                }
            }
            return respuesta;
        }

        private HttpRequestMessage ConstruirRequest(HttpMethod metodo, string url)
        {
            var request = new HttpRequestMessage(metodo, url);
            var token = TokenProvider.Token;
            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }
            return request;
        }

        private static async Task<T> LeerAsync<T>(HttpResponseMessage respuesta)
        {
            var resultado = await respuesta.Content.ReadFromJsonAsync<T>(JsonOpciones);
            if (resultado == null)
            {
                throw new ApiException(respuesta.StatusCode, "Respuesta vacía del servidor.");
            }
            return resultado;
        }

        private static async Task LanzarApiExceptionAsync(HttpResponseMessage respuesta)
        {
            string mensaje;
            try
            {
                var problem = await respuesta.Content.ReadFromJsonAsync<ProblemDetails>(JsonOpciones);
                mensaje = problem?.Detail ?? problem?.Title ?? $"Error HTTP {(int)respuesta.StatusCode}.";
            }
            catch (JsonException)
            {
                mensaje = $"Error HTTP {(int)respuesta.StatusCode}.";
            }
            throw new ApiException(respuesta.StatusCode, mensaje);
        }

        private sealed class ProblemDetails
        {
            public string? Title { get; set; }
            public string? Detail { get; set; }
        }
    }
}
