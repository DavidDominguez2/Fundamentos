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
    public partial class Form10ColeccionNumeros : Form {
        public Form10ColeccionNumeros() {
            InitializeComponent();
            this.lstNumbers.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            Random random = new Random();

            for (int i = 0; i < 5; i++) {
                int valor = random.Next(1, 100);
                this.lstNumbers.Items.Add(valor);
            }
        }

        private void btnShow_Click(object sender, EventArgs e) {
            int sum = 0;
            int sumPar = 0;
            int sumImpar = 0;

            foreach (int num in this.lstNumbers.Items) {
                sum += num;
                if (num % 2 == 0) { //PAR
                    sumPar += num;
                } else { //IMPAR
                    sumImpar += num;
                }
            }

            int sumSelected = 0;

            if (this.lstNumbers.SelectedIndices.Count == 0) {
                this.txtNumSelecteds.Text = 0 + "";
            } else {
                foreach (int elem in this.lstNumbers.SelectedItems) {
                    sumSelected += elem;
                }
                this.txtNumSelecteds.Text = sumSelected.ToString();
            }

            this.txtSum.Text = sum.ToString();
            this.txtPar.Text = sumPar.ToString();
            this.txtImpar.Text = sumImpar.ToString();
        }
    }
}
