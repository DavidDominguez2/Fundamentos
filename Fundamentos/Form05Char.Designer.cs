﻿namespace Fundamentos
{
    partial class Form05Char
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSimbolos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnASCII = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(54, 65);
            this.txtLetras.Multiline = true;
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(198, 162);
            this.txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(345, 65);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(198, 162);
            this.txtNumeros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Números";
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.Location = new System.Drawing.Point(54, 309);
            this.txtSimbolos.Multiline = true;
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.Size = new System.Drawing.Size(198, 162);
            this.txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(345, 309);
            this.txtPuntuacion.Multiline = true;
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(198, 162);
            this.txtPuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuación";
            // 
            // btnASCII
            // 
            this.btnASCII.Location = new System.Drawing.Point(188, 496);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(249, 47);
            this.btnASCII.TabIndex = 8;
            this.btnASCII.Text = "Recorrer ASCII";
            this.btnASCII.UseVisualStyleBackColor = true;
            this.btnASCII.Click += new System.EventHandler(this.btnASCII_Click);
            // 
            // Form05Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 588);
            this.Controls.Add(this.btnASCII);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSimbolos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form05Char";
            this.Text = "Form05Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label label2;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtPuntuacion;
        private Label label4;
        private Button btnASCII;
    }
}