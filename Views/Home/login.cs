
// using Microsoft.EntityFrameworkCore;

// public class UsuarioService
// {
//     private readonly ApplicationDbContext _context;

//     public UsuarioService(ApplicationDbContext context)
//     {
//         _context = context;
//     }

//     public async Task<bool> VerificarUsuarioAsync(string email, string senha)
//     {
//         string senhaHash = HashHelper.HashPassword(senha);

//         return await _context.Usuarios
//             .AnyAsync(u => u.Email == email && u.SenhaHash == senhaHash);
//     }
// }
