using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practica3
{
    class Principal
    {
        public static void Main(string[] args) 

        {

            creatabla tabla = new creatabla(); 
 
            tabla.capturar();
            Console.Clear();
            tabla.editar();
            Console.Clear();
            tabla.eliminar();
            Console.Clear();
            tabla.imprimirTodos();
        }
    }
}
