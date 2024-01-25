using App_Coordinates.Models.Dto;
using App_APIGeolocation.Models.Dto;
using App_APIGeolocation.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Text.Json;


namespace App_APIGeolocation.Controllers
{

  [Route("api/geolocation")]
  [ApiController]
  public class APIGeolocationController : ControllerBase
  {
    [HttpGet("address")]
    // public async Task<IEnumerable<APIGeolocationDTO>> GetGeocoding()
    public async Task<ActionResult<string>> GetGeocoding(string address)
    {
      return Ok(await APIGeolocationService.GetGeocodingAPI(address));
    }

    [HttpGet("coordinates")]
    public async Task<ActionResult<string>> GetCoordinates(string latitude, string longitude)
    {
      return Ok(await APIGeolocationService.GetForecastAPI(latitude, longitude));
    }
  }
}