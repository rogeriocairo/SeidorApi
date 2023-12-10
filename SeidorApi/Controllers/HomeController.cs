using Microsoft.AspNetCore.Mvc;
using SeidorApi.Core.Entities;
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
            var _usuario = await _userService.ObterUsuarioAsync(loginInputModel.Email, loginInputModel.Senha);
            return Ok(_usuario);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("ListarUsuarios")]
    public async Task<IActionResult> ListarUsuarios()
    {
        try
        {
            var _usuario = await _userService.ListarUsuariosAsync();
            return Ok(_usuario);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("InserirUsuarios")]
    public async Task<IActionResult> InserirUsuarios(UserEntity userEntity)
    {
        try
        {
            await _userService.InserirUsuariosAsync(userEntity);
            return Ok($"Usuário Criado");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("EditarUsuarios")]
    public async Task<IActionResult> AlterarUsuarios(UserEntity userEntity)
    {
        try
        {
            var _usuario = await _userService.EditarUsuariosAsync(userEntity);
            return Ok($"Usuário Alterado - {_usuario}");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
