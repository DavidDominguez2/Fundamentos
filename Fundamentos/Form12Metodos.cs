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
    public partial class Form12Metodos : Form {
        public Form12Metodos() {
            InitializeComponent();
        }

        private void btnDouble_Click(object sender, EventArgs e) {
            int num = int.Parse(this.txtNum.Text);
            this.GetDoble(num);
            //DIBUJAMOS EL RESULTADO
            this.lblResultado.Text = num.ToString();
        }

        void GetDoble(int numero) {
            //CAMBIAMOS EL PARAMETRO DEL PARAMETRO WRAPPER RECIBIDO
            numero = numero * 2;
        }

        private void btnRef_Click(object sender, EventArgs e) {

        }
    }
}
