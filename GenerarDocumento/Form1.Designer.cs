namespace GenerarDocumento
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
            this.TXTtexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNword = new System.Windows.Forms.Button();
            this.BTNexcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTtexto
            // 
            this.TXTtexto.Location = new System.Drawing.Point(23, 35);
            this.TXTtexto.Multiline = true;
            this.TXTtexto.Name = "TXTtexto";
            this.TXTtexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTtexto.Size = new System.Drawing.Size(349, 231);
            this.TXTtexto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "GUARDAR DOCUMENTO";
            // 
            // BTNword
            // 
            this.BTNword.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNword.Location = new System.Drawing.Point(23, 283);
            this.BTNword.Name = "BTNword";
            this.BTNword.Size = new System.Drawing.Size(75, 39);
            this.BTNword.TabIndex = 7;
            this.BTNword.Text = "Word";
            this.BTNword.UseVisualStyleBackColor = true;
            this.BTNword.Click += new System.EventHandler(this.BTNword_Click);
            // 
            // BTNexcel
            // 
            this.BTNexcel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNexcel.Location = new System.Drawing.Point(297, 283);
            this.BTNexcel.Name = "BTNexcel";
            this.BTNexcel.Size = new System.Drawing.Size(75, 39);
            this.BTNexcel.TabIndex = 8;
            this.BTNexcel.Text = "Excel";
            this.BTNexcel.UseVisualStyleBackColor = true;
            this.BTNexcel.Click += new System.EventHandler(this.BTNexcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(390, 334);
            this.Controls.Add(this.BTNexcel);
            this.Controls.Add(this.BTNword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTtexto);
            this.Name = "Form1";
            this.Text = "Guardar Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTtexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNword;
        private System.Windows.Forms.Button BTNexcel;
    }
}

