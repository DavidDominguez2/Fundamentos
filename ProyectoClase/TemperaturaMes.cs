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
        public TemperaturaMes(string Mes) {
            this.Mes = Mes;
            this.Max = new Random().Next(-20, 50);
            this.Min = new Random().Next(-20, 50);
        }
        #endregion

        #region METODOS
        public int MediaTemp(int max, int min) {
            int media = (max + min) / 2;
            return media;
        }
        #endregion
    }
}
