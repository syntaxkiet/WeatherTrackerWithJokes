using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWeatherApp.Models
{
    public class Joke
    {
        [Newtonsoft.Json.JsonProperty("joke")]
        public string DadJoke { get; set; }   
    }
}
