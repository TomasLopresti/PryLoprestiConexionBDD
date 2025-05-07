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

namespace PryLoprestiConexionBD
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            // Cadena de conexión (ajústala con tus datos)
            string cadenaConexion = "Server=TU_SERVIDOR;Database=Comercio;Trusted_Connection=True;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM Usuario WHERE usuario = @usuario AND contraseña = @contraseña";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@contraseña", contraseña);

                        int resultado = (int)comando.ExecuteScalar();

                        if (resultado > 0)
                        {
                            // Login exitoso
                            MessageBox.Show("¡Bienvenido!");
                            this.Hide(); // Oculta el formulario de login
                            FrmInicio frm = new FrmInicio(); // tu formulario principal
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }   
    }
}


