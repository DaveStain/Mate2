using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mate2.Models
{
    public class Equipo
    {
        public string EquipoId { get; set; }
        public int EscuelaId { get; set; }
        public string Contrasena { get; set; }
        public int Mesa { get; set; }
        public int Clave { get; set; }
        public int Usuario { get; set; }
    }
}