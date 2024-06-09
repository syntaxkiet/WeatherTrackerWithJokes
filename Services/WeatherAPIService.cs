using MauiWeatherApp.Models.ApiModels;
using System.Net.Http.Json;

namespace MauiWeatherApp.Services;

internal class WeatherAPIService
{
    private readonly HttpClient _httpClient;

    public WeatherAPIService()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
    }

    public async Task<WeatherAPIResponse> GetWeatherInformation(string latitude, string longitude)
    {
        if(Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            return null;

        return await _httpClient.GetFromJsonAsync<WeatherAPIResponse>($"current?access_key={Constants.API_KEY}&query={latitude},{longitude}");
    }
}
