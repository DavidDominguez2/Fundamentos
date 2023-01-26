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
    public partial class Form05UpdateSala : Form {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;


        public Form05UpdateSala() {
            InitializeComponent();

            string connectionString = @"Data Source = LOCALHOST\DESARROLLO; Initial Catalog = HOSPITAL; Persist Security Info = True; User ID = SA; Password = MCSD2022";

            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

            this.loadSalas();
        }

        public void loadSalas() {
            string sql = "SELECT NOMBRE FROM SALA GROUP BY NOMBRE";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstSalas.Items.Clear();

            while (this.reader.Read()) {
                string name = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(name);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnUpdateSala_Click(object sender, EventArgs e) {
            string newSala = this.txtName.Text.ToString();
            string oldSala = this.lstSalas.SelectedItem.ToString();


            string sql = "UPDATE SALA SET NOMBRE = @NEWNAME WHERE NOMBRE = @OLDNAME";
            SqlParameter pamnewname = new SqlParameter("@NEWNAME", newSala);
            SqlParameter pamoldname = new SqlParameter("@OLDNAME", oldSala);

            this.com.Parameters.Add(pamnewname);
            this.com.Parameters.Add(pamoldname);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int updateados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            MessageBox.Show("Salas modificadas: " + updateados);

            this.txtName.Text = "";
            this.loadSalas();
        }
    }
}
