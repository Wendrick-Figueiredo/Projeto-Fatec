using Microsoft.AspNetCore.Mvc;
using WebPostgreSQL.Models.UsuarioService;

public class AuthController : Controller
{
    private readonly UsuarioService _usuarioService;

    public AuthController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    public IActionResult Login(string Nome_Usuario, string Senha_Usuario)
    {
        var usuario = _usuarioService.VerificarCredenciais(Nome_Usuario, Senha_Usuario);

        if (usuario != null)
        {
            HttpContext.Session.SetString("UsuarioId", usuario.UsuarioId.ToString());
            return RedirectToAction("Login", "Home");
        }
        else
        {
            ViewBag.ErrorMessage = "Usuário ou senha incorretos.";
            return View();
        }
    }
}
