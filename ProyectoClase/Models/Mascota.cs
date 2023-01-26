using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase.Models {

    public class Mascota {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Years { get; set; }
        public byte[] Imagen { get; set; }
    }

}
