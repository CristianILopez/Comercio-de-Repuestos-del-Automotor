namespace Capa_UI
{
    partial class FRMBuscarUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.BTNAgregarProv = new System.Windows.Forms.Button();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 34;
            this.button1.Text = "Modificar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNAgregarProv
            // 
            this.BTNAgregarProv.Location = new System.Drawing.Point(29, 370);
            this.BTNAgregarProv.Name = "BTNAgregarProv";
            this.BTNAgregarProv.Size = new System.Drawing.Size(119, 50);
            this.BTNAgregarProv.TabIndex = 33;
            this.BTNAgregarProv.Text = "Eliminar Usuario";
            this.BTNAgregarProv.UseVisualStyleBackColor = true;
            this.BTNAgregarProv.Click += new System.EventHandler(this.BTNAgregarProv_Click);
            // 
            // DGVListado
            // 
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Location = new System.Drawing.Point(29, 92);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.Size = new System.Drawing.Size(776, 256);
            this.DGVListado.TabIndex = 32;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(686, 370);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(119, 50);
            this.BTNCancelar.TabIndex = 30;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(686, 30);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(119, 34);
            this.BTNBuscar.TabIndex = 29;
            this.BTNBuscar.Text = "Buscar Usuario";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(639, 32);
            this.textBox1.TabIndex = 35;
            // 
            // FRMBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNAgregarProv);
            this.Controls.Add(this.DGVListado);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNBuscar);
            this.Name = "FRMBuscarUsuario";
            this.Text = "FRMBuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNAgregarProv;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.TextBox textBox1;
    }
}