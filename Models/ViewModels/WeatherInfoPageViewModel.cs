using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiWeatherApp.Models.ApiModels;
using MauiWeatherApp.Services;

namespace MauiWeatherApp.Models.ViewModels;

internal partial class WeatherInfoPageViewModel : ObservableObject
{
    private readonly WeatherAPIService _weatherAPIService;
    private readonly DadJokesAPI _dadJokesAPI;

    public WeatherInfoPageViewModel()
    {
        _weatherAPIService = new WeatherAPIService();
        _dadJokesAPI = new DadJokesAPI();
    }

    [ObservableProperty]
    private string latitude;

    [ObservableProperty]
    private string longitude;

    [ObservableProperty]
    private string weatherIcon;

    [ObservableProperty]
    private string temperature;

    [ObservableProperty]
    private string weatherDescription;

    [ObservableProperty]
    private string location;

    [ObservableProperty]
    private int humidity;

    [ObservableProperty]
    private string cloudCoverLevel;

    [ObservableProperty]
    private string isDay;

    [ObservableProperty]
    private string jokeText;

    [RelayCommand]
    private async Task FetchWeatherInformation()
    {
        var weatherApiResponse = await _weatherAPIService.GetWeatherInformation(Latitude, Longitude);
        if (weatherApiResponse != null)
        {
            WeatherIcon = weatherApiResponse.Current.WeatherIcons[0];
            Temperature = $"{weatherApiResponse.Current.Temperature}°C";
            Location = $"{weatherApiResponse.Location.Name}, {weatherApiResponse.Location.Region}, {weatherApiResponse.Location.Country}";
            WeatherDescription = weatherApiResponse.Current.WeatherDescriptions[0];
            Humidity = weatherApiResponse.Current.Humidity;
            CloudCoverLevel = $"{weatherApiResponse.Current.CloudCoverLevel}%";
            IsDay = weatherApiResponse.Current.IsDay.ToUpper();
        }
        JokeText = await _dadJokesAPI.GetDadJokeAsync();
    }
}
