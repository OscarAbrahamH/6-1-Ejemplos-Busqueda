using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_1_Busqueda_Secuencial;

namespace _6_1_Busqueda_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> Lista = new List<int>(); //Se crea la lista 
            //Asiganar valores que estaran en la lista (Estos valores son los disponibles por buscar)
            Lista.Add(1);
            Lista.Add(2);
            Lista.Add(3);
            Lista.Add(4);
            Lista.Add(5);
            Lista.Add(6);
            Lista.Add(7);
            Lista.Add(8);
            Lista.Add(9);
            Lista.Add(10);
            Lista.Add(111);
            Lista.Add(112);
            Lista.Add(113);
            Lista.Add(21);
            Lista.Add(1000);
            Lista.Add(200);
            Lista.Add(900);
            Lista.Add(1000000);

            int n; //Variable que determinara el valor a buscar
            Console.Write("Ingrese el valor a buscar: "); 
            n = int.Parse(Console.ReadLine()); //Ingresar valor
            Console.WriteLine("\n");
            Console.WriteLine("Numero: " + n); //Se imprime el numero ingresado con la variable "n"

            Busqueda figura1 = new Busqueda(); //Se declara el objeto
            Console.WriteLine(figura1.MetodoBusqueda(n, Lista)); //Muestra en pantalla si el valor esta en lista o no esta en la lista
            Console.ReadKey();
        }
    }
}
