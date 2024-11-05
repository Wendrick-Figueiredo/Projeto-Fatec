using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebPostgreSQL.Models;

public static class HashHelper
{
    public static string HashSenha(string Senha_Usuario)
    {
        using (var sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Senha_Usuario));
            return Convert.ToBase64String(bytes);
        }
    }
}

public class UsuarioService
{
    private readonly Contexto _context;

    public UsuarioService(Contexto context)
    {
        _context = context;
    }

    public async Task<bool> VerificarUsuarioAsync(string Nome_Usuario, string Senha_Usuario)
    {
        string senhaHash = HashHelper.HashSenha(Senha_Usuario);

        // Corrigido: `_context.Usuarios.AnyAsync(...)` agora se refere corretamente ao DbSet
        return await _context.Usuarios
            .AnyAsync(u => u.Nome_Usuario == Nome_Usuario && u.Senha_Usuario == senhaHash);
    }
}

public class AuthController : Controller
{
    private readonly UsuarioService _usuarioService;

    public AuthController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost]
    public async Task<IActionResult> Login(string Nome_Usuario, string Senha_Usuario)
    {
        bool usuarioValido = await _usuarioService.VerificarUsuarioAsync(Nome_Usuario, Senha_Usuario);

        if (usuarioValido)
        {
            // Aqui, você pode configurar a sessão ou gerar um token
            return Ok("Login bem-sucedido!");
        }
        else
        {
            return Unauthorized("Usuário ou senha inválidos.");
        }
    }
}

