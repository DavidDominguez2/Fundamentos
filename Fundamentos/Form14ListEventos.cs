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
    public partial class Form14ListEventos : Form {
        //DECLARAMOS LA COLECCION A NIVEL DE CLASE
        //PARA UTILIZARLA EN OTROS EVENTOS
        List<Button> botones;

        //LAS VARIABLES A NIVEL DE CLASE
        //MANTIENEN SU VALOR MIENTRAS ESTEMOS TRABAJANDO CON
        //ESTA CLASE
        int contador;

        public Form14ListEventos() {
            InitializeComponent();

            this.botones = new List<Button>();
            this.contador = 0;
            //VAMOS A RELLENAR LA COLECCION CON TODOS LOS
            //BOTONES DEL DIBUJO
            //DENTRO DE LA CLASE CONTROL (FORM )TENEMOS UNA
            //COLECCION LLAMADA Controls QUE CONTIENE TODOS LOS
            //CONTROLES DEL FORM
            //VAMOS A RECORRER TODOS LOS CONTROLES Y AÑADIRLOS A 
            //NUESTRA COLECCION DE FORMA DINAMICA
            foreach (Control control in this.Controls) {
                if (control is Button) {
                    this.botones.Add((Button)control);
                }
            }

            //AQUI MANEJAMOS NUESTRA COLECCION PERSONALIZADA
            //ASOCIAMOS CADA BOTON DE LA COLECCION A UN METODO EVENTO
            foreach (Button button in this.botones) {
                button.Click += BotonPulsado;
            }

        }

        private void BotonPulsado(object sender, EventArgs e) {
            contador++;
            this.txtMessage.Text = contador.ToString();
            //NECESITO ACCEDER AL BOTON, CUANDO PULSEMOS SOBRE EL
            //BOTON, CAMBIAMOS SU COLOR....
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            btn.Text = this.contador.ToString();
        }
    }
}
