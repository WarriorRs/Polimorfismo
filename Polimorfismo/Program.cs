using System.Collections.Generic;
using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                est estudiante = new est("Anchundia Cholango", "Sergio David", 1725751505, "Soltero", 1);

                ProfesC contrato = new ProfesC("Cesar Adolfo", "Anchundia Santana", 1302802275, "Casado", "Ecuaciones Diferenciales", 10, 20);

                ProfesNom nombramiento = new ProfesNom("Anchundia Cholango", "Julio Cesar", 1720156307, "Casado", "Sistemas Digitales", 1111, 22);

                emple empleado = new emple("Perez Morales", "Jose Andres", 1302689670, "Solero", 2021, 1010);

                PersonalServi servicio = new PersonalServi("Anchundia Anchundia", "Nixon Santiago", 1353671205, "Soltero", "Matematicas");

                List<Persona> ListaPersonas = new List<Persona>();
                ListaPersonas.Add(estudiante);
                ListaPersonas.Add(contrato);
                ListaPersonas.Add(nombramiento);
                ListaPersonas.Add(empleado);
                ListaPersonas.Add(servicio);

                foreach (Interfaz i in ListaPersonas)
                {
                    i.MostrarDatos();
                    i.NuevosDatos();
                }
            }
        }
    }
}
