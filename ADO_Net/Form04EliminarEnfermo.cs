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
    public partial class Form04EliminarEnfermo : Form {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04EliminarEnfermo() {
            InitializeComponent();

            string connectionString = @"Data Source = LOCALHOST\DESARROLLO; Initial Catalog = HOSPITAL; Persist Security Info = True; User ID = SA; Password = MCSD2022";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

            this.loadEnfermos();
        }

        public void loadEnfermos() {
            string sql = "SELECT * FROM ENFERMO";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();

            while (this.reader.Read()) {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            int inscription = int.Parse(this.txtInscripcion.Text);
            string sql = "DELETE FROM ENFERMO WHERE INSCRIPCION=@INSCRIPCION";

            //CREAMOS UN NUEVO OBJETO PARAMETRO
            SqlParameter paminscription = new SqlParameter("@INSCRIPCION", inscription);
            /*
             paminscription.ParameterName = "@INSCRIPCION";
            paminscription.Value = inscription;
            //TIPO DE DATO
            paminscription.SqlDbType = SqlDbType.Int;
            //DIRECTION NO ES NECESARIO A NO SER QUE DEESEMOS CAMBIAR
            //SU VALOR POR DEFECTO (Input)
            paminscription.Direction = ParameterDirection.Input;
             */
            //DEBEMOS AÑADIR A LA COLECCION DEL COMMAND LOS PARAMETROS
            this.com.Parameters.Add(paminscription);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();

            MessageBox.Show("Enfermos eliminados: " + eliminados);

            this.txtInscripcion.Text = "";
            this.loadEnfermos();
        }

        private void lstEnfermos_SelectedIndexChanged(object sender, EventArgs e) {
            this.txtInscripcion.Text = this.lstEnfermos.SelectedItem.ToString().Split("-")[0].Trim();
        }
    }
}
