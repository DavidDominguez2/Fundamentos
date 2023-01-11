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
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
            this.txtPositionX.Text = this.txtPositionX.Location.X.ToString();
            this.txtPositionY.Text = this.txtPositionY.Location.Y.ToString();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            int red = int.Parse(this.txtRed.Text);
            int green = int.Parse(this.txtGreen.Text);
            int blue = int.Parse(this.txtBlue.Text);

            if (red==0 || green==0 || blue == 0) 
            {
                this.ForeColor = Color.White;
                this.btnChangeColor.ForeColor = Color.Black;
            }

            if (red < 0 || red > 255)
            {
                MessageBox.Show("El color rojo debe estar entre 0 y 255");
            }
            else if (green < 0 || green > 255)
            {
                MessageBox.Show("El color verde debe estar entre 0 y 255");
            }
            else if (blue < 0 || blue > 255)
            {
                MessageBox.Show("El color azul debe estar entre 0 y 255");
            }
            else 
            {
                this.BackColor = Color.FromArgb(red, green, blue);
            }
        }

        private void btnChangePosition_Click(object sender, EventArgs e)
        {
           
            int positionX = int.Parse(this.txtPositionX.Text);
            int positionY = int.Parse(this.txtPositionY.Text);

            this.txtPositionX.Location = (new Point(positionX, positionY));

        }

      
    }
}
