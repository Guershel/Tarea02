using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosyProcedimientos
{
    internal class Estudiante
    {
        static string[] nombre = new string[3]; //variable global
        static float[] notas = new float[3];    //notas
        static byte indice = 0;                        //variable global para la pisicion del arreglo

        private static void CrearEstudiantes()
        {

            string continuar = "s";

            do
            {
                Console.WriteLine("Digite el nombre del estudiante ({0}):", (indice + 1));
                nombre[indice] = Console.ReadLine();
                indice++;
                Console.WriteLine("Desea continuar(s/n): ");
                continuar = Console.ReadLine();

            } while (!continuar.Equals("n"));

            /*! =  negacion
             * = asignacion
             * ==comparacion
             * > mayor que 
             * < menor que 
             * >= mayor o igual que
             * <= menor o igual que 
             * + suma o concatenacion
             * - resta 
             *  / division
             *  * multiplicacion
             *  % residuo
             *  => lambda
             
             */
        }
        private static void Imprimir()
        {
            String contenido = " ";
            for (int i = 0; i < nombre.Length; i++)
            {
                contenido+= "Nombre del estudiante: "+ nombre[i] +" Nota: "+notas[i]+ "\n";
            }

            Console.WriteLine(contenido);

        }
        private static void BuscarEstudiante()
        {
            Console.WriteLine("Digite el nombre del estudiante:");
            String nombre = Console.ReadLine();
            bool existe = false;
            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Estudiante Existe");
                    existe = true;
                }
            }
            if (existe == false)
            {
                Console.WriteLine("Estudiante no existe");
            }
        }
        private static void AgragarNota()
        {
            Console.WriteLine("Digite el nombre del estudiante al cual desea agregar nota:");
            String nombre = Console.ReadLine();
            bool existe = false;
            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Digite la nota del Estudiante");
                    String nota = Console.ReadLine();
                      notas[i] = float.Parse(nota);
                    Console.WriteLine("Nota guardada");

                    existe = true;
                }
            }
            if (existe == false)
            {
                Console.WriteLine("Estudiante no existe");
            }
        }
        public static void menu()
        {

            byte opcion = 0;

            do
            {
                Console.WriteLine("1 - Agregar estudiante");
                Console.WriteLine("2 - Buscar estudiante");
                Console.WriteLine("3 -  Asignar nota al estudiante");
                Console.WriteLine("4 - Imprimir estudiantes");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEstudiantes();
                        break;

                    case 2:
                        BuscarEstudiante();
                        break;  
                    case 3:
                        AgragarNota();
                        break;
                    case 4:
                        Imprimir();
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;

                }
            } while (opcion != 5); //true
        }
    }
}
