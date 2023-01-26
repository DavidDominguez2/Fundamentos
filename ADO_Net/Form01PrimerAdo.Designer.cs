namespace ADO_Net {
    partial class Form01PrimerAdo {
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstDataTypes = new System.Windows.Forms.ListBox();
            this.lstColumns = new System.Windows.Forms.ListBox();
            this.lstApellidos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadData = new System.Windows.Forms.Button();
            this.btnDisconect = new System.Windows.Forms.Button();
            this.btnConect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(30, 351);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(68, 21);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.Text = "Mensaje";
            // 
            // lstDataTypes
            // 
            this.lstDataTypes.FormattingEnabled = true;
            this.lstDataTypes.ItemHeight = 21;
            this.lstDataTypes.Location = new System.Drawing.Point(638, 59);
            this.lstDataTypes.Name = "lstDataTypes";
            this.lstDataTypes.Size = new System.Drawing.Size(169, 256);
            this.lstDataTypes.TabIndex = 18;
            // 
            // lstColumns
            // 
            this.lstColumns.FormattingEnabled = true;
            this.lstColumns.ItemHeight = 21;
            this.lstColumns.Location = new System.Drawing.Point(422, 59);
            this.lstColumns.Name = "lstColumns";
            this.lstColumns.Size = new System.Drawing.Size(169, 256);
            this.lstColumns.TabIndex = 17;
            // 
            // lstApellidos
            // 
            this.lstApellidos.FormattingEnabled = true;
            this.lstApellidos.ItemHeight = 21;
            this.lstApellidos.Location = new System.Drawing.Point(205, 59);
            this.lstApellidos.Name = "lstApellidos";
            this.lstApellidos.Size = new System.Drawing.Size(169, 256);
            this.lstApellidos.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipos dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Columnas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Apellidos";
            // 
            // btnReadData
            // 
            this.btnReadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReadData.Location = new System.Drawing.Point(30, 169);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(148, 35);
            this.btnReadData.TabIndex = 12;
            this.btnReadData.Text = "Leer Datos";
            this.btnReadData.UseVisualStyleBackColor = false;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnDisconect
            // 
            this.btnDisconect.BackColor = System.Drawing.Color.Red;
            this.btnDisconect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisconect.ForeColor = System.Drawing.Color.White;
            this.btnDisconect.Location = new System.Drawing.Point(30, 113);
            this.btnDisconect.Name = "btnDisconect";
            this.btnDisconect.Size = new System.Drawing.Size(148, 35);
            this.btnDisconect.TabIndex = 11;
            this.btnDisconect.Text = "Desconectar";
            this.btnDisconect.UseVisualStyleBackColor = false;
            this.btnDisconect.Click += new System.EventHandler(this.btnDisconect_Click);
            // 
            // btnConect
            // 
            this.btnConect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConect.Location = new System.Drawing.Point(30, 59);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(148, 35);
            this.btnConect.TabIndex = 10;
            this.btnConect.Text = "Conectar";
            this.btnConect.UseVisualStyleBackColor = false;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // Form01PrimerAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 391);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstDataTypes);
            this.Controls.Add(this.lstColumns);
            this.Controls.Add(this.lstApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.btnDisconect);
            this.Controls.Add(this.btnConect);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form01PrimerAdo";
            this.Text = "Form01PrimerAdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMessage;
        private ListBox lstDataTypes;
        private ListBox lstColumns;
        private ListBox lstApellidos;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnReadData;
        private Button btnDisconect;
        private Button btnConect;
    }
}