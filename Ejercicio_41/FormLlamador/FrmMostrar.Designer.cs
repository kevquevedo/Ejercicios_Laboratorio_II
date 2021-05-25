namespace Formularios
{
    partial class FrmMostrar
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
            this.rtbInfoLlamadas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbInfoLlamadas
            // 
            this.rtbInfoLlamadas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfoLlamadas.Location = new System.Drawing.Point(26, 24);
            this.rtbInfoLlamadas.Name = "rtbInfoLlamadas";
            this.rtbInfoLlamadas.Size = new System.Drawing.Size(489, 309);
            this.rtbInfoLlamadas.TabIndex = 0;
            this.rtbInfoLlamadas.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 359);
            this.Controls.Add(this.rtbInfoLlamadas);
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion de Llamadas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInfoLlamadas;
    }
}