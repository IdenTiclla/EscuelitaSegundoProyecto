using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Profesor
    {
        private string _nombre;
        private string _apellido;
        private double _sueldo;
        private int _edad;


        public Profesor(string nombre, string apellido, double sueldo, int edad)
        {
            _nombre = nombre;
            _apellido = apellido;
            _sueldo = sueldo;
            _edad = edad;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }
        public int Edad { get => _edad; set => _edad = value; }


        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} {this.Sueldo}";
        }
    }
}
