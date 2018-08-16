using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Telefono de Casa: " + contacto1.TelefonoCasa);
            Console.ReadLine();

            Contacto contacto2 = new Contacto("Ricky felix");
            Console.WriteLine("contacto 2");
            Console.WriteLine("Nombre: " + contacto2.Nombre);

            Contacto contacto3 = new Contacto("Maria Nav", "1234567890", "9876543210", "5 de febrero 895", "maria@correo.com");
            Console.WriteLine("Contacto 3");
            Console.WriteLine("Nombre: " + contacto3.Nombre);
            Console.WriteLine("Celular: " + contacto3.TelefonoCelular);
            Console.WriteLine("Casa: " + contacto3.TelefonoCasa);
            Console.WriteLine("Direccion: " + contacto3.Direccion);
            Console.WriteLine("Correo: " + contacto3.CorreoElectronico);

            Console.ReadLine();
        }
    }
}