using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Curso
    {
        private int nro;
        private int capacidad;
        private int cantidad_estudiantes;
        private Profesor profesor;
        private Materia materia;
        private LinkedList<Estudiante> estudiantes;

        public Curso(int nro)
        {
            this.nro = nro;
            capacidad = 30;
            estudiantes = new LinkedList<Estudiante>();
        }

        public int Nro { get => nro; set => nro = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Cantidad_estudiantes { get => cantidad_estudiantes; set => cantidad_estudiantes = value; }
        internal LinkedList<Estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }
        internal Profesor Profesor { get => profesor; set => profesor = value; }
        internal Materia Materia { get => materia; set => materia = value; }
    }
}
