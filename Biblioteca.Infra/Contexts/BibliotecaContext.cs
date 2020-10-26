using Microsoft.EntityFrameworkCore;
using Biblioteca.Domain;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Infra.Contexts
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }

        public DbSet<Livros> Bibliotecas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livros>().ToTable("Livros");
            modelBuilder.Entity<Livros>().Property(x => x.Id);
            modelBuilder.Entity<Livros>().Property(x => x.NomeDoAutor);
            modelBuilder.Entity<Livros>().Property(x => x.NomeDoLivro);
            modelBuilder.Entity<Livros>().Property(x => x.NumeroDePaginas);
        }

    }
}