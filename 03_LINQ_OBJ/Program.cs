using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario() { Nome = "Jose", Email = "jose@gmail.com" });
            lista.Add(new Usuario() { Nome = "João", Email = "joao@hotmail.com" });
            lista.Add(new Usuario() { Nome = "Maria", Email = "maria@ig.com" });
            lista.Add(new Usuario() { Nome = "Pedro", Email = "pedro@gmail.com" });
            lista.Add(new Usuario() { Nome = "Heber", Email = "heber@gmail.com" });

            var listaFiltrada = lista.Where(a => a.Email.Contains("gmail")).Select(a => a);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine("Nome: {0} - Email: {1}", item.Nome, item.Email);
            }

            Console.ReadKey();
        }
    }
}
