using Microsoft.EntityFrameworkCore;
using SuaCarteiraEmDia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaCarteiraEmDia.Data
{
    public class DataContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //faculdade ==> LABBPC09\\SQLSERVER2014ECE
            string DataSource = "LABBPC03\\SQLSERVER2014ECE"; 
            optionsBuilder.UseSqlServer($"Data Source={DataSource}; Initial Catalog=DBSuaCarteiraEmDia; Integrated Security=SSPI; Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movimentacao>()
              .HasOne(m => m.Usuario)
              .WithMany()
              .HasForeignKey(m => m.UsuarioID)
              .HasConstraintName("FK_Movimentacoes_Usuarios_UsuarioID")
              .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<PerguntaSeguranca> Perguntas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Movimentacao> Movimentacoes { get; set; }
    }
}
