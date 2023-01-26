namespace ADO_Net {
    partial class Form03BuscadorEmpleados {
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
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchSalary = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchOffice = new System.Windows.Forms.Button();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 21;
            this.lstEmployees.Location = new System.Drawing.Point(26, 198);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(461, 277);
            this.lstEmployees.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empleados";
            // 
            // btnSearchSalary
            // 
            this.btnSearchSalary.Location = new System.Drawing.Point(273, 36);
            this.btnSearchSalary.Name = "btnSearchSalary";
            this.btnSearchSalary.Size = new System.Drawing.Size(214, 38);
            this.btnSearchSalary.TabIndex = 7;
            this.btnSearchSalary.Text = "Buscador";
            this.btnSearchSalary.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(26, 45);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(214, 29);
            this.txtSalary.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salario";
            // 
            // btnSearchOffice
            // 
            this.btnSearchOffice.Location = new System.Drawing.Point(273, 108);
            this.btnSearchOffice.Name = "btnSearchOffice";
            this.btnSearchOffice.Size = new System.Drawing.Size(214, 38);
            this.btnSearchOffice.TabIndex = 12;
            this.btnSearchOffice.Text = "Buscador";
            this.btnSearchOffice.UseVisualStyleBackColor = true;
            this.btnSearchOffice.Click += new System.EventHandler(this.btnSearchOffice_Click);
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(26, 117);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(214, 29);
            this.txtOffice.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oficio";
            // 
            // Form03BuscadorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 561);
            this.Controls.Add(this.btnSearchOffice);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form03BuscadorEmpleados";
            this.Text = "Form03BuscadorEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstEmployees;
        private Label label2;
        private Button btnSearchSalary;
        private TextBox txtSalary;
        private Label label1;
        private Button btnSearchOffice;
        private TextBox txtOffice;
        private Label label3;
    }
}