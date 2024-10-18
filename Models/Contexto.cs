using Microsoft.EntityFrameworkCore;

namespace WebPostgreSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
    public class ContextoUser : DbContext
    {
        public ContextoUser(DbContextOptions<ContextoUser> options)
            : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
