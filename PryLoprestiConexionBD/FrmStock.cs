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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PryLoprestiConexionBD
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }
        clsConexion BD = new clsConexion();
        
        private void FrmStock_Load(object sender, EventArgs e)
        {
            BD.CargarProducto(dgvStock);
            using (SqlConnection cn = new SqlConnection(BD.cadenaConexion))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Codigo FROM Productos", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCodigo.DataSource = dt;
                cmbCodigo.DisplayMember = "Codigo";
                cmbCodigo.ValueMember = "Codigo";
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigoSeleccionado = Convert.ToInt32(cmbCodigo.SelectedValue);

            using (SqlConnection cn = new SqlConnection(BD.cadenaConexion))
            {
                cn.Open();
                string query = "SELECT * FROM Productos WHERE Codigo = @codigo";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@codigo", codigoSeleccionado);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable resultado = new DataTable();
                da.Fill(resultado);

                dgvStock.DataSource = resultado;
            }

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            BD.CargarProducto(dgvStock);
        }
    }
}
