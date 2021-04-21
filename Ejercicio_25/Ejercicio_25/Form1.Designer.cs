namespace Ejercicio_25
{
    partial class Conversor_Numerico
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
            this.txtBin = new System.Windows.Forms.TextBox();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.lblBinADec = new System.Windows.Forms.Label();
            this.lblDecABin = new System.Windows.Forms.Label();
            this.btnConvertBinADec = new System.Windows.Forms.Button();
            this.btnConvertDecABin = new System.Windows.Forms.Button();
            this.txtDecABin = new System.Windows.Forms.TextBox();
            this.txtBinADec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBin
            // 
            this.txtBin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBin.Location = new System.Drawing.Point(268, 84);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(141, 33);
            this.txtBin.TabIndex = 0;
            this.txtBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBin.TextChanged += new System.EventHandler(this.txtBin_TextChanged);
            // 
            // txtDec
            // 
            this.txtDec.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDec.Location = new System.Drawing.Point(268, 128);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(141, 33);
            this.txtDec.TabIndex = 1;
            this.txtDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDec.TextChanged += new System.EventHandler(this.txtDec_TextChanged);
            // 
            // lblBinADec
            // 
            this.lblBinADec.AutoSize = true;
            this.lblBinADec.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinADec.Location = new System.Drawing.Point(27, 84);
            this.lblBinADec.Name = "lblBinADec";
            this.lblBinADec.Size = new System.Drawing.Size(219, 28);
            this.lblBinADec.TabIndex = 2;
            this.lblBinADec.Text = "Binario a Decimal";
            this.lblBinADec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDecABin
            // 
            this.lblDecABin.AutoSize = true;
            this.lblDecABin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecABin.Location = new System.Drawing.Point(30, 128);
            this.lblDecABin.Name = "lblDecABin";
            this.lblDecABin.Size = new System.Drawing.Size(219, 28);
            this.lblDecABin.TabIndex = 3;
            this.lblDecABin.Text = "Decimal a Binario";
            this.lblDecABin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvertBinADec
            // 
            this.btnConvertBinADec.FlatAppearance.BorderSize = 3;
            this.btnConvertBinADec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertBinADec.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertBinADec.Location = new System.Drawing.Point(428, 84);
            this.btnConvertBinADec.Name = "btnConvertBinADec";
            this.btnConvertBinADec.Size = new System.Drawing.Size(142, 33);
            this.btnConvertBinADec.TabIndex = 4;
            this.btnConvertBinADec.Text = "-->";
            this.btnConvertBinADec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConvertBinADec.UseVisualStyleBackColor = true;
            this.btnConvertBinADec.Click += new System.EventHandler(this.btnConvertBinADec_Click);
            // 
            // btnConvertDecABin
            // 
            this.btnConvertDecABin.FlatAppearance.BorderSize = 3;
            this.btnConvertDecABin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertDecABin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDecABin.Location = new System.Drawing.Point(428, 128);
            this.btnConvertDecABin.Name = "btnConvertDecABin";
            this.btnConvertDecABin.Size = new System.Drawing.Size(142, 33);
            this.btnConvertDecABin.TabIndex = 5;
            this.btnConvertDecABin.Text = "-->";
            this.btnConvertDecABin.UseVisualStyleBackColor = true;
            this.btnConvertDecABin.Click += new System.EventHandler(this.btnConvertDecABin_Click);
            // 
            // txtDecABin
            // 
            this.txtDecABin.Enabled = false;
            this.txtDecABin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecABin.Location = new System.Drawing.Point(587, 131);
            this.txtDecABin.Name = "txtDecABin";
            this.txtDecABin.Size = new System.Drawing.Size(201, 33);
            this.txtDecABin.TabIndex = 6;
            this.txtDecABin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBinADec
            // 
            this.txtBinADec.Enabled = false;
            this.txtBinADec.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinADec.Location = new System.Drawing.Point(587, 84);
            this.txtBinADec.Name = "txtBinADec";
            this.txtBinADec.Size = new System.Drawing.Size(201, 33);
            this.txtBinADec.TabIndex = 7;
            this.txtBinADec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Conversor_Numerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.txtBinADec);
            this.Controls.Add(this.txtDecABin);
            this.Controls.Add(this.btnConvertDecABin);
            this.Controls.Add(this.btnConvertBinADec);
            this.Controls.Add(this.lblDecABin);
            this.Controls.Add(this.lblBinADec);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.txtBin);
            this.Name = "Conversor_Numerico";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.Label lblBinADec;
        private System.Windows.Forms.Label lblDecABin;
        private System.Windows.Forms.Button btnConvertBinADec;
        private System.Windows.Forms.Button btnConvertDecABin;
        private System.Windows.Forms.TextBox txtDecABin;
        private System.Windows.Forms.TextBox txtBinADec;
    }
}

