﻿namespace WinGit_C
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
            this.bVerMensaje = new System.Windows.Forms.Button();
            this.bMensajes2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bVerMensaje
            // 
            this.bVerMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bVerMensaje.Location = new System.Drawing.Point(450, 172);
            this.bVerMensaje.Name = "bVerMensaje";
            this.bVerMensaje.Size = new System.Drawing.Size(268, 156);
            this.bVerMensaje.TabIndex = 0;
            this.bVerMensaje.Text = "VER MENSAJE";
            this.bVerMensaje.UseVisualStyleBackColor = false;
            this.bVerMensaje.Click += new System.EventHandler(this.bVerMensaje_Click);
            // 
            // bMensajes2
            // 
            this.bMensajes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bMensajes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMensajes2.Location = new System.Drawing.Point(30, 334);
            this.bMensajes2.Name = "bMensajes2";
            this.bMensajes2.Size = new System.Drawing.Size(424, 78);
            this.bMensajes2.TabIndex = 1;
            this.bMensajes2.Text = "VER MENSAJES 2";
            this.bMensajes2.UseVisualStyleBackColor = false;
            this.bMensajes2.Click += new System.EventHandler(this.BMensajes2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMensajes2);
            this.Controls.Add(this.bVerMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bVerMensaje;
        private System.Windows.Forms.Button bMensajes2;
    }
}

