using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class DatosAlumno
    {
        //public List<int> Numeros { get; set; }
        //public List<string> Nombres { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public DatosAlumno()
        {
            //Numeros = new List<int>();
            // Numeros.Add(10);
            //Numeros.Add(5);

            //Nombres = new List<string>();
            //Nombres.Add("Juan");
            //Nombres.Add("Maria");

            //Alumno a = new Alumno();
            //a.Nombre = "Juan";
            //Alumno b = new Alumno();
            //b.Nombre = "Maria";

            Alumnos = new List<Alumno>();
            //Alumnos.Add(a);
            //Alumnos.Add(b);
        }

        public void Agregar(Alumno nuevoAlumno)
        {
            Alumnos.Add(nuevoAlumno);
        }

        //Alumnos.Sort -- ordenar
        //Alumnos.Count -- contar
        //Alumnos.Find -- encontrar
    }
}
