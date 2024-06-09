using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWeatherApp.Models.ApiModels
{
    public class DadJokesAPI
    {
        public async Task<string> GetDadJokeAsync()
        {
   
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", Constants.NINJA_API_KEY);

                HttpResponseMessage response = await client.GetAsync(Constants.NINJA_API_BASE_URL);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var jokes = Newtonsoft.Json.JsonConvert.DeserializeObject<Joke[]>(jsonResponse);
                    return jokes.Length > 0 ? jokes[0].DadJoke : "No joke found.";
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
        }
    }
}
