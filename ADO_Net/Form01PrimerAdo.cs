using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Net {
    public partial class Form01PrimerAdo : Form {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form01PrimerAdo() {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2022";
            //SIEMPRE CONNECTIONSTRING EN EL CONSTRUCTOR DE CONNECTION
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();

            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e) {
            this.lblMessage.Text = "La conexión está cambiando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConect_Click(object sender, EventArgs e) {
            try {
                if (this.cn.State == ConnectionState.Closed) {
                    this.cn.Open();
                }

                this.lblMessage.BackColor = Color.LightGreen;
            } catch (Exception ex) {
                this.lblMessage.Text = "Error al intentar conectarse a la base de datos. " + ex;
            }
        }

        private void btnDisconect_Click(object sender, EventArgs e) {
            this.cn.Close();

            this.lblMessage.BackColor = Color.Red;
        }

        private void btnReadData_Click(object sender, EventArgs e) {
            string sql = "SELECT * FROM EMP";
            //INDICAMOS AL COMANDO LA CONEXION A UTILIZAR
            this.com.Connection = this.cn;
            //INDICAMOS EL TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //INDICAMOS LA CONSULTA
            this.com.CommandText = sql;
            //CON TODO CONFIGURADO PARA EJECUTAR LA CONSULTA
            //DEBEMOS TENER UNA CONEXION ABIERTA
            //EJECUTAMOS LA CONSULTA Y EXTRAEMOS EL READER
            this.reader = this.com.ExecuteReader();

            //LAS COLUMNAS SE LEEN CON UN FOR
            for (int i = 0; i < this.reader.FieldCount; i++) {
                //DIBUJAMOS LA PRIMERA COLUMNA DE LA TABLA
                string column = this.reader.GetName(i);
                //DIBUJAMOS EL TIPO DE LA PRIMERA COLUMNA DE LA TABLA
                string tipo = this.reader.GetDataTypeName(i);
                this.lstColumns.Items.Add(column);
                this.lstDataTypes.Items.Add(tipo);
            }

            //PARA ACCEDER A LOS DATOS DEBEMOS LEER
            //Read() DEVUELVE UN bool, ASI QUE PARA LEER TODOS
            //LOS DATOS NECESITAMOS UN WHILE
            while (this.reader.Read()) {
                //VAMOS A RECUPERAR UN APELLIDO 
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            };

            this.reader.Close();

        }
    }
}
