using System;

namespace laboratorio01
{
    public class Persona
    {
        public string Nombre;
        public string Apellido;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public int Lanzar()
        {
            int randomInt = new Random().Next(0, 3);
            return randomInt;
        } 
    }
}
