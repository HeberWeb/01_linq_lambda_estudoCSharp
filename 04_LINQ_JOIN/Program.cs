using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAutor = new List<Autor>();
            listaAutor.Add(new Autor() { Id = 1, Nome = "José" });
            listaAutor.Add(new Autor() { Id = 2, Nome = "Maria" });
            listaAutor.Add(new Autor() { Id = 3, Nome = "João" });

            var listaLivros = new List<Livro>();
            listaLivros.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "História sem Fim"});
            listaLivros.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Código Mestre"});
            listaLivros.Add(new Livro() { Id = 3, AutorId = 1, Titulo = "Cubo Mágico"});
            listaLivros.Add(new Livro() { Id = 4, AutorId = 3, Titulo = "Terror no oceano"});

            var listaJoin = (from
                            livros in listaLivros
                            join autor in listaAutor on livros.AutorId equals autor.Id
                            select new { livros, autor })
                            .ToList();

            foreach (var item in listaJoin)
            {
                Console.WriteLine("Livro: {0} - Autor: {1}", item.livros.Titulo, item.autor.Nome);
            }

            Console.ReadKey();
        }
    }
}
