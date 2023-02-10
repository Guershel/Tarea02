using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosyProcedimientos
{
    internal class Program
    {
                                   //variables globales
        static string[] nombre = new string[3]; //variable global
        static float[] notas = new float[3];    //notas
        static byte indice = 0;                        //variable global para la pisicion del arreglo
        static void Main(string[] args)
        {

            Estudiante.menu();
            
            Console.Read();

        }
        

        }
    
}
