using App_APIGeolocation.Models.Dto;
using System.Text.Json;


namespace App_APIGeolocation.Service
{

  public static class APIGeolocationService
  {
    // Structure number and street name (required)
    public static async Task<string> GetGeocodingAPI(string address)
    {

      // using (HttpClient client = new HttpClient())
      HttpClient client = new HttpClient();

      // Replace the URL with the actual URL you want to request
      string url = $"https://geocoding.geo.census.gov/geocoder/locations/onelineaddress?address={address}&benchmark=2020&format=json";

      // Make a GET request
      HttpResponseMessage response = await client.GetAsync(url);

      if (response.IsSuccessStatusCode)
      {
        Console.WriteLine("Success");

        // Read the response body content
        return await response.Content.ReadAsStringAsync();
      }
      else
      {
        Console.WriteLine($"Error: {response.StatusCode}");
        return $"Error: {response.StatusCode}";
      }
    }

    public static async Task<string> GetForecastAPI(string latitude, string longitude)
    {

      // Replace the URL with the actual URL you want to request
      string url = $"https://api.weather.gov/points/{latitude},{longitude}";

      var handler = new HttpClientHandler();
      handler.UseProxy = false;

      var client = new HttpClient(handler);
      client.DefaultRequestHeaders.Add("User-Agent", "(APIGeolocation<gabrielfreirebraz.com>, gabrielfreirebraz@gmail.com)");

      // Make a GET request
      HttpResponseMessage response = await client.GetAsync(url);


      if (response.IsSuccessStatusCode)
      {
        Console.WriteLine("Success");

        // Read the response body content
        return await response.Content.ReadAsStringAsync();
      }
      else
      {
        Console.WriteLine($"Error: {response.StatusCode}");
        return $"Error: {response.StatusCode}";
      }
    }
  }
}
