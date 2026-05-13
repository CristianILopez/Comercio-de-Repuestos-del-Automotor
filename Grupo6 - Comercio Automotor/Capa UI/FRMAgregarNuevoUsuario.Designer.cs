namespace Capa_UI
{
    partial class FRMAgregarNuevoUsuario
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
            this.BTNAgregarPieza = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtIdInterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNModPieza = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNAgregarPieza
            // 
            this.BTNAgregarPieza.Location = new System.Drawing.Point(48, 369);
            this.BTNAgregarPieza.Name = "BTNAgregarPieza";
            this.BTNAgregarPieza.Size = new System.Drawing.Size(118, 45);
            this.BTNAgregarPieza.TabIndex = 56;
            this.BTNAgregarPieza.Text = "Agregar Usuario";
            this.BTNAgregarPieza.UseVisualStyleBackColor = true;
            this.BTNAgregarPieza.Click += new System.EventHandler(this.BTNAgregarPieza_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 20);
            this.textBox3.TabIndex = 49;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 20);
            this.textBox2.TabIndex = 48;
            // 
            // TxtIdInterno
            // 
            this.TxtIdInterno.Location = new System.Drawing.Point(138, 70);
            this.TxtIdInterno.Name = "TxtIdInterno";
            this.TxtIdInterno.Size = new System.Drawing.Size(288, 20);
            this.TxtIdInterno.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "DOCUMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "APELLIDO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "NOMBRE";
            // 
            // BTNModPieza
            // 
            this.BTNModPieza.Location = new System.Drawing.Point(48, 369);
            this.BTNModPieza.Name = "BTNModPieza";
            this.BTNModPieza.Size = new System.Drawing.Size(118, 45);
            this.BTNModPieza.TabIndex = 41;
            this.BTNModPieza.Text = "Confirmar Modificacion";
            this.BTNModPieza.UseVisualStyleBackColor = true;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(307, 369);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(119, 45);
            this.BTNSalir.TabIndex = 40;
            this.BTNSalir.Text = "Cancelar";
            this.BTNSalir.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "TELEFONO";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 266);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(288, 20);
            this.textBox4.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "MAIL";
            // 
            // FRMAgregarNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNAgregarPieza);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtIdInterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNModPieza);
            this.Controls.Add(this.BTNSalir);
            this.Name = "FRMAgregarNuevoUsuario";
            this.Text = "Agregar Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAgregarPieza;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtIdInterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNModPieza;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
    }
}