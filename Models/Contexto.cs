using Microsoft.EntityFrameworkCore;
public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options)
       : base(options)    
    {

    }

    public DbSet<Usuario> Usuarios { get; set; }
}