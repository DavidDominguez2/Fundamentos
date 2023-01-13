using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form11TiendaProducto : Form
    {
        public Form11TiendaProducto()
        {
            InitializeComponent();
            this.lstShop.SelectionMode = SelectionMode.MultiExtended;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.lstShop.Items.Add(this.txtProduct.Text);
            this.txtProduct.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstShop.SelectedIndices.Count > 1)
            {
                int numSeleccionados = this.lstShop.SelectedIndices.Count;

                for (int i = numSeleccionados - 1; i >= 0; i--)
                {
                    int indice = this.lstShop.SelectedIndices[i];
                    this.lstShop.Items.RemoveAt(indice);
                }
            }
            else
            {
                this.lstShop.Items.RemoveAt(this.lstShop.SelectedIndex);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = this.lstShop.SelectedIndex;

            this.lstShop.Items.RemoveAt(index);
            this.lstShop.Items.Insert(index, this.txtProduct.Text.ToString());
            this.txtProduct.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lstShop.Items.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            foreach (string elem in this.lstShop.SelectedItems)
            {
                this.lstWarehouse.Items.Add(elem);
            }

            int numSeleccionados = this.lstShop.SelectedIndices.Count;

            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                int indice = this.lstShop.SelectedIndices[i];
                this.lstShop.Items.RemoveAt(indice);
            }

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstShop.Items.Count; i++)
            {
                this.lstWarehouse.Items.Add(lstShop.Items[i].ToString());
            }
            this.lstShop.Items.Clear();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.lstWarehouse.Items.Insert(this.lstWarehouse.SelectedIndex - 1, this.lstWarehouse.SelectedItem.ToString());
            this.lstWarehouse.Items.RemoveAt(this.lstWarehouse.SelectedIndex);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string elem = this.lstWarehouse.SelectedItem.ToString();
            int index = this.lstWarehouse.SelectedIndex;

            this.lstWarehouse.Items.RemoveAt(index);
            this.lstWarehouse.Items.Insert(index + 1, elem.ToString());

        }

        private void lstWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWarehouse.SelectedItems.Count == 0)
            {
                btnUp.Enabled = false;
                btnDown.Enabled = false;
            }

            if (lstWarehouse.SelectedIndex == 0)
            {
                btnUp.Enabled = false;
            }
            else
            {
                btnUp.Enabled = true;
            }

            if (lstWarehouse.SelectedIndex == lstWarehouse.Items.Count - 1)
            {
                btnDown.Enabled = false;
            }
            else
            {
                btnDown.Enabled = true;
            }
        }


    }
}
