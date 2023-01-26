namespace ADO_Net {
    partial class Form05UpdateSala {
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
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdateSala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas";
            // 
            // lstSalas
            // 
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.ItemHeight = 21;
            this.lstSalas.Location = new System.Drawing.Point(29, 51);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(170, 277);
            this.lstSalas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 29);
            this.txtName.TabIndex = 3;
            // 
            // btnUpdateSala
            // 
            this.btnUpdateSala.Location = new System.Drawing.Point(226, 187);
            this.btnUpdateSala.Name = "btnUpdateSala";
            this.btnUpdateSala.Size = new System.Drawing.Size(176, 41);
            this.btnUpdateSala.TabIndex = 4;
            this.btnUpdateSala.Text = "Modificar Salas";
            this.btnUpdateSala.UseVisualStyleBackColor = true;
            this.btnUpdateSala.Click += new System.EventHandler(this.btnUpdateSala_Click);
            // 
            // Form05UpdateSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 365);
            this.Controls.Add(this.btnUpdateSala);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSalas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form05UpdateSala";
            this.Text = "Form05UpdateSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstSalas;
        private Label label2;
        private TextBox txtName;
        private Button btnUpdateSala;
    }
}