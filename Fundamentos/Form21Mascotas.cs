using ProyectoClase.Helpers;
using ProyectoClase.Models;
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
    public partial class Form21Mascotas : Form {
        HelperMascotas helper;
        public Form21Mascotas() {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        private void DibujarMascotas() {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas) {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNewRegister_Click(object sender, EventArgs e) {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtName.Text;
            mascota.Raza = this.txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();
        }

        private async void btnReadRegister_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                string path = ofd.FileName;
                await this.helper.ReadFileMascotasAsync(path);
                this.DibujarMascotas();
            }

        }

        private async void btnSaveRegister_Click(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) {
                string path = save.FileName;
                await this.helper.SaveFileMascotasAsync(path);
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.lstMascotas.SelectedIndex != -1) {
                Mascota mascota = this.helper.Mascotas[this.lstMascotas.SelectedIndex];
                this.txtName.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
