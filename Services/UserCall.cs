using Emilia_Morejon_ExamenP3.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;


namespace Emilia_Morejon_ExamenP3.Services
{
    public class UserCall
    {
        public async Task<Root> GetUsers()
        {
            Root resp = new Root();

            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://reqres.in/api/users?page=2");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");

            var client = new HttpClient();

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                resp = JsonConvert.DeserializeObject<Root>(content);
                return resp;
            }
            else
            {
                return null;
            }
        }
    }
}