namespace Fundamentos {
    partial class Form24ColeccionXMLMascotas {
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
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveDato = new System.Windows.Forms.Button();
            this.btnReadDato = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMascota = new System.Windows.Forms.Button();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(12, 160);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(45, 23);
            this.txtYears.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Años";
            // 
            // btnSaveDato
            // 
            this.btnSaveDato.Location = new System.Drawing.Point(243, 142);
            this.btnSaveDato.Name = "btnSaveDato";
            this.btnSaveDato.Size = new System.Drawing.Size(152, 34);
            this.btnSaveDato.TabIndex = 22;
            this.btnSaveDato.Text = "Guardar Registros";
            this.btnSaveDato.UseVisualStyleBackColor = true;
            // 
            // btnReadDato
            // 
            this.btnReadDato.Location = new System.Drawing.Point(243, 88);
            this.btnReadDato.Name = "btnReadDato";
            this.btnReadDato.Size = new System.Drawing.Size(152, 34);
            this.btnReadDato.TabIndex = 21;
            this.btnReadDato.Text = "Leer Registros";
            this.btnReadDato.UseVisualStyleBackColor = true;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 75);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(31, 15);
            this.lbl3.TabIndex = 20;
            this.lbl3.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(12, 99);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(210, 23);
            this.txtRaza.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 23);
            this.txtName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // btnNewMascota
            // 
            this.btnNewMascota.Location = new System.Drawing.Point(243, 33);
            this.btnNewMascota.Name = "btnNewMascota";
            this.btnNewMascota.Size = new System.Drawing.Size(152, 34);
            this.btnNewMascota.TabIndex = 25;
            this.btnNewMascota.Text = "Nueva Mascota";
            this.btnNewMascota.UseVisualStyleBackColor = true;
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Location = new System.Drawing.Point(413, 33);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(260, 229);
            this.lstMascotas.TabIndex = 26;
            // 
            // Form24ColeccionXMLMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 287);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.btnNewMascota);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveDato);
            this.Controls.Add(this.btnReadDato);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form24ColeccionXMLMascotas";
            this.Text = "Form24ColeccionXMLMascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtYears;
        private Label label2;
        private Button btnSaveDato;
        private Button btnReadDato;
        private Label lbl3;
        private TextBox txtRaza;
        private TextBox txtName;
        private Label label1;
        private Button btnNewMascota;
        private ListBox lstMascotas;
    }
}