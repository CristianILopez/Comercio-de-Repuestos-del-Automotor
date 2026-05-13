namespace Capa_UI
{
    partial class UIEncStock
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
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BTNStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar Pieza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar Pieza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(157, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTNStock
            // 
            this.BTNStock.Location = new System.Drawing.Point(157, 270);
            this.BTNStock.Name = "BTNStock";
            this.BTNStock.Size = new System.Drawing.Size(123, 49);
            this.BTNStock.TabIndex = 5;
            this.BTNStock.Text = "Ver Stock";
            this.BTNStock.UseVisualStyleBackColor = true;
            this.BTNStock.Click += new System.EventHandler(this.BTNStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "SECCION DE ENCARGADO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UIEncStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNStock);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UIEncStock";
            this.Text = "Gestion de Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BTNStock;
        private System.Windows.Forms.Label label1;
    }
}