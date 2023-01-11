namespace Fundamentos
{
    partial class Form03AveriguaFecha
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnCalculateDate = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(89, 44);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(74, 23);
            this.txtDay.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(89, 86);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(74, 23);
            this.txtMonth.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(89, 125);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(74, 23);
            this.txtYear.TabIndex = 5;
            // 
            // btnCalculateDate
            // 
            this.btnCalculateDate.Location = new System.Drawing.Point(188, 68);
            this.btnCalculateDate.Name = "btnCalculateDate";
            this.btnCalculateDate.Size = new System.Drawing.Size(75, 56);
            this.btnCalculateDate.TabIndex = 6;
            this.btnCalculateDate.Text = "Calcular día";
            this.btnCalculateDate.UseVisualStyleBackColor = true;
            this.btnCalculateDate.Click += new System.EventHandler(this.btnCalculateDate_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(89, 177);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 15);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Dia de la semana:";
            // 
            // Form03AveriguaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnCalculateDate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form03AveriguaFecha";
            this.Text = "Form03AveriguaFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDay;
        private TextBox txtMonth;
        private TextBox txtYear;
        private Button btnCalculateDate;
        private Label lblDate;
    }
}