using System;
using System.Collections.Generic;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<Persona> listaPersonas = new List<Persona>();

            for (int i = 0; i < 1 ; i++)
            {
                Console.WriteLine("Ingrese nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese cedula");
                int cedula = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese edad");
                int edad = int.Parse(Console.ReadLine());
                Persona p = new Persona(nombre, edad, cedula);
                listaPersonas.Add(p);

            }

            for (int i = 0; i < listaPersonas.Count; i++)
            {
                Console.WriteLine(listaPersonas[i].MostrarPersona());
            }
            
            
           


            
          


        }
    }
}
