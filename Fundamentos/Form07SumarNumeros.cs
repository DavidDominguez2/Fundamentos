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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
            this.lblSum.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int result = 0;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                char c = textoNumeros[i];
                result += int.Parse(c.ToString());
            }

            this.lblSum.Text = "La suma es: " + result.ToString();
        }
    }
}
