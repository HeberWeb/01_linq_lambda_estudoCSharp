﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ E LAMBDA
            //LAMBDA (entrada) => (expressao)
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            var listaFiltrada = lista.Where(x => x > 10).Select(d => d);
            var listaOrdenada = listaFiltrada.OrderBy(d => d);

            Console.WriteLine("Lista filtrada");
            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista Ordenada");
            foreach (var item in listaOrdenada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
