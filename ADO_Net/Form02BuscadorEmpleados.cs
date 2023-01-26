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
    public partial class Form02BuscadorEmpleados : Form {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleados() {
            InitializeComponent();

            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2022";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            int salario = int.Parse(this.txtSalary.Text);
            string sql = "select * from emp where salario >= " + salario;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //SIEMPRE UTILIZAREMOS LO MISMO: ENTRAR Y SALIR
            //ABRIMOS CONEXION: ENTRAMOS
            this.cn.Open();
            //EJECUTAMOS NUESTRA CONSULTA
            this.reader = this.com.ExecuteReader();
            //LEEMOS LOS DATOS
            this.lstEmployees.Items.Clear();
            while (this.reader.Read()) {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstEmployees.Items.Add(apellido + " - " + sal);
            }
            //SALIMOS
            //CERRAMOS READER Y CONEXION (EL ORDEN NO IMPORTA)
            this.reader.Close();
            this.cn.Close();
        }
    }
}
