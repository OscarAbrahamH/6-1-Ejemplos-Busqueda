using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_Busqueda_Secuencial
{
    class Busqueda
    {
        public bool MetodoBusqueda(int Elemento, List<int> Lista) //Se crea el metodo para la busqueda
        {
            int ValorLista = Lista.Count; //Dato de la lista, esta variable abarca todos los datos que estan en la lista
            int Posicion = 0; 

            while (Posicion < ValorLista) //Hace comparacion de si esta en la lista
            {
                if (Lista[Posicion] == Elemento) //se de que si esta
                {
                    Console.WriteLine("-----> Se encuentra en la lista"); //Se imprime un mensaje de que esta en ella
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Posicion++; 
                    
                }
            }
            Console.WriteLine("-----> No esta en la lista"); //Se imprime mensaje de que no esta en la lista
            Console.ReadKey();
            return false;
        }
    }
}
