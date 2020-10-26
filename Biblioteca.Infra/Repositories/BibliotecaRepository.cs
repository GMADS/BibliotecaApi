using System.Collections.Generic;
using System.Linq;
using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repositories;
using Biblioteca.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infra.Repositories
{
    public class BibliotecaRepository :IBibliotecaRepository
    {
        private readonly BibliotecaContext _context;


        public BibliotecaRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public void Adicionar(Livros biblioteca)
        {
            _context.Add(biblioteca);
            _context.SaveChanges();
        }

        public void Alterar(Livros biblioteca)
        {
            _context.Entry(biblioteca).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<Livros> ListarBibliotecas()
        {
            return _context.Bibliotecas.ToList();
        }

        public Livros ObterPorId(int id)
        {
            return _context.Bibliotecas.FirstOrDefault(x => x.Id == id);
        }


        public void RemoverBiblioteca(Livros biblioteca)
        {
            _context.Remove(biblioteca);
            _context.SaveChanges();
        }
    }
}