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
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
            this.lblMessage.Text = "";
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text.ToLower().Trim();
         


            if (email.IndexOf("@") == -1)
            {
                this.lblMessage.Text = "Debe añadir un @";
            }else if(email.StartsWith("@") || email.EndsWith("@"))
            {
                this.lblMessage.Text = "No se puede comenzar o terminar con un @";
            }else if (email.Split("@").Length >2)
            {
                this.lblMessage.Text = "Hay más de un @ en su email";
            }else if (!email.Contains("."))
            {
                this.lblMessage.Text = "Debe añadir un .";
            }else if (!email.Substring(email.IndexOf("@")).Contains("."))
            {
                this.lblMessage.Text = "Debe añadir un . despues de la @";
            }else if (email.Substring(email.LastIndexOf(".")).Length > 5 || email.Substring(email.LastIndexOf(".")).Length < 3)
            {
                this.lblMessage.Text = "Dominio no valido (.net,.com,.es...)";
            }
            else
            {
                this.lblMessage.Text = "Su dirección de correo: " + email +  " es correcta";
            }


        }
    }
}
