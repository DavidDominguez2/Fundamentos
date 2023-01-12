namespace Fundamentos
{
    partial class Form04DateTime
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.chkChangeFormatDate = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbYears = new System.Windows.Forms.RadioButton();
            this.rdbMonths = new System.Windows.Forms.RadioButton();
            this.rdbDays = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(38, 86);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(720, 34);
            this.txtDate.TabIndex = 1;
            // 
            // chkChangeFormatDate
            // 
            this.chkChangeFormatDate.AutoSize = true;
            this.chkChangeFormatDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkChangeFormatDate.Location = new System.Drawing.Point(38, 140);
            this.chkChangeFormatDate.Name = "chkChangeFormatDate";
            this.chkChangeFormatDate.Size = new System.Drawing.Size(195, 25);
            this.chkChangeFormatDate.TabIndex = 2;
            this.chkChangeFormatDate.Text = "Cambiar Formato Fecha";
            this.chkChangeFormatDate.UseVisualStyleBackColor = true;
            this.chkChangeFormatDate.CheckedChanged += new System.EventHandler(this.chkChangeFormatDate_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncrement);
            this.groupBox1.Controls.Add(this.txtIncrement);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbYears);
            this.groupBox1.Controls.Add(this.rdbMonths);
            this.groupBox1.Controls.Add(this.rdbDays);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(38, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar Fecha";
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIncrement.Location = new System.Drawing.Point(167, 79);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(195, 40);
            this.btnIncrement.TabIndex = 5;
            this.btnIncrement.Text = "Incrementar";
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(262, 33);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 34);
            this.txtIncrement.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(167, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // rdbYears
            // 
            this.rdbYears.AutoSize = true;
            this.rdbYears.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbYears.Location = new System.Drawing.Point(6, 147);
            this.rdbYears.Name = "rdbYears";
            this.rdbYears.Size = new System.Drawing.Size(63, 25);
            this.rdbYears.TabIndex = 2;
            this.rdbYears.TabStop = true;
            this.rdbYears.Text = "Años";
            this.rdbYears.UseVisualStyleBackColor = true;
            // 
            // rdbMonths
            // 
            this.rdbMonths.AutoSize = true;
            this.rdbMonths.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMonths.Location = new System.Drawing.Point(6, 94);
            this.rdbMonths.Name = "rdbMonths";
            this.rdbMonths.Size = new System.Drawing.Size(72, 25);
            this.rdbMonths.TabIndex = 1;
            this.rdbMonths.TabStop = true;
            this.rdbMonths.Text = "Meses";
            this.rdbMonths.UseVisualStyleBackColor = true;
            // 
            // rdbDays
            // 
            this.rdbDays.AutoSize = true;
            this.rdbDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbDays.Location = new System.Drawing.Point(6, 46);
            this.rdbDays.Name = "rdbDays";
            this.rdbDays.Size = new System.Drawing.Size(58, 25);
            this.rdbDays.TabIndex = 0;
            this.rdbDays.TabStop = true;
            this.rdbDays.Text = "Dias";
            this.rdbDays.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva Fecha";
            // 
            // txtNewDate
            // 
            this.txtNewDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewDate.Location = new System.Drawing.Point(38, 445);
            this.txtNewDate.Name = "txtNewDate";
            this.txtNewDate.Size = new System.Drawing.Size(720, 34);
            this.txtNewDate.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 549);
            this.Controls.Add(this.txtNewDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkChangeFormatDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Name = "Form04DateTime";
            this.Text = "Form04DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDate;
        private CheckBox chkChangeFormatDate;
        private GroupBox groupBox1;
        private RadioButton rdbMonths;
        private RadioButton rdbDays;
        private RadioButton rdbYears;
        private Button btnIncrement;
        private TextBox txtIncrement;
        private Label label2;
        private Label label3;
        private TextBox txtNewDate;
    }
}