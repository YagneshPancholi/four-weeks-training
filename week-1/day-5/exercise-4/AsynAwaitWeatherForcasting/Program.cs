using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AsynAwaitWeatherForcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string city = "Delhi";
            // Call the method to fetch weather data
            Console.WriteLine(city);
            FetchWeatherDataAsync(city);
            // Display the weather data with city name

            Console.ReadLine();
           
        }
        class WeatherData
        {
            public MainData Main { get; set; }

            public class MainData
            {
                public float Temp { get; set; }
                public int Humidity { get; set; }
            }
        }
        // Call OpenWeatherMap API to fetch weather data https://openweathermap.org/api
        // Create a C# object from the JSON response
        // Replace Task<string> with the C# object Task<WeatherData>
        static async Task<string> FetchWeatherDataAsync(string city)
        {
            // Fetch web page content asynchronously using HttpClient
            string country = "+91";
            string apikey = "cc7c0b220918014d8fd709d9f510b575";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&lang=en&appid={apikey}";
            //string url = $"http://api.openweathermap.org/geo/1.0/direct?q={city},{country}&lang=en&appid={apikey}";
            Console.WriteLine(url);
            using(HttpClient client = new HttpClient()) {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Process the weather data
                    Console.WriteLine(responseBody);
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                    Console.WriteLine($"Temperature: {weatherData.Main.Temp}°C");
                    Console.WriteLine($"Humidity: {weatherData.Main.Humidity}%");
                   
                    //weatherData.Main.
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Error occurred: {0}", e.Message);
                }
            }
            return "abs";
        }
    }
}