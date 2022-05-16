namespace PruebaEx16
{
    partial class Form1
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
            this.btnForm1 = new System.Windows.Forms.Button();
            this.textBoxForm1 = new System.Windows.Forms.TextBox();
            this.lblForm1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(174, 95);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(75, 23);
            this.btnForm1.TabIndex = 0;
            this.btnForm1.Text = "button1";
            this.btnForm1.UseVisualStyleBackColor = true;
            // 
            // textBoxForm1
            // 
            this.textBoxForm1.Location = new System.Drawing.Point(160, 30);
            this.textBoxForm1.Name = "textBoxForm1";
            this.textBoxForm1.Size = new System.Drawing.Size(100, 22);
            this.textBoxForm1.TabIndex = 1;
            // 
            // lblForm1
            // 
            this.lblForm1.AutoSize = true;
            this.lblForm1.Location = new System.Drawing.Point(190, 157);
            this.lblForm1.Name = "lblForm1";
            this.lblForm1.Size = new System.Drawing.Size(44, 16);
            this.lblForm1.TabIndex = 2;
            this.lblForm1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.lblForm1);
            this.Controls.Add(this.textBoxForm1);
            this.Controls.Add(this.btnForm1);
            this.Name = "Form1";
            this.Text = "Formulario Antonio Nicolás Salmerón Rubio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.TextBox textBoxForm1;
        private System.Windows.Forms.Label lblForm1;
    }
}

