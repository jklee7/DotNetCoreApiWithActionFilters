using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DotNetCoreApiWithActionFilters.Controllers
{
    [Route("/api/v1/message")]
    public class MessageController : Controller
    {
        [HttpGet()]
        public async Task<IActionResult> GetSecretMessage()
        {
            return Ok($"You've reached the secret message page!!!");
        }
    }
}
