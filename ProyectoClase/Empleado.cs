using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
    public class Empleado : Persona {
        protected int SalarioMinimo { get; set; }

        public Empleado() {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1500;
        }
        public Empleado(string nombre, string apellidos) : base(nombre, apellidos) {
            Debug.WriteLine("Constructor EMPLEADO dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        public int GetSalarioMinimo() {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVacaciones() {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
    }
}
