﻿namespace Formularios
{
    partial class FrmMenu
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
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFactTotal = new System.Windows.Forms.Button();
            this.btnFactLocal = new System.Windows.Forms.Button();
            this.btnFactProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarLlamada.Location = new System.Drawing.Point(26, 21);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(270, 38);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // btnFactTotal
            // 
            this.btnFactTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactTotal.Location = new System.Drawing.Point(26, 77);
            this.btnFactTotal.Name = "btnFactTotal";
            this.btnFactTotal.Size = new System.Drawing.Size(270, 38);
            this.btnFactTotal.TabIndex = 1;
            this.btnFactTotal.Text = "Facturación Total";
            this.btnFactTotal.UseVisualStyleBackColor = true;
            this.btnFactTotal.Click += new System.EventHandler(this.btnFactTotal_Click);
            // 
            // btnFactLocal
            // 
            this.btnFactLocal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactLocal.Location = new System.Drawing.Point(26, 137);
            this.btnFactLocal.Name = "btnFactLocal";
            this.btnFactLocal.Size = new System.Drawing.Size(270, 38);
            this.btnFactLocal.TabIndex = 2;
            this.btnFactLocal.Text = "Facturación Local";
            this.btnFactLocal.UseVisualStyleBackColor = true;
            this.btnFactLocal.Click += new System.EventHandler(this.btnFactLocal_Click);
            // 
            // btnFactProvincial
            // 
            this.btnFactProvincial.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactProvincial.Location = new System.Drawing.Point(26, 193);
            this.btnFactProvincial.Name = "btnFactProvincial";
            this.btnFactProvincial.Size = new System.Drawing.Size(270, 38);
            this.btnFactProvincial.TabIndex = 3;
            this.btnFactProvincial.Text = "Facturación Provincial";
            this.btnFactProvincial.UseVisualStyleBackColor = true;
            this.btnFactProvincial.Click += new System.EventHandler(this.btnFactProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(26, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(270, 38);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 318);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFactProvincial);
            this.Controls.Add(this.btnFactLocal);
            this.Controls.Add(this.btnFactTotal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefónica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFactTotal;
        private System.Windows.Forms.Button btnFactLocal;
        private System.Windows.Forms.Button btnFactProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

