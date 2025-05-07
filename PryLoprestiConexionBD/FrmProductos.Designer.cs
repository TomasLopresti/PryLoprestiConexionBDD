namespace PryLoprestiConexionBD
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.dgvManejo = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.LblCódigo = new System.Windows.Forms.Label();
            this.NumCodigo = new System.Windows.Forms.NumericUpDown();
            this.mrcAMEProductos = new System.Windows.Forms.GroupBox();
            this.CmbCategorias = new System.Windows.Forms.ComboBox();
            this.LblCategorías = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.NumStock = new System.Windows.Forms.NumericUpDown();
            this.NumPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.LblDescripción = new System.Windows.Forms.Label();
            this.TxtDescripción = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCodigo)).BeginInit();
            this.mrcAMEProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManejo
            // 
            this.dgvManejo.AllowUserToAddRows = false;
            this.dgvManejo.AllowUserToDeleteRows = false;
            this.dgvManejo.AllowUserToResizeColumns = false;
            this.dgvManejo.AllowUserToResizeRows = false;
            this.dgvManejo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManejo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvManejo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvManejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManejo.Location = new System.Drawing.Point(219, 12);
            this.dgvManejo.MultiSelect = false;
            this.dgvManejo.Name = "dgvManejo";
            this.dgvManejo.ReadOnly = true;
            this.dgvManejo.RowHeadersVisible = false;
            this.dgvManejo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManejo.Size = new System.Drawing.Size(660, 426);
            this.dgvManejo.TabIndex = 2;
            this.dgvManejo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManejo_CellClick);
            this.dgvManejo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvManejo_CellMouseClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(13, 294);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 43);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeshacer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.BackgroundImage")));
            this.btnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacer.Location = new System.Drawing.Point(105, 343);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(79, 43);
            this.btnDeshacer.TabIndex = 1;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(13, 343);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 43);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(105, 294);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 43);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // LblCódigo
            // 
            this.LblCódigo.AutoSize = true;
            this.LblCódigo.Location = new System.Drawing.Point(5, 16);
            this.LblCódigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCódigo.Name = "LblCódigo";
            this.LblCódigo.Size = new System.Drawing.Size(43, 13);
            this.LblCódigo.TabIndex = 26;
            this.LblCódigo.Text = "Código:";
            // 
            // NumCodigo
            // 
            this.NumCodigo.Location = new System.Drawing.Point(8, 31);
            this.NumCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.NumCodigo.Name = "NumCodigo";
            this.NumCodigo.Size = new System.Drawing.Size(80, 20);
            this.NumCodigo.TabIndex = 27;
            this.NumCodigo.ValueChanged += new System.EventHandler(this.NumCodigo_ValueChanged);
            // 
            // mrcAMEProductos
            // 
            this.mrcAMEProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mrcAMEProductos.Controls.Add(this.CmbCategorias);
            this.mrcAMEProductos.Controls.Add(this.LblCategorías);
            this.mrcAMEProductos.Controls.Add(this.lblStock);
            this.mrcAMEProductos.Controls.Add(this.NumStock);
            this.mrcAMEProductos.Controls.Add(this.NumPrecio);
            this.mrcAMEProductos.Controls.Add(this.lblPrecio);
            this.mrcAMEProductos.Controls.Add(this.LblDescripción);
            this.mrcAMEProductos.Controls.Add(this.TxtDescripción);
            this.mrcAMEProductos.Controls.Add(this.LblNombre);
            this.mrcAMEProductos.Controls.Add(this.TxtNombre);
            this.mrcAMEProductos.Controls.Add(this.NumCodigo);
            this.mrcAMEProductos.Controls.Add(this.LblCódigo);
            this.mrcAMEProductos.Controls.Add(this.btnModificar);
            this.mrcAMEProductos.Controls.Add(this.btnEliminar);
            this.mrcAMEProductos.Controls.Add(this.btnDeshacer);
            this.mrcAMEProductos.Controls.Add(this.btnAgregar);
            this.mrcAMEProductos.Location = new System.Drawing.Point(12, 12);
            this.mrcAMEProductos.Name = "mrcAMEProductos";
            this.mrcAMEProductos.Size = new System.Drawing.Size(200, 426);
            this.mrcAMEProductos.TabIndex = 0;
            this.mrcAMEProductos.TabStop = false;
            this.mrcAMEProductos.Text = "Control Productos";
            // 
            // CmbCategorias
            // 
            this.CmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategorias.FormattingEnabled = true;
            this.CmbCategorias.Location = new System.Drawing.Point(8, 229);
            this.CmbCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCategorias.Name = "CmbCategorias";
            this.CmbCategorias.Size = new System.Drawing.Size(187, 21);
            this.CmbCategorias.TabIndex = 36;
            this.CmbCategorias.SelectedIndexChanged += new System.EventHandler(this.CmbCategorias_SelectedIndexChanged);
            // 
            // LblCategorías
            // 
            this.LblCategorías.AutoSize = true;
            this.LblCategorías.Location = new System.Drawing.Point(5, 209);
            this.LblCategorías.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategorías.Name = "LblCategorías";
            this.LblCategorías.Size = new System.Drawing.Size(62, 13);
            this.LblCategorías.TabIndex = 37;
            this.LblCategorías.Text = "Categorías:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(5, 173);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 35;
            this.lblStock.Text = "Stock:";
            // 
            // NumStock
            // 
            this.NumStock.Location = new System.Drawing.Point(8, 188);
            this.NumStock.Margin = new System.Windows.Forms.Padding(2);
            this.NumStock.Name = "NumStock";
            this.NumStock.Size = new System.Drawing.Size(80, 20);
            this.NumStock.TabIndex = 34;
            this.NumStock.ValueChanged += new System.EventHandler(this.NumStock_ValueChanged);
            // 
            // NumPrecio
            // 
            this.NumPrecio.Location = new System.Drawing.Point(8, 149);
            this.NumPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.NumPrecio.Name = "NumPrecio";
            this.NumPrecio.Size = new System.Drawing.Size(108, 20);
            this.NumPrecio.TabIndex = 32;
            this.NumPrecio.ValueChanged += new System.EventHandler(this.NumPrecio_ValueChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(5, 134);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio:";
            // 
            // LblDescripción
            // 
            this.LblDescripción.AutoSize = true;
            this.LblDescripción.Location = new System.Drawing.Point(5, 97);
            this.LblDescripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripción.Name = "LblDescripción";
            this.LblDescripción.Size = new System.Drawing.Size(66, 13);
            this.LblDescripción.TabIndex = 31;
            this.LblDescripción.Text = "Descripción:";
            // 
            // TxtDescripción
            // 
            this.TxtDescripción.Location = new System.Drawing.Point(8, 112);
            this.TxtDescripción.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescripción.Name = "TxtDescripción";
            this.TxtDescripción.Size = new System.Drawing.Size(187, 20);
            this.TxtDescripción.TabIndex = 30;
            this.TxtDescripción.TextChanged += new System.EventHandler(this.TxtDescripción_TextChanged);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(5, 56);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 29;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(8, 71);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(187, 20);
            this.TxtNombre.TabIndex = 28;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryLoprestiConexionBD.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.dgvManejo);
            this.Controls.Add(this.mrcAMEProductos);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCodigo)).EndInit();
            this.mrcAMEProductos.ResumeLayout(false);
            this.mrcAMEProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvManejo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label LblCódigo;
        private System.Windows.Forms.NumericUpDown NumCodigo;
        private System.Windows.Forms.GroupBox mrcAMEProductos;
        private System.Windows.Forms.ComboBox CmbCategorias;
        private System.Windows.Forms.Label LblCategorías;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown NumStock;
        private System.Windows.Forms.NumericUpDown NumPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label LblDescripción;
        private System.Windows.Forms.TextBox TxtDescripción;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}