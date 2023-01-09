using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Comfortable.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public string Get() => "Salom Dunyo";
    }
}
