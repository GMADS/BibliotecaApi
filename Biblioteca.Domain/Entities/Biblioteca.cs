namespace Biblioteca.Domain.Entities
{
    public class Livros
    {
        public int Id { get; set; }
        public string NomeDoLivro { get; set; }
        public string NomeDoAutor { get; set; }
        public int NumeroDePaginas { get; set; }
    }
}