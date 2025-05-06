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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        clsConexion BD = new clsConexion();
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            
            BD.CargarProducto(dgvManejo);
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                CmbCategorias.DataSource = dt;
                CmbCategorias.DisplayMember = "Categoria";
                NumPrecio.Maximum = 1000000;
                NumPrecio.Minimum = 0;
                NumStock.Maximum = 10000000;
                NumStock.Minimum = 0;
                NumCodigo.Maximum = 1000000;
                NumCodigo.Minimum = 0;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio, TxtDescripción, NumPrecio, CmbCategorias);
            try
            {
                clsProducto producto = new clsProducto();
                clsConexion BD = new clsConexion();
                producto.Codigo = Convert.ToInt32(NumCodigo.Value);
                producto.Nombre = TxtNombre.Text;
                producto.Descripcion = TxtDescripción.Text;
                producto.Precio = Convert.ToInt32(NumPrecio.Value);
                producto.Stock = Convert.ToInt32(NumStock.Value);
                producto.Categoria = CmbCategorias.Text;
                BD.CargarProducto(dgvManejo);
                BD.Agregar(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se agrego el producto");
            }
            BD.CargarProducto(dgvManejo);
            limpiarDatos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio, TxtDescripción, NumPrecio, CmbCategorias);
            try
            {
                int codigo = (int)NumCodigo.Value;

                clsConexion BD = new clsConexion();
                BD.Eliminar(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se elimino el producto", ex.Message);
            }
            BD.CargarProducto(dgvManejo);
            limpiarDatos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio, TxtDescripción, NumPrecio, CmbCategorias);
            try
            {
                clsConexion BD = new clsConexion();
                clsProducto producto = new clsProducto();
                {
                    producto.Codigo = Convert.ToInt32(NumCodigo.Value);
                    producto.Nombre = TxtNombre.Text;
                    producto.Descripcion = TxtDescripción.Text;
                    producto.Precio = Convert.ToInt32(NumPrecio.Value);
                    producto.Stock = Convert.ToInt32(NumStock.Value);
                    producto.Categoria = CmbCategorias.Text;
                    BD.Modificar(producto);
                    BD.CargarProducto(dgvManejo);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se modifico el producto", ex.Message);
            }
            limpiarDatos();
        }
        public void controlDeDatos(TextBox txt, NumericUpDown num, TextBox txt2, NumericUpDown num2, ComboBox cmb)
        {
            if (NumCodigo.Value != 0)
            {
                if (txt.Text != "" && num.Value != 0 && txt2.Text != "" && num2.Value != 0 && cmb.SelectedIndex != -1)
                {
                    btnAgregar.Enabled = true;

                }
                else
                {
                    btnAgregar.Enabled = false;
                }

                if (txt.Text != "" || num.Value != 0 || txt2.Text != "" || num2.Value != 0 || cmb.SelectedIndex != -1)
                {
                    btnModificar.Enabled = true;

                }
                else
                {
                    btnModificar.Enabled = false;
                }
            }
        }

        private void NumCodigo_ValueChanged(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio,TxtDescripción,NumPrecio,CmbCategorias);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio, TxtDescripción, NumPrecio, CmbCategorias);
        }

        private void TxtDescripción_TextChanged(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio, TxtDescripción, NumPrecio, CmbCategorias);
        }

        private void NumPrecio_ValueChanged(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio, TxtDescripción, NumPrecio, CmbCategorias);
        }

        private void NumStock_ValueChanged(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio, TxtDescripción, NumPrecio, CmbCategorias);
        }

        private void CmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlDeDatos(TxtNombre, NumPrecio, TxtDescripción, NumPrecio, CmbCategorias);
        }
        public void limpiarDatos()
        {
            NumCodigo.Value = 0;
            NumCodigo.Enabled = true;
            TxtNombre.Text = "";
            NumStock.Value = 0;
            TxtDescripción.Text = "";
            NumPrecio.Value = 0;
            CmbCategorias.SelectedIndex = -1;
            CmbCategorias.Text = "Seleccione...";
            btnAgregar.Enabled = false;

        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            dgvManejo.ClearSelection();
            NumCodigo.Focus();
        }

        

        private void dgvManejo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita que cambie si selecciona el encabezado
            {
                DataGridViewRow fila = dgvManejo.Rows[e.RowIndex];

                NumCodigo.Value = Convert.ToDecimal(fila.Cells["Codigo"].Value);
                TxtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                NumStock.Value = Convert.ToDecimal(fila.Cells["Stock"].Value);
                TxtDescripción.Text = fila.Cells["Descripcion"].Value?.ToString();
                NumPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                CmbCategorias.Text = fila.Cells["Categoria"].Value.ToString();
            }
        }

        private void dgvManejo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAgregar.Enabled = false;
        }
    }
}
