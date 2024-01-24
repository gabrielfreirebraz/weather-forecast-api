using App_APIGeolocation.Models.Dto;
using App_APIGeolocation.Service;
using Microsoft.AspNetCore.Mvc;

namespace App_APIGeolocation.Controllers
{

  [Route("api/Address")]
  [ApiController]
  public class APIGeolocationController : ControllerBase
  {
    [HttpGet]
    public IEnumerable<APIGeolocationDTO> GetAddress()
    {
      return APIGeolocationService.listTemp;
    }
  }
}