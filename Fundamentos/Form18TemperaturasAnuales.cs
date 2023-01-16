using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos {
    public partial class Form18TemperaturasAnuales : Form {
        ArrayList meses;
        List<int> numeros;
        public Form18TemperaturasAnuales() {
            InitializeComponent();
            meses = new ArrayList();
            meses.Add("ENERO");
            meses.Add("FEBRERO");
            meses.Add("MARZO");
            meses.Add("ABRIL");
            meses.Add("MAYO");
            meses.Add("JUNIO");
            meses.Add("JULIO");
            meses.Add("AGOSTO");
            meses.Add("SEPTIEMBRE");
            meses.Add("OCTUBRE");
            meses.Add("NOVIEMBRE");
            meses.Add("DICIEMBRE");
            numeros = new List<int>();
        }

        private void btnMonths_Click(object sender, EventArgs e) {
            this.numeros.Clear();
            this.lstMeses.Items.Clear();
            Random rd = new Random();

            for (int i = 0; i < this.meses.Count; i++) {
                int numero = rd.Next(-10, 50);
                this.numeros.Add(numero);
                this.lstMeses.Items.Add(this.meses[i] + " " + numero);
            }

        }

        private void btnShow_Click(object sender, EventArgs e) {
            int max = 0;
            int min = 0;
            double med = 0;

            for (int i = 0; i < this.numeros.Count; i++) {
                if (this.numeros[i] > max) {
                    max = this.numeros[i];
                }
                if (this.numeros[i] < min) {
                    min = this.numeros[i];
                }
                med += this.numeros[i];
            }
            med = med / 12;

            this.txtMax.Text = max.ToString();
            this.txtMax.ForeColor = Color.Red;

            this.txtMin.Text = min.ToString();
            this.txtMin.ForeColor = Color.Aquamarine;

            this.txtMed.Text = med.ToString();
            this.txtMed.ForeColor = Color.Green;

        }
    }
}
