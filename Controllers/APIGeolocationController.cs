using App_APIGeolocation.Models.Dto;
using App_APIGeolocation.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace App_APIGeolocation.Controllers
{

  [Route("api/coordinates")]
  [ApiController]
  public class APIGeolocationController : ControllerBase
  {
    [HttpGet("address")]
    // public async Task<IEnumerable<APIGeolocationDTO>> GetAddress()
    public async Task<string> GetAddress(string address)
    {
      // var t = await APIGeolocationService.GetLatLong();
      // Console.WriteLine(address);
      // return APIGeolocationService.listTemp;
      return await APIGeolocationService.GetLatLong(address);
    }
  }
}