using System.Reflection;
using System.Security.AccessControl;

namespace Academia.Mvc;

public class ApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    public DbSet<Aluno> Aluno { get; set; }
    public DbSet<Profissional> Profissional { get; set; }
    public DbSet<Plano> Planos { get; set; }
    public DbSet<AvaliacaoFisica> AvaliacoesFisicas { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public DbSet<Inscricao> Inscricoes { get; set; }
    public DbSet<Produto> Produtos { get; set; } 
    }
