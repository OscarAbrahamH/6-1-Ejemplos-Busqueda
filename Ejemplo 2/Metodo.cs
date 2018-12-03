using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    class Metodo
    {
        public void Proceso()
        {
            int n; // Tamaño del vector
            int Numero; //numero a buscar
            string Ubicacion = "";
            string linea;

            Console.WriteLine("Ingrese el numero de elementos: ");
            n = int.Parse(Console.ReadLine()); //Ingresar tamaño del vector
            int[] Vector = new int[n]; //Se guarda el valor introducido en el vector

            for (int i = 0; i < n; i++) //Se ingresar valores 
            {

                Console.WriteLine("Ingrese elemento #{0}: ", i + 1); 
                linea = Console.ReadLine();
                Vector[i] = int.Parse(linea);//Se guardan valores
                Console.WriteLine("----------------------------");

            }
            Console.WriteLine("VECTOR");
            for (int i = 0; i < Vector.Length; i++) //Imprimir el vector
            {

                Console.WriteLine("{0} ", Vector[i]);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ingrese elemento que desea buscar en el arreglo: ");
            Numero = int.Parse(Console.ReadLine()); //Aqui se realiza la busqueda del numero

            for (int i = 0; i < n; i++) //Proceso por el cual se determina la posicion del numero
            {

                if (Vector[i] == Numero)
                {
                    i = i + 1; //Se aumenta el valor con un +1 para asigne la posicion exacta

                    Ubicacion = Ubicacion + ' ' + i; 
                }
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("El elemento se encuentra en la posicion:{0}", Ubicacion); //Imprime la ubicacion del valor
            Console.ReadLine();
        }

    }
}
