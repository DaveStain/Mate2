using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mate2.Models
{
    public class Pregunta
    {
        public int PreguntaID { get; set; }
        public string Descripcion { get; set; }
        public char Respuesta { get; set; }
    }
}