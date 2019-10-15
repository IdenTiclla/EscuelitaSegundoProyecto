using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Materia
    {
        private string nombre;
        private string turno;

        public Materia(string nombre, string turno)
        {

            this.nombre = nombre;
            this.turno = turno;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Turno { get => turno; set => turno = value; }

        public override string ToString()
        {
            return $"{Nombre} {turno}";
        }
    }
}
