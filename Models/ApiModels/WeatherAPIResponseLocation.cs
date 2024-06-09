using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiWeatherApp.Models.ApiModels
{
    public class WeatherAPIResponseLocation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("lat")]
        public string Latitude { get; set; }

        [JsonPropertyName("lon")]
        public string Longitude { get; set; }

        [JsonPropertyName("timezone_id")]
        public string TimeZoneId { get; set; }

        [JsonPropertyName("localtime")]
        public string LocalTime { get; set; }

        [JsonPropertyName("localtime_epoch")]
        public int LocalTimeEpoch { get; set; }

        [JsonPropertyName("utc_offset")]
        public string UtcOffset { get; set; }
    }
}
