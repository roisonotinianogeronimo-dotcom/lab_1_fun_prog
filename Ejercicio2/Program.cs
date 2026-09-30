using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];

            nombres[0] = "Luis Angel";
            nombres[1] = "Roinson Jhojan";
            nombres[2] = "Aron Muñoz";
            nombres[3] = "Franklin Condor";
            nombres[4] = "Juan Heras";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            // Modificación para el primer commit
        }
    }
}
