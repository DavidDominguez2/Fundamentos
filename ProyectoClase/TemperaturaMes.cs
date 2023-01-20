using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
    public class TemperaturaMes {
        #region PROPIEDADES
        public string Mes { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        #endregion

        #region CONSTRUCTOR
        public TemperaturaMes() { }
        public TemperaturaMes(int max, int min) {
            this.Max = max;
            this.Min = min;
        }
        #endregion

        #region METODOS
        public int MediaTemp() {
            return (this.Max + this.Min) / 2;
        }
        #endregion
    }
}
