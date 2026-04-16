namespace Capa_UI
{
    partial class FRMVendedor
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
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNCarro = new System.Windows.Forms.Button();
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
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(669, 434);
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
            this.CHKItem.Location = new System.Drawing.Point(664, 104);
            this.CHKItem.Name = "CHKItem";
            this.CHKItem.Size = new System.Drawing.Size(124, 17);
            this.CHKItem.TabIndex = 3;
            this.CHKItem.Text = "Pieza no encontrada";
            this.CHKItem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(646, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // DGVListado
            // 
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Location = new System.Drawing.Point(12, 142);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.Size = new System.Drawing.Size(776, 270);
            this.DGVListado.TabIndex = 5;
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(137, 434);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(119, 50);
            this.BTNAgregar.TabIndex = 6;
            this.BTNAgregar.Text = "Agregar a Carrito";
            this.BTNAgregar.UseVisualStyleBackColor = true;
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
            // FRMVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.BTNCarro);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.DGVListado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CHKItem);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNBuscar);
            this.Name = "FRMVendedor";
            this.Text = "Lista de Venta";
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
    }
}

