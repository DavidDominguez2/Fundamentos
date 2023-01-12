namespace Fundamentos {
    partial class Form10ColeccionNumeros {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtPar = new System.Windows.Forms.TextBox();
            this.txtImpar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 15;
            this.lstNumbers.Location = new System.Drawing.Point(22, 77);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 169);
            this.lstNumbers.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(22, 59);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(56, 15);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Números";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Impares";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(173, 77);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(271, 77);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(115, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Mostrar Datos";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(224, 126);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(42, 23);
            this.txtSum.TabIndex = 7;
            // 
            // txtPar
            // 
            this.txtPar.Location = new System.Drawing.Point(224, 169);
            this.txtPar.Name = "txtPar";
            this.txtPar.Size = new System.Drawing.Size(42, 23);
            this.txtPar.TabIndex = 8;
            // 
            // txtImpar
            // 
            this.txtImpar.Location = new System.Drawing.Point(224, 204);
            this.txtImpar.Name = "txtImpar";
            this.txtImpar.Size = new System.Drawing.Size(42, 23);
            this.txtImpar.TabIndex = 9;
            // 
            // Form10ColeccionNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.txtImpar);
            this.Controls.Add(this.txtPar);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lstNumbers);
            this.Name = "Form10ColeccionNumeros";
            this.Text = "Form10ColeccionNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstNumbers;
        private Label lblText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGenerate;
        private Button btnShow;
        private TextBox txtSum;
        private TextBox txtPar;
        private TextBox txtImpar;
    }
}