using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mate2.Models
{
    public class RespuestasEquipo
    {
        public Pregunta Pregunta { get; set; }
        public int PreguntaID { get; set; }
        public int EquipoID { get; set; }
        public char Respuesta { get; set; }
        public bool Penalizada { get; set; }
    }
}