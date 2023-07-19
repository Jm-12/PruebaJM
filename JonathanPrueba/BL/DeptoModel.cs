using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JonathanPrueba.BL
{
    public class DeptoModel
    {
        public Int32 idDepto { get; set; }
        public String nombre { get; set; }
        public Int32 nEmpleados { get; set; }
        public String nivel { get; set; }
        //control
        public DateTime fechaRegistro { get; set; }
    }
}