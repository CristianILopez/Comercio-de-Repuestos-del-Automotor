namespace Capa_UI
{
    partial class UIAdminSistema
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.BTNbuscarPieza = new System.Windows.Forms.Button();
            this.BTNPedido = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "SECCION DE SISTEMAS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 68);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir del sistema";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNbuscarPieza
            // 
            this.BTNbuscarPieza.Location = new System.Drawing.Point(143, 197);
            this.BTNbuscarPieza.Name = "BTNbuscarPieza";
            this.BTNbuscarPieza.Size = new System.Drawing.Size(163, 68);
            this.BTNbuscarPieza.TabIndex = 6;
            this.BTNbuscarPieza.Text = "Buscar Usuario";
            this.BTNbuscarPieza.UseVisualStyleBackColor = true;
            this.BTNbuscarPieza.Click += new System.EventHandler(this.BTNbuscarPieza_Click);
            // 
            // BTNPedido
            // 
            this.BTNPedido.Location = new System.Drawing.Point(143, 123);
            this.BTNPedido.Name = "BTNPedido";
            this.BTNPedido.Size = new System.Drawing.Size(163, 68);
            this.BTNPedido.TabIndex = 5;
            this.BTNPedido.Text = "Agregar Nuevo Usuario";
            this.BTNPedido.UseVisualStyleBackColor = true;
            this.BTNPedido.Click += new System.EventHandler(this.BTNPedido_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generar Reportes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UIAdminSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTNbuscarPieza);
            this.Controls.Add(this.BTNPedido);
            this.Name = "UIAdminSistema";
            this.Text = "UIAdminSistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTNbuscarPieza;
        private System.Windows.Forms.Button BTNPedido;
        private System.Windows.Forms.Button button1;
    }
}