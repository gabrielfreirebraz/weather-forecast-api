using App_APIGeolocation.Models.Dto;
using System.Text.Json;


namespace App_APIGeolocation.Service
{

  public static class APIGeolocationService
  {

    // public static List<APIGeolocationDTO> listTemp =
    // new List<APIGeolocationDTO> {
    //     new APIGeolocationDTO{ Id= 1, Address= "R XYZ, 97" }
    // };


    public static async Task<string> GetAPI(string address)
    {

      // using (HttpClient client = new HttpClient())
      HttpClient client = new HttpClient();

      // Replace the URL with the actual URL you want to request
      string url = $"https://geocoding.geo.census.gov/geocoder/locations/onelineaddress?address={address}&benchmark=2020&format=json";
      Console.WriteLine(url);
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

      //Structure number and street name (required)
    }
  }
}