using Microsoft.AspNetCore.Mvc;
using SeidorApi.Core.InputModel;

namespace SeidorApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpPost]
    public IActionResult Login(LoginInputModel loginInputModel)
    {

        return Ok();
    }
}
