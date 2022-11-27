<!-- LOGO -->
<br />
<h1>
<p align="center">
  <img src="https://raw.githubusercontent.com/bxdavies/NET-WeatherAPI/main/icon.png" alt="Logo" width="140" height="110">
  <br>NET Weather API
</h1>
  <p align="center">
    Unofficial .NET API client for the weather API available at weatherapi.com. 
    <br />
    </p>
</p>
<p align="center">
  <a href="#about-the-project">About The Project</a> •
  <a href="#installation">How To Use</a> •
  <a href="#examples">Examples</a> •
  <a href="#credits">Credits</a>
</p>  

<p align="center">
  
![screenshot](img/clip.gif)
</p>                                                                                                                             
                                                                                                                                                      
## About The Project
WeatherAPI.com provides access to weather and geo data via a JSON/XML restful API. It allows developers to create desktop, web and mobile applications using this data very easy.

They provide following data through our API:

- Real-time weather
- 10 day weather forecast
- Astronomy
- Time zone
- Location data
- Search or Autocomplete API
- Historical weather


## Installation





## Usage
### API key

You need an API key to be able to authenticate with the API. You can either [sign up](https://www.weatherapi.com/signup.aspx) for, or [log in](https://www.weatherapi.com/login.aspx) to WeatherAPI to get your API key.

### Creating the client

`WeatherAPIClient` accepts two constructor parameters: your API key, and a custom base URI for the API. A valid API key must be provided, but specifying a base URI is optional.

```
string apiKey = "your API key";

WeatherAPIClient weatherApiClient = new WeatherAPIClient(apiKey);
```
## Using the API

API routes are separated out into category classes, referred to as operations, within the client. These classes contain all routes associated with the category, as well as overflow methods providing different request configurations.

Where required, or where available, you'll have the option to provide a request object to the method. The type of request object required is determined by the method you are trying to invoke, but all request objects adopt a fluent API style configuration layout, for example:

```
RequestEntity request = new RequestEntity()
    .WithCityName("Paris")
    .WithLanguage("fr");
```

Different request objects exist to provide extra configuration for the category of request you're trying to make. For example, you can request air quality data with the realtime routes:

```
RealtimeRequestEntity request = new RealtimeRequestEntity()
    .WithCityName("Paris")
    .WithLanguage("fr")
    .WithAirQualityData(true);
```

## Examples
Check out the `samples` folder in the repository this repository was forked from, by clicking [here](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples).

## Credits
- Credit to [@lewisbennett ](https://github.com/lewisbennett/weatherapi-Net-Standard) for all code. I have made this repository so I can create a NuGet package with correctly working Moon and Sun set and rise times. 
