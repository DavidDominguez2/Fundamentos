namespace Fundamentos {
    partial class Form18PruebaClases {
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
            this.lstPersons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPersons
            // 
            this.lstPersons.FormattingEnabled = true;
            this.lstPersons.ItemHeight = 15;
            this.lstPersons.Location = new System.Drawing.Point(12, 47);
            this.lstPersons.Name = "lstPersons";
            this.lstPersons.Size = new System.Drawing.Size(604, 364);
            this.lstPersons.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(635, 47);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(153, 23);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "Ver persona";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // Form18PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPersons);
            this.Name = "Form18PruebaClases";
            this.Text = "Form18PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstPersons;
        private Label label1;
        private Button btnData;
    }
}