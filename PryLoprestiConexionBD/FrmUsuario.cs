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
        int intentosFallidos = 0;
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            clsConexion conexion = new clsConexion();

            if (conexion.ValidarUsuario(usuario, contraseña))
            {
                this.Hide();
                FrmInicio inicio = new FrmInicio();
                inicio.Show();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (intentosFallidos >= 3)
                {
                    MessageBox.Show("Ha superado el número máximo de intentos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit(); // Cierra toda la aplicación
                }
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false; // Muestra el texto
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;  // Lo oculta
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
    }
}


