using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiApp.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class AuthTestController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Congratulations you are authenticated!";
        }
    }
}