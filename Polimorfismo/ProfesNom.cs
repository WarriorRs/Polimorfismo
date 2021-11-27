using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class ProfesNom : Persona, Interfaz
    {
        public string Departamento { get; set; }
        public int SueldoFMensual { get; set; }
        public int HorasExtra { get; set; }
        public ProfesNom(string Apellidos, string Nombres, int CI, string Estado, string Departamento, int SueldoFMesual, int HorasExtra) : base(Apellidos, Nombres, CI, Estado)
        {
            this.Departamento = Departamento;
            this.SueldoFMensual = SueldoFMesual;
            this.HorasExtra = HorasExtra;
        }
        public void MostrarDatos()
        {

            Console.WriteLine("\nDATOS DEL PROFESOR NOMBRAMIENTO\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Departamento: " + Departamento + "\n");

            CambiarEstado();
        }
        public void CambiarEstado()
        {
            string nuevoEstado;
            Console.WriteLine(" CAMBIAR ESTADO CIVIL\n");
            Console.WriteLine("Ingrese el nuevo estado civil: ");
            nuevoEstado = Console.ReadLine();
            Estado = nuevoEstado;
            CambiarDespacho();
        }
        public void CambiarDespacho()
        {
            string nuevoDepartamento;

            Console.WriteLine("\nCAMBIAR A NUEVO DEPARTAMENTO\n");
            Console.WriteLine("Ingrese el nuevo departamento: ");
            nuevoDepartamento = Console.ReadLine();
            Departamento = nuevoDepartamento;
        }
        public void CalcularSueldo()
        {
            int sueldo;
            Console.WriteLine("\nSueldo Fijo Mensual: \n" + SueldoFMensual);
            Console.WriteLine("Hora extras trabajadas: " + HorasExtra);
            sueldo = SueldoFMensual + (HorasExtra * 15);
            Console.WriteLine("\nEl sueldo del Profesor es de : " + sueldo + "$\n");
        }
        public void NuevosDatos()
        {
            Console.WriteLine("\nDATOS ACTUALIZADOS DEL PROFESOR DE NOMBRAMIENTO\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Departamento: " + Departamento);
            CalcularSueldo();
        }
    }
}
