using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Persona
    {
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public int CI { get; set; }
        public string Estado { get; set; }
        public Persona(string Apellidos, string Nombres, int CI, string Estado)
        {
            this.Apellidos = Apellidos;
            this.Nombres = Nombres;
            this.CI = CI;
            this.Estado = Estado;
        }
    }
}
