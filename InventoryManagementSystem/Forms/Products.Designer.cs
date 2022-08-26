namespace InventoryManagementSystem.Forms
{
    partial class Products
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcostprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colretailprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colproductname,
            this.colcode,
            this.colquantity,
            this.colcostprice,
            this.colretailprice,
            this.colreorder,
            this.colcategory,
            this.colEdit,
            this.colDelete});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(987, 479);
            this.dgvProduct.TabIndex = 3;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // colid
            // 
            this.colid.HeaderText = "ID";
            this.colid.MinimumWidth = 6;
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            // 
            // colproductname
            // 
            this.colproductname.HeaderText = "Name";
            this.colproductname.MinimumWidth = 6;
            this.colproductname.Name = "colproductname";
            this.colproductname.ReadOnly = true;
            // 
            // colcode
            // 
            this.colcode.HeaderText = "Product Code";
            this.colcode.MinimumWidth = 6;
            this.colcode.Name = "colcode";
            this.colcode.ReadOnly = true;
            // 
            // colquantity
            // 
            this.colquantity.HeaderText = "Quantity in Stock";
            this.colquantity.MinimumWidth = 6;
            this.colquantity.Name = "colquantity";
            this.colquantity.ReadOnly = true;
            // 
            // colcostprice
            // 
            this.colcostprice.HeaderText = "Cost Price";
            this.colcostprice.MinimumWidth = 6;
            this.colcostprice.Name = "colcostprice";
            this.colcostprice.ReadOnly = true;
            // 
            // colretailprice
            // 
            this.colretailprice.HeaderText = "Retail Price";
            this.colretailprice.MinimumWidth = 6;
            this.colretailprice.Name = "colretailprice";
            this.colretailprice.ReadOnly = true;
            // 
            // colreorder
            // 
            this.colreorder.HeaderText = "Re-order Level";
            this.colreorder.MinimumWidth = 6;
            this.colreorder.Name = "colreorder";
            this.colreorder.ReadOnly = true;
            // 
            // colcategory
            // 
            this.colcategory.HeaderText = "Category";
            this.colcategory.MinimumWidth = 6;
            this.colcategory.Name = "colcategory";
            this.colcategory.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEdit.HeaderText = "";
            this.colEdit.Image = global::InventoryManagementSystem.Properties.Resources.pencil;
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEdit.ToolTipText = "Edit Data";
            this.colEdit.Width = 40;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.HeaderText = "";
            this.colDelete.Image = global::InventoryManagementSystem.Properties.Resources.delete;
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDelete.ToolTipText = "Delete Data";
            this.colDelete.Width = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 60);
            this.panel1.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Image = global::InventoryManagementSystem.Properties.Resources.add;
            this.addBtn.Location = new System.Drawing.Point(917, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(70, 60);
            this.addBtn.TabIndex = 1;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 539);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProduct;
        private Panel panel1;
        private Button addBtn;
        private Label label1;
        private DataGridViewTextBoxColumn colid;
        private DataGridViewTextBoxColumn colproductname;
        private DataGridViewTextBoxColumn colcode;
        private DataGridViewTextBoxColumn colquantity;
        private DataGridViewTextBoxColumn colcostprice;
        private DataGridViewTextBoxColumn colretailprice;
        private DataGridViewTextBoxColumn colreorder;
        private DataGridViewTextBoxColumn colcategory;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}