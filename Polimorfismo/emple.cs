using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class emple : Persona, Interfaz
    {
        public int AñoIncorporacion { get; set; }
        public int NumDespacho { get; set; }
        public emple(string Apellidos, string Nombres, int CI, string Estado, int AñoIncorporacion, int NumDespacho) : base(Apellidos, Nombres, CI, Estado)
        {
            this.AñoIncorporacion = AñoIncorporacion;
            this.NumDespacho = NumDespacho;
        }
        public void MostrarDatos()
        {

            Console.WriteLine("DATOS DEL EMPLEADO\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Año de Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Numero de Despacho: \n" + NumDespacho);

            CambiarEstado();
        }
        public void CambiarEstado()
        {
            string nuevoEstado;

            Console.WriteLine("\nEMPLEADO CAMBIAR ESTADO CIVIL\n");
            Console.WriteLine("Ingrese el nuevo estado civil: \n");
            nuevoEstado = Console.ReadLine();
            Estado = nuevoEstado;
            Reasignacion();
        }
        public void Reasignacion()
        {
            int nuevonumDespacho;
            Console.WriteLine("CAMBIO DEL NUMERO DE DESPACHO\n");
            Console.WriteLine("Ingrese el nuevo numero de despacho: \n");
            nuevonumDespacho = int.Parse(Console.ReadLine());
            NumDespacho = nuevonumDespacho;

        }
        public void NuevosDatos()
        {

            Console.WriteLine("\nDATOS ACTUALIZADOS DEL EMPLEADO\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Año de Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Numero de Despacho: " + NumDespacho + "\n");

        }
    }
}
