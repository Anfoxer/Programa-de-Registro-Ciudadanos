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

namespace empadronamiento
{
    public partial class Form1 : Form
    {
        //CONEXCION CON BD SQL

        string CONEXION = "Data Source=ALBERT;Initial Catalog=Registro_Padron;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Bonton de registrar ______
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CONEXION))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TablaRegistro (cod, Nombre1, Nombre2, Nombre3, Apellido1, Apellido2, Casado, CUI, Fecha, Pais, Departamento, Municipio, Correo, Confirmacion) VALUES ('"+txtCode.Text+"', '"+txtNombre1.Text+"','"+txtNombre2.Text+"', '"+TxtNombre3.Text+"', '"+txtApellido1.Text+"', '"+txtApellido2.Text+"', '"+txtCasado.Text+"', '"+txtCui.Text+"', '"+txtFecha.Text+"', '"+txtPais.Text+"', '"+txtDepa.Text+"', '"+txtMunici.Text+"', '"+txtCorreo.Text+"', '"+txtConfirma.Text+"')", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso");
            }
        }

        //Boton de modificar______
        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CONEXION))
            {
                SqlCommand cmd = new SqlCommand("UPDATE TablaRegistro SET  Nombre1 = '"+txtNombre1.Text+"', Nombre2 = '"+txtNombre2.Text + "', Nombre3 = '"+TxtNombre3.Text + "', Apellido1 = '"+txtApellido1.Text + "', Apellido2 = '"+txtApellido2.Text + "', Casado = '"+txtCasado.Text + "', CUI = '"+txtCui.Text + "', Fecha = '"+txtFecha.Text + "', Pais = '"+txtPais.Text + "', Departamento = '"+txtDepa.Text + "', Municipio = '"+txtMunici.Text + "', Correo = '"+txtCorreo.Text + "', Confirmacion  = '"+txtConfirma.Text + "' WHERE Cod = '"+txtCode.Text + "'", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modificado");
            }
        }

        //boton de elimiar_______
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CONEXION))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM TablaRegistro WHERE Cod = '"+txtCode.Text+"'", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eliminado");
            }
        }

        //Boton de Limpiar Registro_____
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCode.Clear();
            this.txtNombre1.Clear();
            this.txtNombre2.Clear();
            this.TxtNombre3.Clear();
            this.txtApellido1.Clear();
            this.txtApellido2.Clear();
            this.txtCasado.Clear();
            this.txtCui.Clear();
            this.txtFecha.Clear();
            this.txtPais.Clear();
            this.txtDepa.Clear();
            this.txtMunici.Clear();
            this.txtCorreo.Clear();
            this.txtConfirma.Clear();
        }

        //Boton para abrir formulario de consulta_____
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Hide();
            Consultas formMain = new Consultas();
            formMain.ShowDialog(this);
            Show();
        }

        // boton cerrar
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
