namespace Fundamentos {
    partial class Form21Mascotas {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnNewRegister = new System.Windows.Forms.Button();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.btnSaveRegister = new System.Windows.Forms.Button();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(12, 106);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(210, 29);
            this.txtRaza.TabIndex = 2;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 82);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(43, 21);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Raza";
            // 
            // btnNewRegister
            // 
            this.btnNewRegister.Location = new System.Drawing.Point(22, 161);
            this.btnNewRegister.Name = "btnNewRegister";
            this.btnNewRegister.Size = new System.Drawing.Size(191, 34);
            this.btnNewRegister.TabIndex = 4;
            this.btnNewRegister.Text = "Nuevo Registro";
            this.btnNewRegister.UseVisualStyleBackColor = true;
            this.btnNewRegister.Click += new System.EventHandler(this.btnNewRegister_Click);
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.Location = new System.Drawing.Point(22, 218);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(191, 34);
            this.btnReadRegister.TabIndex = 5;
            this.btnReadRegister.Text = "Leer Registro";
            this.btnReadRegister.UseVisualStyleBackColor = true;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // btnSaveRegister
            // 
            this.btnSaveRegister.Location = new System.Drawing.Point(22, 274);
            this.btnSaveRegister.Name = "btnSaveRegister";
            this.btnSaveRegister.Size = new System.Drawing.Size(191, 34);
            this.btnSaveRegister.TabIndex = 6;
            this.btnSaveRegister.Text = "Guardar Registros";
            this.btnSaveRegister.UseVisualStyleBackColor = true;
            this.btnSaveRegister.Click += new System.EventHandler(this.btnSaveRegister_Click);
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 21;
            this.lstMascotas.Location = new System.Drawing.Point(260, 33);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(260, 277);
            this.lstMascotas.TabIndex = 7;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // Form21Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 532);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.btnSaveRegister);
            this.Controls.Add(this.btnReadRegister);
            this.Controls.Add(this.btnNewRegister);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form21Mascotas";
            this.Text = "Form21Mascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtRaza;
        private Label lbl3;
        private Button btnNewRegister;
        private Button btnReadRegister;
        private Button btnSaveRegister;
        private ListBox lstMascotas;
    }
}