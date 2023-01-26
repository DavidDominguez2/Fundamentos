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
    public partial class Form03BuscadorEmpleados : Form {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form03BuscadorEmpleados() {
            InitializeComponent();

            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2022";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnSearchOffice_Click(object sender, EventArgs e) {
            string oficio = this.txtOffice.Text;
            string sql = "select * from emp where oficio= '" + oficio + "'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmployees.Items.Clear();

            while (this.reader.Read()) {
                string apellido = this.reader["APELLIDO"].ToString();
                string ofi = this.reader["OFICIO"].ToString();
                this.lstEmployees.Items.Add(apellido + " - " + ofi);
            }

            this.reader.Close();
            this.cn.Close();
        }
    }
}
