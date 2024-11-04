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

    public class ContextoPaciente : DbContext
    {
        public ContextoPaciente(DbContextOptions<ContextoPaciente> options)
            : base(options)
        {
        }
        public DbSet<Paciente> Pacientes { get; set; }
    }

    public class ContextoMedico : DbContext
    {
        public ContextoMedico(DbContextOptions<ContextoMedico> options)
            : base(options)
        {
        }
        public DbSet<Medico> Medicos { get; set; }
    }
    public class ContextoConsulta : DbContext
    {
        public ContextoConsulta(DbContextOptions<ContextoConsulta> options)
            : base(options)
        {
        }
        public DbSet<Consulta> Consultas { get; set; }
    }
}
