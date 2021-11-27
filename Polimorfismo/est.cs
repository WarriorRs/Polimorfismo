using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class est : Persona, Interfaz
    {
        public int Curso { get; set; }
        public est(string Apellidos, string Nombres, int CI, string Estado, int Curso) : base(Apellidos, Nombres, CI, Estado)
        {
            this.Curso = Curso;
        }
        public void MostrarDatos()
        {

            Console.WriteLine("\nDATOS DEL ESTUDIANTE\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Curso: " + Curso + "\n");
            CambiarEstado();
        }
        public void CambiarEstado()
        {
            string nuevoEstado;
            Console.WriteLine("\nESTUDIANTE CAMBIAR ESTADO CIVIL\n");
            Console.WriteLine("Ingrese el nuevo estado civil: \n");
            nuevoEstado = Console.ReadLine();
            Estado = nuevoEstado;

            Matriculacion();
        }
        public void Matriculacion()
        {
            int nuevoCurso;
            Console.WriteLine("\nMATRICULACION A NUEVO CURSO\n");
            Console.WriteLine("Ingrese el nuevo curso a matricular:\n");
            nuevoCurso = int.Parse(Console.ReadLine());
            Curso = nuevoCurso;
        }
        public void NuevosDatos()
        {
            Console.WriteLine("\nDATOS ACTUALIZADOS DEL ESTUDIANTE\n");
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Curso: " + Curso + "\n");
        }
    }
}
