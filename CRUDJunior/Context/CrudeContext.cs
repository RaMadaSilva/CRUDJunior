using CRUDJunior.Models;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace CRUDJunior.Context
{
    public class CrudeContext : DbContext
    {
        public CrudeContext(DbContextOptions<CrudeContext> options): base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Assinatura> Assinaturas { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
        }
    }
}
