using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Persona
    {
        private string nombre;
        private int edad;
        private int cedula;

        public string Nombre { get => nombre;}
        public int Edad { get => edad; }
        public int Cedula { get => cedula; }

        //Constructor
        

        public Persona(string nombre, int edad, int cedula)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.cedula = cedula;
        }

        public string MostrarPersona()
        {
            string persona = "Nombre: " + nombre + " Cedula: " + cedula +  " Edad: " + edad;
            return persona;
        }
    }
}
