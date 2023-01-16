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
    public partial class Form16TablaMultiplicar : Form {
        List<TextBox> txtBoxes;
        public Form16TablaMultiplicar() {
            InitializeComponent();
            this.txtBoxes = new List<TextBox>();

            foreach (TextBox box in this.gpbTable.Controls) {
                this.txtBoxes.Add(box);
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e) {
            int num = int.Parse(this.txtNum.Text);
            this.txtBoxes.Reverse();

            for (int i = 0; i < this.txtBoxes.Count; i++) {
                int mul = (i + 1) * num;
                this.txtBoxes[i].Text = mul.ToString();
            }
        }
    }
}
