using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Estudiante
    {
        private string _nombre;
        private string _apellido;
        private string _tutor;
        private string _genero;
        private DateTime _fechanac;

        public Estudiante(string nombre, string apellido, string tutor, string genero, DateTime fechanac)
        {
            _nombre = nombre;
            _apellido = apellido;
            _tutor = tutor;
            _genero = genero;
            _fechanac = fechanac;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Tutor { get => _tutor; set => _tutor = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime Fechanac { get => _fechanac; set => _fechanac = value; }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} {this.Genero} {this.Tutor} {this.Fechanac}";
        }
    }
}
