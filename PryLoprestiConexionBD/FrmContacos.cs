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
            using (SqlConnection cn = new SqlConnection(BD.cadenaConexion))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID FROM Contactos", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CmbContactos.DataSource = dt;
                CmbContactos.DisplayMember = "ID";
                CmbContactos.ValueMember = "ID";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idSeleccionado = Convert.ToInt32(CmbContactos.SelectedValue);

            using (SqlConnection cn = new SqlConnection(BD.cadenaConexion))
            {
                cn.Open();
                string query = "SELECT * FROM Contactos WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@ID", idSeleccionado);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable resultado = new DataTable();
                da.Fill(resultado);

                dgvContactos.DataSource = resultado;
            }

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            BD.CargarContactos(dgvContactos);
        }
    }
}
