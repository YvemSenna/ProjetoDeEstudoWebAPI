using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepositorio _usuarioRepositorio;

    public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
    }

    [HttpGet]
    public async Task<ActionResult <List<UsuarioController>>> BuscarTodosUsuario()
    {
        List<UsuarioModel> usuario = await _usuarioRepositorio.BuscarTodosUsuarios();
        return Ok(usuario);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UsuarioController>> BuscarPorId(int id)
    {
        UsuarioModel usuario = await _usuarioRepositorio.BuscarPorId(id);
        return Ok(usuario);
    }

    [HttpPost]
    public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel)
    {
        UsuarioModel usuario = await _usuarioRepositorio.Adicionar(usuarioModel);
        return Ok(usuario);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuarioModel, int id)
    {
        usuarioModel.Id = id;
        UsuarioModel usuario = await _usuarioRepositorio.Atualizar(usuarioModel, id);
        return Ok(usuario);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<UsuarioModel>> Apagar(int id)
    {
        bool apagar = await _usuarioRepositorio.Apagar(id);
        return Ok(apagar);
    }
}
