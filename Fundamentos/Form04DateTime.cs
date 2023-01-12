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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtDate.Text = DateTime.Now.ToString();
        }

        private void chkChangeFormatDate_CheckedChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.txtDate.Text);
            if(this.chkChangeFormatDate.Checked)
            {
                this.txtDate.Text = date.ToShortDateString();
            }else
            {
                this.txtDate.Text = date.ToLongDateString();
            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncrement.Text);
            DateTime date = DateTime.Parse(this.txtDate.Text);

            if (this.rdbDays.Checked)
            {
                date = date.AddDays(incremento);
            }
            else if (this.rdbMonths.Checked)
            {
                date = date.AddMonths(incremento);
            }
            else
            {
                date = date.AddYears(incremento);
            }

            this.txtNewDate.Text = date.ToString();
        }
    }
}
