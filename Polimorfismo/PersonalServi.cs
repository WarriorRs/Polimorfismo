using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class PersonalServi : Persona, Interfaz
    {
        public string Seccion { get; set; }
        public PersonalServi(string Apellidos, string Nombres, int CI, string Estado, string Seccion) : base(Apellidos, Nombres, CI, Estado)
        {
            this.Seccion = Seccion;
        }
        public void MostrarDatos()
        {
            Console.WriteLine("\nPersonal de Servicio\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Seccion: " + Seccion);
            CambiarEstado();
        }
        public void CambiarEstado()
        {
            string nuevoEstado;
            Console.WriteLine("\nPERSONAL DE SERVICIO CAMBIAR ESTADO CIVIL\n");
            Console.WriteLine("Ingrese el nuevo estado civil: ");
            nuevoEstado = Console.ReadLine();
            Estado = nuevoEstado;
            Traslado();
        }
        public void Traslado()
        {
            string nuevaSeccion;
            Console.WriteLine("\nTRASLADO A NUEVA SECCION\n");
            Console.WriteLine("Ingrese la nueva seccion: ");
            nuevaSeccion = Console.ReadLine();
            Seccion = nuevaSeccion;
        }
        public void NuevosDatos()
        {
            Console.WriteLine("\nDATOS ACTUALIZADOS DEL PERSONAL DE SERVICIO\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Seccion: " + Seccion);
        }
    }
}
