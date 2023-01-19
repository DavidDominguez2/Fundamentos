using ProyectoClase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos {
    public partial class Form19TemperaturasClases : Form {
        List<TemperaturaMes> tempMeses;
        public Form19TemperaturasClases() {
            InitializeComponent();
            tempMeses = new List<TemperaturaMes>();
            tempMeses.Add(new TemperaturaMes("Enero"));
            tempMeses.Add(new TemperaturaMes("Febrero"));
            tempMeses.Add(new TemperaturaMes("Marzo"));
            tempMeses.Add(new TemperaturaMes("Abril"));
            tempMeses.Add(new TemperaturaMes("Mayo"));
            tempMeses.Add(new TemperaturaMes("Junio"));
            tempMeses.Add(new TemperaturaMes("Julio"));
            tempMeses.Add(new TemperaturaMes("Agosto"));
            tempMeses.Add(new TemperaturaMes("Septiembre"));
            tempMeses.Add(new TemperaturaMes("Octubre"));
            tempMeses.Add(new TemperaturaMes("Noviembre"));
            tempMeses.Add(new TemperaturaMes("Diciembre"));
        }

        private void btnMonths_Click(object sender, EventArgs e) {
            foreach (TemperaturaMes mes in tempMeses) {
                this.lstMeses.Items.Add(mes.Mes);
            }
            this.tempMeses.Clear();
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e) {
            int index = this.lstMeses.SelectedIndex;
            this.txtMax.Text = this.tempMeses[0].ToString();
        }
    }
}
