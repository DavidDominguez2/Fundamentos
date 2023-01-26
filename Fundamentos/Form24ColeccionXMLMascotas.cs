using ProyectoClase.Helpers;
using ProyectoClase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Fundamentos {
    public partial class Form24ColeccionXMLMascotas : Form {
        XmlSerializer serializer;
        List<Mascota> coleccionMascotas;
        string path;

        public Form24ColeccionXMLMascotas() {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Mascota>));
            this.coleccionMascotas = new List<Mascota>();
        }

        private void btnNewMascota_Click(object sender, EventArgs e) {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtName.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtYears.Text);
            //CONVERT FILE TO BYTE[]
            mascota.Imagen = HelperMascotas.GetByteArrayFromString(this.path);
            //PARA PINTAR NECESITAMOS LA CLASE IMAGE: Image.FromStream(stream)
            //Stream stream = new MemoryStream(mascota.Imagen);
            //this.pictureBox1.Image = Image.FromStream(stream);

            this.coleccionMascotas.Add(mascota);
            this.txtName.Text = "";
            this.txtRaza.Text = "";
            this.txtYears.Text = "";
            this.DibujarMascotas();
        }

        private void DibujarMascotas() {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.coleccionMascotas) {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnReadRegister_Click(object sender, EventArgs e) {
            using (StreamReader reader = new StreamReader("coleccionmascotas.xml")) {
                this.coleccionMascotas = (List<Mascota>)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.DibujarMascotas();
        }

        private async void btnSaveRegister_Click(object sender, EventArgs e) {
            using (StreamWriter writer = new StreamWriter("coleccionmascotas.xml")) {
                this.serializer.Serialize(writer, this.coleccionMascotas);
                await writer.FlushAsync();
                writer.Close();
            }

            this.lstMascotas.Items.Clear();
            this.coleccionMascotas.Clear();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e) {
            int indice = this.lstMascotas.SelectedIndex;
            if (indice != -1) {
                Mascota mascota = this.coleccionMascotas[indice];
                this.txtName.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtYears.Text = mascota.Years.ToString();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                this.path = ofd.FileName;
                Stream stream = new MemoryStream(HelperMascotas.GetByteArrayFromString(this.path));
                this.pictureBox1.Image = Image.FromStream(stream);
            }
        }
    }
}
