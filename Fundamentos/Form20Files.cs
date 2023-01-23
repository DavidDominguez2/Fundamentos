using ProyectoClase.Helpers;
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
    public partial class Form20Files : Form {
        public Form20Files() {
            InitializeComponent();

        }

        public async void btnReadFile_Click(object sender, EventArgs e) {
            //OBJETO PARA ABRIR FILES
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                string path = ofd.FileName;
                string contenido = await HelperFiles.ReadFileAsync(path);
                this.txtContentFile.Text = contenido;
                this.SetStringNombres(contenido);
            }

        }

        private async void btnWriteFile_Click(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) {
                string path = save.FileName;
                await HelperFiles.WriteFileAsync(path, this.GetStringNombres());
                this.lstNombres.Items.Clear();
                MessageBox.Show("Datos Guardados");
            }
        }

        //METODO PARA RECUPERAR TODOS LOS NOMBRES
        //DE LA LISTA EN FORMATO SPARADOS POR COMAS
        public string GetStringNombres() {
            string datos = "";
            foreach (string nombre in this.lstNombres.Items) {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        //METODO PARA ESCRIBIR LOS NOMBRES QUE
        //TENGAMOS EN UN STRING EN EL LISTBOX
        public void SetStringNombres(string data) {
            string[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();
            foreach (string name in nombres) {
                this.lstNombres.Items.Add(name);
            }
        }

        private void btnAddName_Click(object sender, EventArgs e) {
            string nombre = this.txtName.Text;
            this.lstNombres.Items.Add(nombre);
            this.txtName.SelectAll();
            this.txtName.Focus();
        }
    }
}
