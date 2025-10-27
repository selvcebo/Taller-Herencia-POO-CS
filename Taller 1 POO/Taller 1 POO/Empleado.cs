using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Taller_1_POO
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        private double Salario { get; set; }

        public Empleado(string nombre, string cargo, double salario)
        {
            Nombre = nombre;
            Cargo = cargo;
            Salario = salario;
        }

        
        protected double ObtenerSalario()
        {
            return Salario;
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"\n Nombre: {Nombre} \n Cargo: {Cargo} \n Salario: {Salario}$");   
        }
        private void ModificarSalario()
        {
            Console.WriteLine($"Ingrese el nuevo salario de {Nombre}");
            double nuevoSalario = double.Parse(Console.ReadLine());
            Salario = nuevoSalario;
        }
        public void ModificarSalarioPub()
        {
            ModificarSalario();
        }
    }

    public class Gerente : Empleado
    {
        public Gerente(string nombre, string cargo, double salario)
            : base(nombre, cargo, salario)
        {
        }

        
        public void ConsultarSalario()
        {
            Console.WriteLine("Ingrese el bono del empleado:");
            double bono = double.Parse(Console.ReadLine());
            double salario = ObtenerSalario();
            double salarioBono = salario + bono;
            Console.WriteLine($"El salario del empleado es: {salarioBono}$");
        }
    }
}


