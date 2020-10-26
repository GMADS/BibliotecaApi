using System.Collections.Generic;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Domain.Repositories
{
    public interface IBibliotecaRepository
    {
        //Métodos que nossa class terá que implementar.
        void Adicionar(Livros biblioteca);
        void Alterar(Livros biblioteca);
        IEnumerable<Livros> ListarBibliotecas();
        Livros ObterPorId(int id);
        void RemoverBiblioteca(Livros biblioteca);
    }
}