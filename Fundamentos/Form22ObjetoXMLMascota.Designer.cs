namespace Fundamentos {
    partial class Form22ObjetoXMLMascota {
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
            this.btnSaveDato = new System.Windows.Forms.Button();
            this.btnReadDato = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveDato
            // 
            this.btnSaveDato.Location = new System.Drawing.Point(243, 88);
            this.btnSaveDato.Name = "btnSaveDato";
            this.btnSaveDato.Size = new System.Drawing.Size(152, 34);
            this.btnSaveDato.TabIndex = 14;
            this.btnSaveDato.Text = "Guardar Dato";
            this.btnSaveDato.UseVisualStyleBackColor = true;
            this.btnSaveDato.Click += new System.EventHandler(this.btnSaveDato_Click);
            // 
            // btnReadDato
            // 
            this.btnReadDato.Location = new System.Drawing.Point(243, 22);
            this.btnReadDato.Name = "btnReadDato";
            this.btnReadDato.Size = new System.Drawing.Size(152, 34);
            this.btnReadDato.TabIndex = 13;
            this.btnReadDato.Text = "Leer Dato";
            this.btnReadDato.UseVisualStyleBackColor = true;
            this.btnReadDato.Click += new System.EventHandler(this.btnReadDato_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 75);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(31, 15);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(12, 99);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(210, 23);
            this.txtRaza.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 23);
            this.txtName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Años";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(12, 160);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(45, 23);
            this.txtYears.TabIndex = 16;
            // 
            // Form22ObjetoXMLMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 198);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveDato);
            this.Controls.Add(this.btnReadDato);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form22ObjetoXMLMascota";
            this.Text = "Form22ObjetoXMLMascota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSaveDato;
        private Button btnReadDato;
        private Label lbl3;
        private TextBox txtRaza;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtYears;
    }
}