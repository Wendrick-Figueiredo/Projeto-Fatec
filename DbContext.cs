using Microsoft.EntityFrameworkCore;
public class SeuDbContext : DbContext
{
    public SeuDbContext(DbContextOptions<SeuDbContext> options)
        : base(options)
    {

    }

    // Defina os DbSet's (tabelas) aqui
    public DbSet<MeuModel> MeusModelos { get; set; }
}

