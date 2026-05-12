namespace Capa_UI
{
    partial class FRMListaVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.CHKItem = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.ID_INTERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_de_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNCarro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(262, 434);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(119, 50);
            this.BTNBuscar.TabIndex = 0;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(600, 434);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(119, 50);
            this.BTNCancelar.TabIndex = 1;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // CHKItem
            // 
            this.CHKItem.AutoSize = true;
            this.CHKItem.Location = new System.Drawing.Point(128, 114);
            this.CHKItem.Name = "CHKItem";
            this.CHKItem.Size = new System.Drawing.Size(124, 17);
            this.CHKItem.TabIndex = 3;
            this.CHKItem.Text = "Pieza no encontrada";
            this.CHKItem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(588, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // DGVListado
            // 
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_INTERNO,
            this.Nro_Pieza,
            this.Nombre_de_Pieza,
            this.Marca,
            this.Descripcion});
            this.DGVListado.Location = new System.Drawing.Point(15, 147);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.Size = new System.Drawing.Size(704, 270);
            this.DGVListado.TabIndex = 5;
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellContentClick);
            // 
            // ID_INTERNO
            // 
            this.ID_INTERNO.HeaderText = "ID INTERNO";
            this.ID_INTERNO.Name = "ID_INTERNO";
            // 
            // Nro_Pieza
            // 
            this.Nro_Pieza.HeaderText = "Nro Pieza";
            this.Nro_Pieza.Name = "Nro_Pieza";
            // 
            // Nombre_de_Pieza
            // 
            this.Nombre_de_Pieza.HeaderText = "Nombre de Pieza";
            this.Nombre_de_Pieza.Name = "Nombre_de_Pieza";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(137, 434);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(119, 50);
            this.BTNAgregar.TabIndex = 6;
            this.BTNAgregar.Text = "Agregar a Carrito";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // BTNCarro
            // 
            this.BTNCarro.Location = new System.Drawing.Point(12, 434);
            this.BTNCarro.Name = "BTNCarro";
            this.BTNCarro.Size = new System.Drawing.Size(119, 50);
            this.BTNCarro.TabIndex = 7;
            this.BTNCarro.Text = "Ir a Carrito";
            this.BTNCarro.UseVisualStyleBackColor = true;
            this.BTNCarro.Click += new System.EventHandler(this.BTNCarro_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoria";
            // 
            // FRMListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTNCarro);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.DGVListado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CHKItem);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNBuscar);
            this.Name = "FRMListaVentas";
            this.Text = "Lista de Venta";
            this.Load += new System.EventHandler(this.FRMVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.CheckBox CHKItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNCarro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_INTERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_de_Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}

