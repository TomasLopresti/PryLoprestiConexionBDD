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
    public partial class FrmContacos : Form
    {
        public FrmContacos()
        {
            InitializeComponent();
        }
        clsConexion BD = new clsConexion();
        private void FrmContacos_Load(object sender, EventArgs e)
        {
            BD.CargarContactos(dgvContactos);
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Contactos", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
              
            }
        }

        /*private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                string consulta = "SELECT * FROM Contactos WHERE ID = @ID";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@ID", CmbContactos.SelectedValue);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);

                // Asumiendo que tienes un DataGridView llamado dataGridView1
                dgvContactos.DataSource = resultado;
            }
        }*/
    }
}
