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
    public partial class Form22ObjetoXMLMascota : Form {
        //EL OBJETO PARA SERIALIZAR EN XML
        XmlSerializer serializer;
        public Form22ObjetoXMLMascota() {
            InitializeComponent();
            //EN EL MOMENTO DE INSTANCIAR EL OBJETO SERÁ
            //NECESARIO INDICAR LA CLASE QUE UTILIZARA
            //EN LA SERIALIZACION
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnReadDato_Click(object sender, EventArgs e) {
            //LEER ES IGUAL SOLO QUE UTILIZA UN OBJETO LLAMADO
            //StreamReader
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml")) {
                //NECESITAMOS RECUPERAR EL OBJETO MASCOTA
                //MEDIANTE EL SERIALIZADOR TIENE UN METODO
                //LLAMADO Deserialize() QUE RECUPERA EL OBJETO
                //SERIALIZADO
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.txtName.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtYears.Text = mascota.Years.ToString();
        }

        private async void btnSaveDato_Click(object sender, EventArgs e) {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtName.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtYears.Text);
            //PARA SERIALIZAR SE UTILIZA EL OBJETO DE System.IO
            //LLAMADO StreamWriter
            //NO IMPORTA LA EXTENSION DEL ARCHIVO, SIEMPRE LO
            //ALAMACENA CON FORMATO XML
            using (StreamWriter writer = new StreamWriter("mascota.xml")) {
                //EL SERIALIZADOR XML TIENE UN METODO LLAMADO
                //Serialize() QUE UTILIZA EL FICHERO PARA GUARDAR EL OBJETO
                this.serializer.Serialize(writer, mascota);
                //COMO HABLAMOS DE FICHERPOS Y ESCRITURA
                //DEBEMOS UTILIZAR Flush()
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtName.Text = "";
            this.txtRaza.Text = "";
            this.txtYears.Text = "";

        }
    }
}
