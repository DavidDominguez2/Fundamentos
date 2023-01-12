namespace Fundamentos {
    partial class Form08ColeccionGrafica {
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
            this.txtElement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lstElements = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elementos";
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(327, 92);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(169, 29);
            this.txtElement.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevos elementos";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsert.Location = new System.Drawing.Point(327, 127);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(169, 35);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(327, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Location = new System.Drawing.Point(327, 236);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(169, 35);
            this.btnDeleteAll.TabIndex = 6;
            this.btnDeleteAll.Text = "Borrar Todo";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(72, 355);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(68, 21);
            this.lblIndice.TabIndex = 7;
            this.lblIndice.Text = "lblIndice";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(72, 389);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(58, 21);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "lblItem";
            // 
            // lstElements
            // 
            this.lstElements.FormattingEnabled = true;
            this.lstElements.ItemHeight = 21;
            this.lstElements.Location = new System.Drawing.Point(67, 78);
            this.lstElements.Name = "lstElements";
            this.lstElements.Size = new System.Drawing.Size(163, 214);
            this.lstElements.TabIndex = 9;
            this.lstElements.SelectedIndexChanged += new System.EventHandler(this.lstElements_SelectedIndexChanged);
            // 
            // Form08ColeccionGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 428);
            this.Controls.Add(this.lstElements);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form08ColeccionGrafica";
            this.Text = "Form08ColeccionGrafica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtElement;
        private Label label2;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Label lblIndice;
        private Label lblItem;
        private ListBox lstElements;
    }
}