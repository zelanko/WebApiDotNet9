using Microsoft.AspNetCore.Mvc;

namespace WebApiDotNet9.Controllers.V1;

[ApiController]
public class ControllerController : ControllerBase
{

    [Route("api/v1/[controller]")]
    public string Get() => "Welcome the the controller controller!";
}