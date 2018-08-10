using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Objetos
{
    class Persona
    {
        //modificadores de acceso
        //public y private


        // Atributos
        // Definidos a través de variables
        public string nombre;
        public string apellidos;
        public string fechaNacimiento;
        public int edad;
        public float altura;

        // Métodos
        // Definidos a través de funciones
        ///edad = edad + 1 == edad += 1
        public void cumplirAños()
        {
            edad += 1;
        }

        public void crecer(float cantidadCrecimiento)
        {
            altura += cantidadCrecimiento;
        }

    }
}