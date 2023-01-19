using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
    public class Direccion {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        //CONSTRUCTOR VACIO
        public Direccion() {
            Debug.WriteLine("Constructor sin parámetros");
        }

        //VARIAS FORMAS DE CREAR UN OBJETO
        public Direccion(string calle, string ciudad) {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor con dos parametros");
        }

        public Direccion(string calle, string ciudad, int codigoPostal) {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = codigoPostal;
            Debug.WriteLine("Constructor con tres parametros");
        }
    }
}
