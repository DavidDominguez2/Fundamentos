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
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnASCII_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <=255; i++)
            {
                char c = (char)i;
                if (char.IsLetter(c))
                {
                    this.txtLetras.Text += c;
                }else if (char.IsNumber(c))
                {
                    this.txtNumeros.Text += c;
                }else if (char.IsSymbol(c))
                {
                    this.txtSimbolos.Text += c;
                }else if (char.IsPunctuation(c))
                {
                    this.txtPuntuacion.Text += c;
                }
            }
        }
    }
}
