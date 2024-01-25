using App_Coordinates.Models.Dto;
using App_APIGeolocation.Models.Dto;
using App_APIGeolocation.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Text.Json;


namespace App_APIGeolocation.Controllers
{

  [Route("api/coordinates")]
  [ApiController]
  public class APIGeolocationController : ControllerBase
  {
    [HttpGet("address")]
    // public async Task<IEnumerable<APIGeolocationDTO>> GetAddress()
    public async Task<ActionResult<string>> Get(string address)
    {
      // var t = await APIGeolocationService.GetLatLong();
      // Console.WriteLine(address);
      // return APIGeolocationService.listTemp;
      return await APIGeolocationService.GetAPI(address);
    }
  }
}