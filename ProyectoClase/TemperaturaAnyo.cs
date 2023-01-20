using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
    public class TemperaturaAnyo {
        #region PROPIEDADES
        public int Anyo { get; set; }
        public List<TemperaturaMes> Meses { get; set; }
        public int MaxAnual { get; set; }
        public int MinAnual { get; set; }
        #endregion

        #region CONSTRUCTOR
        public TemperaturaAnyo() { }
        #endregion

        #region METODOS
        public int MediaAnual() {
            return (this.MaxAnual + this.MinAnual) / 2;
        }
        #endregion

    }
}
