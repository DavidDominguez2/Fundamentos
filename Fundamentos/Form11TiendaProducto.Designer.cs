namespace Fundamentos {
    partial class Form11TiendaProducto {
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstShop = new System.Windows.Forms.ListBox();
            this.lstWarehouse = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(51, 89);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(158, 29);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tienda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Almacen";
            // 
            // lstShop
            // 
            this.lstShop.FormattingEnabled = true;
            this.lstShop.ItemHeight = 21;
            this.lstShop.Location = new System.Drawing.Point(262, 89);
            this.lstShop.Name = "lstShop";
            this.lstShop.Size = new System.Drawing.Size(120, 277);
            this.lstShop.TabIndex = 4;
            // 
            // lstWarehouse
            // 
            this.lstWarehouse.FormattingEnabled = true;
            this.lstWarehouse.ItemHeight = 21;
            this.lstWarehouse.Location = new System.Drawing.Point(499, 89);
            this.lstWarehouse.Name = "lstWarehouse";
            this.lstWarehouse.Size = new System.Drawing.Size(120, 277);
            this.lstWarehouse.TabIndex = 5;
            this.lstWarehouse.SelectedIndexChanged += new System.EventHandler(this.lstWarehouse_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(51, 141);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(158, 39);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(51, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(51, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(51, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 39);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpiar Lista";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(388, 130);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(105, 61);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Seleccion -->";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(388, 252);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(105, 61);
            this.btnAddAll.TabIndex = 11;
            this.btnAddAll.Text = "Todos -->";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(649, 130);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 35);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Subir";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(649, 203);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 35);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "Bajar";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // Form11TiendaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 405);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lstWarehouse);
            this.Controls.Add(this.lstShop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form11TiendaProducto";
            this.Text = "Form11TiendaProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtProduct;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstShop;
        private ListBox lstWarehouse;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnSelect;
        private Button btnAddAll;
        private Button btnUp;
        private Button btnDown;
    }
}