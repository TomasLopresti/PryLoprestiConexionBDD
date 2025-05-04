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
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbCodigo.DataSource = dt;
                cmbCodigo.DisplayMember = "Codigo";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
