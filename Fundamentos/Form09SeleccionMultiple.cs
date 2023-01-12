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
    public partial class Form09SeleccionMultiple : Form {
        public Form09SeleccionMultiple() {
            InitializeComponent();
            this.lstElements.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            string ele = this.txtElement.Text;
            this.lstElements.Items.Add(ele);

            this.txtElement.Focus();
            this.txtElement.SelectAll();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            //NO PODEMOS ELIMINAR ELEMENTOS UTILIZANDO UN BUCLE REFERENCIA
            //DEBEMOS RECORRER TODOS LOS ELEMENTOS SELECCIONADOS
            //NOS INTERESA EL INDEX DE CADA ELEMENTO
            //NUMERO DE ELEMENTOS SELECCIONADOS
            int numSeleccionados = this.lstElements.SelectedIndices.Count;
            //RECORREMOS TODOS LOS INDICES SELECCIONADOS
            for (int i = numSeleccionados - 1; i >= 0; i--) {
                //RECUPERAMOS EL INDICE SELECCIONADO
                int indice = this.lstElements.SelectedIndices[i];
                //POR ULTIMO ELIMINAMOS EL ELEMENTO POR SU INDICE
                this.lstElements.Items.RemoveAt(indice);
            }

        }

        private void btnSelecteds_Click(object sender, EventArgs e) {
            //COMO SOLAMENTE VAMOS A DIBUJAR, PODEMOS UTILIZAR
            //BUCLES DE REFERENCIA
            string indices = "";
            foreach (int indice in this.lstElements.SelectedIndices) {
                indices += indice + ",";
            }
            this.lblIndice.Text = indices.Trim(',');
            string items = "";
            foreach (string elem in this.lstElements.SelectedItems) {
                items += elem + ",";
            }
            this.lblItem.Text = items;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e) {
            this.lstElements.Items.Clear();
        }
    }
}
