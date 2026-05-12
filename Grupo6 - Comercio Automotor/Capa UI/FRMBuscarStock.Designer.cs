namespace Capa_UI
{
    partial class FRMBuscarStock
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
            this.BTNCarro = new System.Windows.Forms.Button();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCarro
            // 
            this.BTNCarro.Location = new System.Drawing.Point(196, 366);
            this.BTNCarro.Name = "BTNCarro";
            this.BTNCarro.Size = new System.Drawing.Size(119, 50);
            this.BTNCarro.TabIndex = 14;
            this.BTNCarro.Text = "Eliminar";
            this.BTNCarro.UseVisualStyleBackColor = true;
            this.BTNCarro.Click += new System.EventHandler(this.BTNCarro_Click);
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(339, 366);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(119, 50);
            this.BTNAgregar.TabIndex = 13;
            this.BTNAgregar.Text = "Modificar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // DGVListado
            // 
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Location = new System.Drawing.Point(12, 74);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.Size = new System.Drawing.Size(776, 270);
            this.DGVListado.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(635, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(669, 366);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(119, 50);
            this.BTNCancelar.TabIndex = 9;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(669, 26);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(119, 34);
            this.BTNBuscar.TabIndex = 8;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            // 
            // FRMBuscarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCarro);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.DGVListado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNBuscar);
            this.Name = "FRMBuscarStock";
            this.Text = "Buscar En Stock";
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNCarro;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNBuscar;
    }
}