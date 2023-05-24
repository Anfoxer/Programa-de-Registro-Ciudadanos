using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace empadronamiento
{
    public partial class Consultas : Form
    {
        //CONEXCION CON BD SQL

        string CONEXION = "Data Source=ALBERT;Initial Catalog=Registro_Padron;Integrated Security=True";

        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        //boton mostrar____
        private void btnMostrar_Click(object sender, EventArgs e)

        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(CONEXION))
            {
                SqlDataAdapter da = new SqlDataAdapter ("SELECT * FROM TablaRegistro", con);
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dgvmostrar.DataSource = dt;
            }
        }

        //boton consultar por codigo
        private void btnCodigo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(CONEXION))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TablaRegistro WHERE Cod = '"+txtconsulta.Text+"'", con);
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dgvmostrar.DataSource = dt;
            }
        }

        //boton de consulta por nombre
        private void btnConsultaName_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(CONEXION))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TablaRegistro WHERE Nombre1 LIKE '%' +  '"+txtconsulta.Text+ "' + '%' Or Nombre2 LIKE '%' +  '" + txtconsulta.Text+ "' + '%' Or Nombre3 LIKE '%' +  '" + txtconsulta.Text+ "' + '%' ", con);
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dgvmostrar.DataSource = dt;
            }
        }

        // Boton de consulta por apellido
        private void btnApellido_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(CONEXION))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TablaRegistro WHERE Apellido1 LIKE '%' +  '" + txtconsulta.Text + "' + '%' Or Apellido2 LIKE '%' +  '" + txtconsulta.Text + "' + '%' ", con);
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dgvmostrar.DataSource = dt;
            }
        }

        // Boton consulta por cui
        private void btnCui_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(CONEXION))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TablaRegistro WHERE CUI LIKE '%' +  '" + txtconsulta.Text + "' + '%' ", con);
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dgvmostrar.DataSource = dt;
            }
        }

        //boton regresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
        }
    }
}
