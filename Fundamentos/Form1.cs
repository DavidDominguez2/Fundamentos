namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //AQUI ESCRIBIREMOS NUESTRAS ACCIONES AL PULSAR EL BOTON
            this.txtNombre.Width = 150;
            this.btnPulsar.Text = "Botón pulsado!!!!";
            //TENEMOS PROPIEDADES QUE SON DE TIPO OBJETO
            this.txtNombre.Location = new Point(70, 100);
            //TENEMOS PROPIEDADES DE TIPO ENUMERADAS
            //UNA ENUMERACION SON UNA SERIE DE VALORES QUE
            //SE REPRENTAN DE FORMA GRAFICA Y AYUDAN AL PROGRAMADOR
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Chocolate;
            this.btnPulsar.BackColor = Color.LightBlue;

            //CONVERSION AUTOMATICA
            short numero = 99;
            int mayor = numero;

            //CASTING ENTRE OBJETOS
            int numeroMayor = 99;
            short numeroMenor = 888;
            //NECESITAMOS ALMACENAR EN
            //EL NUMERO MENOR EL DATO DEL MAYOR
            numeroMenor = (short)numeroMayor;

            //CONVERTIR STRING A PRIMITIVO
            string textoNumero = "154";
            int numeroEntero = int.Parse(textoNumero);
            double numeroDouble = double.Parse(textoNumero);

            //CONVERTIR CUALQUIER OBJETO A STRING
            string numeroText = numeroEntero.ToString();
            string boton = this.btnPulsar.ToString();
            

        }

       
    }
}