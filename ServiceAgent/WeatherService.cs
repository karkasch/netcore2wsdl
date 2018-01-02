using System;
using System.Threading.Tasks;
using GlobalWeather;


namespace ServiceAgent
{
    public class WeatherService
    {

        public async Task<string> Test()
        {
            var addr = "http://www.webservicex.com/globalweather.asmx";
            var client = new GlobalWeatherSoapClient(GlobalWeatherSoapClient.EndpointConfiguration.GlobalWeatherSoap, addr);

            //var res = await client.GetWeatherAsync("utrecht", "netherlands");

            var cities = await client.GetCitiesByCountryAsync("netherlands");

            await client.CloseAsync();

            return cities;
        }
    }
}
