namespace Fundamentos
{
    partial class Form02ColoresPosicion
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
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.lblPositionX = new System.Windows.Forms.Label();
            this.lblPositionY = new System.Windows.Forms.Label();
            this.txtPositionX = new System.Windows.Forms.TextBox();
            this.txtPositionY = new System.Windows.Forms.TextBox();
            this.btnChangePosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(44, 46);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(31, 15);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Rojo";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(125, 46);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 15);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "Verde";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(214, 46);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(30, 15);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Azul";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(78, 106);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(127, 23);
            this.btnChangeColor.TabIndex = 3;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(30, 64);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(63, 23);
            this.txtRed.TabIndex = 4;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(110, 64);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(63, 23);
            this.txtGreen.TabIndex = 5;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(197, 64);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(63, 23);
            this.txtBlue.TabIndex = 6;
            // 
            // lblPositionX
            // 
            this.lblPositionX.AutoSize = true;
            this.lblPositionX.Location = new System.Drawing.Point(33, 192);
            this.lblPositionX.Name = "lblPositionX";
            this.lblPositionX.Size = new System.Drawing.Size(60, 15);
            this.lblPositionX.TabIndex = 7;
            this.lblPositionX.Text = "Position X";
            // 
            // lblPositionY
            // 
            this.lblPositionY.AutoSize = true;
            this.lblPositionY.Location = new System.Drawing.Point(144, 192);
            this.lblPositionY.Name = "lblPositionY";
            this.lblPositionY.Size = new System.Drawing.Size(60, 15);
            this.lblPositionY.TabIndex = 8;
            this.lblPositionY.Text = "Position Y";
            // 
            // txtPositionX
            // 
            this.txtPositionX.Location = new System.Drawing.Point(12, 210);
            this.txtPositionX.Name = "txtPositionX";
            this.txtPositionX.Size = new System.Drawing.Size(100, 23);
            this.txtPositionX.TabIndex = 9;
            // 
            // txtPositionY
            // 
            this.txtPositionY.Location = new System.Drawing.Point(125, 210);
            this.txtPositionY.Name = "txtPositionY";
            this.txtPositionY.Size = new System.Drawing.Size(100, 23);
            this.txtPositionY.TabIndex = 10;
            // 
            // btnChangePosition
            // 
            this.btnChangePosition.ForeColor = System.Drawing.Color.Black;
            this.btnChangePosition.Location = new System.Drawing.Point(66, 252);
            this.btnChangePosition.Name = "btnChangePosition";
            this.btnChangePosition.Size = new System.Drawing.Size(116, 23);
            this.btnChangePosition.TabIndex = 11;
            this.btnChangePosition.Text = "New Position";
            this.btnChangePosition.UseVisualStyleBackColor = true;
            this.btnChangePosition.Click += new System.EventHandler(this.btnChangePosition_Click);
            // 
            // Form02ColoresPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangePosition);
            this.Controls.Add(this.txtPositionY);
            this.Controls.Add(this.txtPositionX);
            this.Controls.Add(this.lblPositionY);
            this.Controls.Add(this.lblPositionX);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form02ColoresPosicion";
            this.Text = "Form02ColoresPosicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Button btnChangeColor;
        private TextBox txtRed;
        private TextBox txtGreen;
        private TextBox txtBlue;
        private Label lblPositionX;
        private Label lblPositionY;
        private TextBox txtPositionX;
        private TextBox txtPositionY;
        private Button btnChangePosition;
    }
}