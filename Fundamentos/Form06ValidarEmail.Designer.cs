namespace Fundamentos
{
    partial class Form06ValidarEmail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(364, 34);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca su Email para poder validarlo";
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.LightGreen;
            this.btnValidate.Location = new System.Drawing.Point(121, 118);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(208, 38);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validar";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(49, 181);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(84, 28);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Mensaje";
            // 
            // Form06ValidarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 303);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form06ValidarEmail";
            this.Text = "Form06ValidarEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Button btnValidate;
        private Label lblMessage;
    }
}