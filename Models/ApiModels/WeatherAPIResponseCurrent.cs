using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiWeatherApp.Models.ApiModels
{
    public class WeatherAPIResponseCurrent
    {
        [JsonPropertyName("observation_time")]
        public string ObservationTime { get; set; }

        [JsonPropertyName("temperature")]
        public int Temperature { get; set; }

        [JsonPropertyName("weather_code")]
        public int WeatherCode { get; set; }

        [JsonPropertyName("weather_icons")]
        public string[] WeatherIcons { get; set; }

        [JsonPropertyName("weather_descriptions")]
        public string[] WeatherDescriptions { get; set; }

        [JsonPropertyName("wind_speed")]
        public int WindSpeed { get; set; }

        [JsonPropertyName("wind_degree")]
        public int WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string WindDirection { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("precip")]
        public float PrecipitationLevel { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("cloudcover")]
        public int CloudCoverLevel { get; set; }

        [JsonPropertyName("feelslike")]
        public int FeelsLike { get; set; }

        [JsonPropertyName("uv_index")]
        public int UvIndex { get; set; }

        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        [JsonPropertyName("is_day")]
        public string IsDay { get; set; }
    }
}
