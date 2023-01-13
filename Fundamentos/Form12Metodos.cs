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
            int num = int.Parse(this.txtNum.Text);
            //this.GetDobleRef(ref num);
            ////DIBUJAMOS EL RESULTADO
            //this.lblResultado.Text = num.ToString();

            int resultado = this.GetDobleNumero(num);
            this.lblResultado.Text = resultado.ToString();
        }

        int GetDobleNumero(int numero) {
            int doble = numero * 2;
            return doble;
        }

        void GetDobleRef(ref int numero) {
            //CAMBIAMOS EL VALOR DE LA VARIABLE RECIBIDA
            numero = numero * 2;
        }

        private void btnObjectRef_Click(object sender, EventArgs e) {
            this.CambiarColor(this.btnRef);
            this.CambiarColor(this.btnDouble);
        }

        void CambiarColor(Button btn) {
            //CAMBIAMOS ALGO DEL OBJETO
            btn.BackColor = Color.Red;
        }

        private void Form12Metodos_Load(object sender, EventArgs e) {

        }

        private void Form12Metodos_FormClosed(object sender, FormClosedEventArgs e) {


        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e) {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e) {
            //LA TECLA PULSADA
            //e.KeyChar;
            //DESACTIVA LAS ACCIONES POSTERIORES AL EVENTO
            //e.Handled = true;

            //DEBEMOS INDICAR QUE SI ES LA TECLA DE BORRAR,
            //TAMBIEN ESTE HABILITADO EL EVENTO
            //char teclaBorrar = (char)8;
            //EXISTE UNA ENUMERACION QUE NOS DEVUELVE
            //EL CODIGO DE CADA TECLA
            char teclaBorrar = (char)Keys.Back;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != teclaBorrar) {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e) {
            char teclaBorrar = (char)Keys.Back;
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != teclaBorrar) {
                e.Handled = true;
            }
        }


    }
}
