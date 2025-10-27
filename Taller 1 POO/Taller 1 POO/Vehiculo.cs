using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_1_POO
{
    public class Vehiculo
    {
        public string _marca { get; set; }
        public string _modelo { get; set; }
        private double _kilometraje { get; set; }

        public Vehiculo(string marca, string modelo, double kilometraje)
        {
            _marca = marca;
            _modelo = modelo;
            _kilometraje = kilometraje;
        }

        protected void costoMantenimiento()
        {
            Console.WriteLine("Ingrese el costo por kilometro:");
            double costo = double.Parse(Console.ReadLine());
            double costoKilometraje = costo * _kilometraje;
            Console.WriteLine($"El costo de mantenimiento con el kilometraje actual es de {costoKilometraje}$");
        }


    }
    public class Camion : Vehiculo
    {
        public Camion(string marca, string modelo, double kilometraje)
           : base(marca, modelo, kilometraje)
        {
        }

        public void costoMantenimientoPub()
        {
            costoMantenimiento();
        }
    }

}
