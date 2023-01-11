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
    public partial class Form03AveriguaFecha : Form
    {
        public Form03AveriguaFecha()
        {
            InitializeComponent();
        }

        private void btnCalculateDate_Click(object sender, EventArgs e)
        {
            int day = int.Parse(this.txtDay.Text);
            int month = int.Parse(this.txtMonth.Text);
            int year = int.Parse(this.txtYear.Text);

            string dayweek ="";

            if (month == 1) 
            {
                month = 13;
                year -=1;
            }

            if (month == 2)
            {
                month = 14;
                year -= 1;
            }

            int op1, op2, op3, op4,op5,op6,op7;

            op1 = ((month + 1) * 3) / 5;
            op2 = year / 4;
            op3 = year / 100;
            op4 = year / 400;
            op5 = day + (month * 2) + year + op1 + op2 - op3 + op4 + 2;
            op6 = op5 / 7;
            op7 = op5 - (op6 * 7);

            switch (op7) {
                case 0:  dayweek = "Sábado"; break;
                case 1:  dayweek = "Domingo"; break;
                case 2:  dayweek = "Lunes"; break;
                case 3:  dayweek = "Martes"; break;
                case 4:  dayweek = "Miércoles"; break;
                case 5:  dayweek = "Jueves"; break;
                case 6:  dayweek = "Viernes"; break;
            }

            this.lblDate.Text = dayweek;
        }
    }
}
