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
    public partial class Form08ColeccionGrafica : Form {
        public Form08ColeccionGrafica() {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            string elem = this.txtElement.Text;
            this.lstElements.Items.Add(elem);
            this.txtElement.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            //NECESITAMOS RECUPERAR EL OBJETO SELECCIONADO DEL
            //CONTROL LISTBOX
            //string select = this.lstElements.SelectedItem.ToString();
            //this.lstElements.Items.Remove(select);
            int indice = this.lstElements.SelectedIndex;
            this.lstElements.Items.RemoveAt(indice);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e) {
            this.lstElements.Items.Clear();
        }

        private void lstElements_SelectedIndexChanged(object sender, EventArgs e) {

            if (this.lstElements.SelectedIndex != -1) {
                this.lblIndice.Text = this.lstElements.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElements.SelectedItem.ToString();
            }

        }
    }
}
