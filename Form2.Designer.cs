namespace PruebaEx16
{
    partial class Form2
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
            this.lblForm2Texto = new System.Windows.Forms.Label();
            this.lblForm2Título = new System.Windows.Forms.Label();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForm2Texto
            // 
            this.lblForm2Texto.AutoSize = true;
            this.lblForm2Texto.Location = new System.Drawing.Point(27, 196);
            this.lblForm2Texto.Name = "lblForm2Texto";
            this.lblForm2Texto.Size = new System.Drawing.Size(0, 16);
            this.lblForm2Texto.TabIndex = 1;
            // 
            // lblForm2Título
            // 
            this.lblForm2Título.AutoSize = true;
            this.lblForm2Título.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm2Título.Location = new System.Drawing.Point(25, 66);
            this.lblForm2Título.Name = "lblForm2Título";
            this.lblForm2Título.Size = new System.Drawing.Size(0, 25);
            this.lblForm2Título.TabIndex = 2;
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(69, 145);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(300, 25);
            this.btnForm2.TabIndex = 3;
            this.btnForm2.Text = "¡Apreta\'m i vorás a La Vila plorar!";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.lblForm2Título);
            this.Controls.Add(this.lblForm2Texto);
            this.Name = "Form2";
            this.Text = "Formulario 2 - Tonet S3ll4rd0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm2Texto;
        private System.Windows.Forms.Label lblForm2Título;
        private System.Windows.Forms.Button btnForm2;
    }
}