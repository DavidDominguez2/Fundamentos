namespace Fundamentos {
    partial class Form12Metodos {
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnObjectRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(110, 38);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(95, 29);
            this.txtNum.TabIndex = 1;
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(36, 91);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(169, 32);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "Doble() Valor";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(36, 144);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(169, 32);
            this.btnRef.TabIndex = 3;
            this.btnRef.Text = "Doble() Referencia";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(36, 280);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 21);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnObjectRef
            // 
            this.btnObjectRef.Location = new System.Drawing.Point(36, 201);
            this.btnObjectRef.Name = "btnObjectRef";
            this.btnObjectRef.Size = new System.Drawing.Size(169, 32);
            this.btnObjectRef.TabIndex = 5;
            this.btnObjectRef.Text = "Objeto Referencia";
            this.btnObjectRef.UseVisualStyleBackColor = true;
            this.btnObjectRef.Click += new System.EventHandler(this.btnObjectRef_Click);
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 395);
            this.Controls.Add(this.btnObjectRef);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnDouble;
        private Button btnRef;
        private Label lblResultado;
        private Button btnObjectRef;
    }
}