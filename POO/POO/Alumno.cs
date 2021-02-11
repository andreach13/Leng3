using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Direccion Direccion { get; set; }

        public Alumno()
        {
            Direccion = new Direccion();
        }
    }
}
