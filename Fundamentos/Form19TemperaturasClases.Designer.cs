namespace Fundamentos {
    partial class Form19TemperaturasClases {
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
            this.txtMed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMonths = new System.Windows.Forms.Button();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMed
            // 
            this.txtMed.Location = new System.Drawing.Point(294, 329);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(100, 29);
            this.txtMed.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperatura media";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(294, 227);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 29);
            this.txtMin.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temperatura mínima";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(294, 121);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 29);
            this.txtMax.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Temperatura máxima";
            // 
            // btnMonths
            // 
            this.btnMonths.Location = new System.Drawing.Point(251, 20);
            this.btnMonths.Name = "btnMonths";
            this.btnMonths.Size = new System.Drawing.Size(189, 37);
            this.btnMonths.TabIndex = 10;
            this.btnMonths.Text = "Generar Meses";
            this.btnMonths.UseVisualStyleBackColor = true;
            this.btnMonths.Click += new System.EventHandler(this.btnMonths_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 21;
            this.lstMeses.Location = new System.Drawing.Point(12, 12);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(212, 508);
            this.lstMeses.TabIndex = 9;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // Form19TemperaturasClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 529);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMonths);
            this.Controls.Add(this.lstMeses);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form19TemperaturasClases";
            this.Text = "Form19TemperaturasClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMed;
        private Label label3;
        private TextBox txtMin;
        private Label label2;
        private TextBox txtMax;
        private Label label1;
        private Button btnMonths;
        private ListBox lstMeses;
    }
}