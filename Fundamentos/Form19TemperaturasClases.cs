using ProyectoClase;
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
    public partial class Form19TemperaturasClases : Form {

        List<TemperaturaAnyo> anyos;
        public Form19TemperaturasClases() {
            InitializeComponent();
            this.anyos = new List<TemperaturaAnyo>();
            this.generateAnyos();
        }

        private void generateAnyos() {
            this.cmbYears.Items.Clear();
            this.anyos.Clear();
            DateTime time = DateTime.Parse("01/01/2018");
            for (int i = 0; i <= 5; i++) {
                TemperaturaAnyo anyo = new TemperaturaAnyo();
                int anyoNum = time.Year;
                anyo.Anyo = anyoNum;
                anyo.Meses = this.generateDataMonths();
                List<int> listTemps = new List<int>();
                foreach (TemperaturaMes mes in anyo.Meses) {
                    listTemps.Add(mes.Max);
                    listTemps.Add(mes.Min);
                }
                anyo.MaxAnual = listTemps.Max();
                anyo.MinAnual = listTemps.Min();
                this.anyos.Add(anyo);
                this.cmbYears.Items.Add(anyoNum.ToString());
                time = time.AddYears(1);
            }
            this.cmbYears.SelectedIndex = 0;
        }

        private List<TemperaturaMes> generateDataMonths() {
            List<TemperaturaMes> dataMeses = new List<TemperaturaMes>();
            Random random = new Random();
            DateTime tiempo = DateTime.Parse("01/01/2023");
            for (int i = 1; i <= 12; i++) {
                TemperaturaMes mes = new TemperaturaMes();
                string nombremes = tiempo.ToString("MMMM").ToUpper();
                mes.Mes = nombremes;
                mes.Max = random.Next(10, 50);
                mes.Min = random.Next(-10, 9);
                dataMeses.Add(mes);
                tiempo = tiempo.AddMonths(1);
            }

            return dataMeses;
        }

        private void btnMonths_Click(object sender, EventArgs e) {
            generateAnyos();
        }



        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e) {
            int index = this.lstMeses.SelectedIndex;
            int indexAnyo = this.cmbYears.SelectedIndex;


            int max = this.anyos[indexAnyo].Meses[index].Max;
            int min = this.anyos[indexAnyo].Meses[index].Min;
            int med = this.anyos[indexAnyo].Meses[index].MediaTemp();

            this.txtMax.Text = max.ToString();
            this.txtMin.Text = min.ToString();
            this.txtMed.Text = med.ToString();
        }

        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e) {
            this.lstMeses.Items.Clear();
            int index = this.cmbYears.SelectedIndex;
            int max = this.anyos[index].MaxAnual;
            int min = this.anyos[index].MinAnual;
            int med = this.anyos[index].MediaAnual();

            this.txtMaxAnual.Text = max.ToString();
            this.txtMinAnual.Text = min.ToString();
            this.txtMediaAnual.Text = med.ToString();

            foreach (TemperaturaMes mes in this.anyos[index].Meses) {
                this.lstMeses.Items.Add(mes.Mes);
            }

        }
    }
}
