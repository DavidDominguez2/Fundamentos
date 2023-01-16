namespace Fundamentos {
    partial class Form18TemperaturasAnuales {
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.btnMonths = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 21;
            this.lstMeses.Location = new System.Drawing.Point(21, 12);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(212, 508);
            this.lstMeses.TabIndex = 0;
            // 
            // btnMonths
            // 
            this.btnMonths.Location = new System.Drawing.Point(260, 20);
            this.btnMonths.Name = "btnMonths";
            this.btnMonths.Size = new System.Drawing.Size(189, 37);
            this.btnMonths.TabIndex = 1;
            this.btnMonths.Text = "Generar Meses";
            this.btnMonths.UseVisualStyleBackColor = true;
            this.btnMonths.Click += new System.EventHandler(this.btnMonths_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(260, 73);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(189, 37);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Mostrar Datos";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura máxima";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(301, 166);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 29);
            this.txtMax.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(301, 272);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 29);
            this.txtMin.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperatura mínima";
            // 
            // txtMed
            // 
            this.txtMed.Location = new System.Drawing.Point(301, 374);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(100, 29);
            this.txtMed.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperatura media";
            // 
            // Form18TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 553);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnMonths);
            this.Controls.Add(this.lstMeses);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form18TemperaturasAnuales";
            this.Text = "Form18TemperaturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstMeses;
        private Button btnMonths;
        private Button btnShow;
        private Label label1;
        private TextBox txtMax;
        private TextBox txtMin;
        private Label label2;
        private TextBox txtMed;
        private Label label3;
    }
}