using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
    public class Director : Empleado {
        public Director() {
            this.SalarioMinimo += 200;
        }

        //OVERRIDE
        public override int GetDiasVacaciones() {
            return base.GetDiasVacaciones() + 8;
        }

        public override string ToString() {
            return this.GetNombreCompleto() + " , Salario: " + this.SalarioMinimo + ", Vacaciones: " + this.GetDiasVacaciones();
        }
    }
}
