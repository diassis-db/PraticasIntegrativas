
using Newtonsoft.Json;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.services
{
    public class FilmeHttpClient
    {
        private string endPoint = "https://localhost:7092/salacinema/v1/filmes";

        HttpClient client;

        public FilmeHttpClient()
        {
        }

        public FilmeHttpClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<Response> PostFilme(FilmesDto filmes) 
        {
            client = new HttpClient();
            var dados = JsonConvert.SerializeObject(filmes);
            var request = new HttpRequestMessage(HttpMethod.Post, endPoint);
            request.Headers.Add("Content-Type", "application/json");
            request.Content = new StringContent(dados.ToString(), Encoding.UTF8, "application/json");
            var responseFilme = client.SendAsync(request).Result;
            var contentResponse = responseFilme.Content.ReadAsStringAsync().Result;
            var responseResult = JsonConvert.DeserializeObject<Response>(contentResponse);
            if (responseFilme.IsSuccessStatusCode) 
            { 
                return new Response{ Messager = responseResult.Messager, StatusCode = responseResult.StatusCode};
            }
            return new Response { Messager = responseResult.Messager };
        }

    }
}
