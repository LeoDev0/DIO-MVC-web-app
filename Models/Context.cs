using Microsoft.EntityFrameworkCore;
using System;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
            // optionsBuilder.UseSqlServer(@"Server=(localhost)\mssqllocaldb;Database=Cursomvc;Integrated Security=true");
            // optionsBuilder.UseSqlServer("server=.;database=Cursomvc;Integrated Security = True;");
            optionsBuilder.UseSqlServer("Server=localhost;Database=Cursomvc;User Id=SA;Password=Leo12345");
        }
    }
}