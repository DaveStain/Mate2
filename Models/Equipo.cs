using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mate2.Models
{
    public class Equipo
    {
        public string EquipoID { get; set; }
        public int EscuelaID { get; set; }
        public int Usuario { get; set; }
        public string Contrasena { get; set; }
        public int Mesa { get; set; }
        public int Clave { get; set; }
        public string Integrante1 { get; set; }
        public string Integrante2 { get; set; }
        public string Integrante3 { get; set; }
        public int Puntos { get; set; }

    }
}