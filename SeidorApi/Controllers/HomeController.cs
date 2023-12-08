using Microsoft.AspNetCore.Mvc;
using SeidorApi.Core.InputModel;
using SeidorApi.Core.Interfaces;

namespace SeidorApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly IUserService _userService;

    public HomeController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginInputModel loginInputModel)
    {
        try
        {
            var _usuario = await _userService.ObterUsuario(loginInputModel.Email, loginInputModel.Senha);
            return Ok(_usuario);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
