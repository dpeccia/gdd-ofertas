﻿namespace FrbaOfertas.CambiarPassword
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordAnterior = new System.Windows.Forms.TextBox();
            this.passwordNueva = new System.Windows.Forms.TextBox();
            this.confirmar = new System.Windows.Forms.Button();
            this.errorPasswordAnterior = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPasswordNueva = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorPasswordAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPasswordNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña anterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva contraseña";
            // 
            // passwordAnterior
            // 
            this.passwordAnterior.Location = new System.Drawing.Point(139, 41);
            this.passwordAnterior.Name = "passwordAnterior";
            this.passwordAnterior.Size = new System.Drawing.Size(116, 20);
            this.passwordAnterior.TabIndex = 2;
            // 
            // passwordNueva
            // 
            this.passwordNueva.Location = new System.Drawing.Point(139, 74);
            this.passwordNueva.Name = "passwordNueva";
            this.passwordNueva.Size = new System.Drawing.Size(116, 20);
            this.passwordNueva.TabIndex = 3;
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(180, 107);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 4;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // errorPasswordAnterior
            // 
            this.errorPasswordAnterior.ContainerControl = this;
            // 
            // errorPasswordNueva
            // 
            this.errorPasswordNueva.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 147);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.passwordNueva);
            this.Controls.Add(this.passwordAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.passwordAnterior, 0);
            this.Controls.SetChildIndex(this.passwordNueva, 0);
            this.Controls.SetChildIndex(this.confirmar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorPasswordAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPasswordNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordAnterior;
        private System.Windows.Forms.TextBox passwordNueva;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.ErrorProvider errorPasswordAnterior;
        private System.Windows.Forms.ErrorProvider errorPasswordNueva;

    }
}