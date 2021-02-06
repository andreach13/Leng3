using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");//cout
            
            int a = 1;
            int b = 2;
            int resultado = a + b;

            if (resultado > 0)
            {
                Console.WriteLine(resultado);
            }

            Console.ReadLine(); //cin
        }
    }
}
