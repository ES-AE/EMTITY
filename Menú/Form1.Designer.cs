﻿namespace Menú
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
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecetas
            // 
            this.btnRecetas.Location = new System.Drawing.Point(78, 79);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(75, 23);
            this.btnRecetas.TabIndex = 0;
            this.btnRecetas.Text = "RECETAS";
            this.btnRecetas.UseVisualStyleBackColor = true;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // btnAnimales
            // 
            this.btnAnimales.Location = new System.Drawing.Point(179, 79);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(75, 23);
            this.btnAnimales.TabIndex = 1;
            this.btnAnimales.Text = "ANIMALES";
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(234, 162);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 197);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnimales);
            this.Controls.Add(this.btnRecetas);
            this.Name = "Form1";
            this.Text = "MENÚ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnSalir;
    }
}

