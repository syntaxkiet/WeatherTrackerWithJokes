using System.Text.Json.Serialization;

namespace MauiWeatherApp.Models.ApiModels;

public class WeatherAPIResponse
{
    [JsonPropertyName("request")]
    public WeatherAPIResponseRequest Request { get; set; }

    [JsonPropertyName("location")]
    public WeatherAPIResponseLocation Location { get; set; }

    [JsonPropertyName("current")]
    public WeatherAPIResponseCurrent Current { get; set; }
}


