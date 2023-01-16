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
    public partial class Form15SumarBotones : Form {
        List<Button> botones;
        int sum;
        public Form15SumarBotones() {
            InitializeComponent();
            botones = new List<Button>();
            sum = 0;

            foreach (Control control in this.pnlBtns.Controls) {
                if (control is Button) {
                    this.botones.Add((Button)control);
                }
            }
            Random rm = new Random();
            foreach (Button btn in this.botones) {
                int num = rm.Next(1, 100);
                btn.Text = num.ToString();
                btn.Click += suma;
            }
        }

        private void suma(object? sender, EventArgs e) {
            Button btn = (Button)sender;
            sum += int.Parse(btn.Text);
            this.txtResult.Text = sum.ToString();
            btn.BackColor = Color.Coral;
        }

        private void btnReload_Click(object sender, EventArgs e) {
            Random rm = new Random();
            this.sum = 0;
            this.txtResult.Text = "0";
            foreach (Button btn in this.botones) {
                int num = rm.Next(1, 100);
                btn.Text = num.ToString();
                btn.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            }

        }
    }
}
