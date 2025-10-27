using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_1_POO
{
    public class Libro
    {
        public string _titulo { get; set; }

        public string _autor { get; set;}

        private double _noPaginas { get; set; }

        public Libro(string titulo, string autor, double noPaginas)
        {
            _titulo = titulo;
            _autor = autor;
            _noPaginas = noPaginas;
        }
    
        protected void MostrarInfo()
        {
            Console.WriteLine($"\n Titulo: {_titulo} \n Autor: {_autor} \n N° Páginas: {_noPaginas}");
        }
        private void ActualizarPaginas()
        {
            Console.WriteLine($"Ingrese el nuevo número de páginas del libro {_titulo}:");
            double nuevoNoPaginas = double.Parse(Console.ReadLine());
            _noPaginas = nuevoNoPaginas;

        }
        public void ActualizarPub()
        {
            ActualizarPaginas();
        }
      
    }
    public class LibroDigital : Libro
    {
        public LibroDigital(string titulo, string autor, double noPaginas) : base(titulo, autor, noPaginas) 
        { 

        }
        public void Resumen()
        {
            MostrarInfo();
        }
      
    }
}
