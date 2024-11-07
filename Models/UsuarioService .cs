namespace WebPostgreSQL.Models.UsuarioService
{
    public class UsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        // Método para verificar credenciais
        public Usuario VerificarCredenciais(string nomeUsuario, string senhaUsuario)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Nome_Usuario == nomeUsuario && u.Senha_Usuario == senhaUsuario);
        }
    }
}
