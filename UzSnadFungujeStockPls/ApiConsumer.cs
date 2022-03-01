using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UzSnadFungujeStockPls
{
    public interface IApiConsumer
    {
        string URL { get; set; }
        Task<string> ApiConsume();
    }

    public class ApiConsumer : IApiConsumer
    {
        HttpClient client = new HttpClient();
        public string URL { get; set; }

        public async Task<string> ApiConsume()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(URL),
                Headers =
                    {
                        { "x-rapidapi-host", "stock-market-data.p.rapidapi.com" },
                        { "x-rapidapi-key", "dc7955859amshc5dc1e80a08781cp175485jsn658cc1989fdb" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return body;
            }
        }
    }
}
