using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class ProfesC : Persona, Interfaz
    {
        public string Departamento { get; set; }
        public int HorasTrabajo { get; set; }
        public int PrecioHora { get; set; }
        public ProfesC(string Apellidos, string Nombres, int CI, string Estado, string Departamento, int HorasTrabajo, int PrecioHora) : base(Apellidos, Nombres, CI, Estado)
        {
            this.Departamento = Departamento;
            this.HorasTrabajo = HorasTrabajo;
            this.PrecioHora = PrecioHora;
        }
        public void MostrarDatos()
        {
            Console.WriteLine("\nDATOS DEL PROFESOR CONTRATADO\n");
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
            Console.WriteLine("\nCAMBIAR ESTADO CIVIL\n");
            Console.WriteLine("Ingrese el nuevo estado civil: \n");
            nuevoEstado = Console.ReadLine();
            Estado = nuevoEstado;

            CambiarDespacho();
        }
        public void CambiarDespacho()
        {
            string nuevoDepartamento;
            Console.WriteLine("\nCAMBIAR A NUEVO DEPARTAMENTO\n");
            Console.WriteLine("Ingrese el nuevo departamento:\n ");
            nuevoDepartamento = Console.ReadLine();
            Departamento = nuevoDepartamento;
        }
        public void CalcularSueldo()
        {
            int sueldo;
            Console.WriteLine("\nHoras Trabajadas: " + HorasTrabajo);
            Console.WriteLine("Precio por Hora: \n" + PrecioHora);

            sueldo = HorasTrabajo * PrecioHora;
            Console.WriteLine("El sueldo del Profesor es de : " + sueldo + "$");
        }
        public void NuevosDatos()
        {
            Console.WriteLine("\nDATOS ACTUALIZDOS DEL PROFESROR CONTRATADO\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Departamento: " + Departamento + "\n");
            CalcularSueldo();
        }
    }
}
