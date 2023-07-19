using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JonathanPrueba.BL
{
    public class EmpresaModel
    {
        //[Key]
        public Int32 id { get; set; }
        public String nombre { get; set; }
        public String razonS { get; set; }
        public String bitacora { get; set; }
        //control
        public DateTime fechaRegistro { get; set; }
    }
}
