namespace Adv_FinalProject
{
    partial class CreateOrder
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
            this.components = new System.ComponentModel.Container();
            this.ProdList_lbl = new System.Windows.Forms.Label();
            this.AddProduct_Btn = new System.Windows.Forms.Button();
            this.AddProducAmount_tbox = new System.Windows.Forms.TextBox();
            this.OrderName_lbl = new System.Windows.Forms.Label();
            this.OrderName_tbox = new System.Windows.Forms.TextBox();
            this.CreateOrder_Btn = new System.Windows.Forms.Button();
            this.CheckOutOrder_Btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.ViewCheck_Btn = new System.Windows.Forms.Button();
            this.Products_Dgv = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet3 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet3();
            this.productsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet3TableAdapters.ProductsTableAdapter();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GoBack_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdList_lbl
            // 
            this.ProdList_lbl.AutoSize = true;
            this.ProdList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdList_lbl.Location = new System.Drawing.Point(13, 13);
            this.ProdList_lbl.Name = "ProdList_lbl";
            this.ProdList_lbl.Size = new System.Drawing.Size(109, 20);
            this.ProdList_lbl.TabIndex = 1;
            this.ProdList_lbl.Text = "Products List";
            // 
            // AddProduct_Btn
            // 
            this.AddProduct_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProduct_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct_Btn.Location = new System.Drawing.Point(543, 229);
            this.AddProduct_Btn.Name = "AddProduct_Btn";
            this.AddProduct_Btn.Size = new System.Drawing.Size(245, 52);
            this.AddProduct_Btn.TabIndex = 2;
            this.AddProduct_Btn.Text = "Add Product";
            this.AddProduct_Btn.UseVisualStyleBackColor = true;
            this.AddProduct_Btn.Click += new System.EventHandler(this.AddProduct_Btn_Click);
            // 
            // AddProducAmount_tbox
            // 
            this.AddProducAmount_tbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.AddProducAmount_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducAmount_tbox.Location = new System.Drawing.Point(392, 243);
            this.AddProducAmount_tbox.Name = "AddProducAmount_tbox";
            this.AddProducAmount_tbox.Size = new System.Drawing.Size(127, 38);
            this.AddProducAmount_tbox.TabIndex = 3;
            this.AddProducAmount_tbox.Text = "0";
            // 
            // OrderName_lbl
            // 
            this.OrderName_lbl.AutoSize = true;
            this.OrderName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderName_lbl.Location = new System.Drawing.Point(7, 307);
            this.OrderName_lbl.Name = "OrderName_lbl";
            this.OrderName_lbl.Size = new System.Drawing.Size(101, 20);
            this.OrderName_lbl.TabIndex = 4;
            this.OrderName_lbl.Text = "Order Name";
            // 
            // OrderName_tbox
            // 
            this.OrderName_tbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.OrderName_tbox.Location = new System.Drawing.Point(115, 307);
            this.OrderName_tbox.Name = "OrderName_tbox";
            this.OrderName_tbox.Size = new System.Drawing.Size(421, 22);
            this.OrderName_tbox.TabIndex = 5;
            this.OrderName_tbox.Text = "-";
            // 
            // CreateOrder_Btn
            // 
            this.CreateOrder_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateOrder_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrder_Btn.Location = new System.Drawing.Point(542, 291);
            this.CreateOrder_Btn.Name = "CreateOrder_Btn";
            this.CreateOrder_Btn.Size = new System.Drawing.Size(245, 43);
            this.CreateOrder_Btn.TabIndex = 6;
            this.CreateOrder_Btn.Text = "Add Order";
            this.CreateOrder_Btn.UseVisualStyleBackColor = true;
            this.CreateOrder_Btn.Click += new System.EventHandler(this.CreateOrder_Btn_Click);
            // 
            // CheckOutOrder_Btn
            // 
            this.CheckOutOrder_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckOutOrder_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutOrder_Btn.Location = new System.Drawing.Point(11, 340);
            this.CheckOutOrder_Btn.Name = "CheckOutOrder_Btn";
            this.CheckOutOrder_Btn.Size = new System.Drawing.Size(776, 46);
            this.CheckOutOrder_Btn.TabIndex = 7;
            this.CheckOutOrder_Btn.Text = "Check Out Order";
            this.CheckOutOrder_Btn.UseVisualStyleBackColor = true;
            this.CheckOutOrder_Btn.Click += new System.EventHandler(this.CheckOutOrder_Btn_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(715, 9);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(73, 17);
            this.Username_lbl.TabIndex = 8;
            this.Username_lbl.Text = "Username";
            // 
            // ViewCheck_Btn
            // 
            this.ViewCheck_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewCheck_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCheck_Btn.Location = new System.Drawing.Point(12, 392);
            this.ViewCheck_Btn.Name = "ViewCheck_Btn";
            this.ViewCheck_Btn.Size = new System.Drawing.Size(776, 46);
            this.ViewCheck_Btn.TabIndex = 9;
            this.ViewCheck_Btn.Text = "View Check";
            this.ViewCheck_Btn.UseVisualStyleBackColor = true;
            this.ViewCheck_Btn.Click += new System.EventHandler(this.ViewCheck_Btn_Click);
            // 
            // Products_Dgv
            // 
            this.Products_Dgv.AllowUserToAddRows = false;
            this.Products_Dgv.AllowUserToDeleteRows = false;
            this.Products_Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_Dgv.AutoGenerateColumns = false;
            this.Products_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Products_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn});
            this.Products_Dgv.DataSource = this.productsBindingSource;
            this.Products_Dgv.Location = new System.Drawing.Point(12, 34);
            this.Products_Dgv.MultiSelect = false;
            this.Products_Dgv.Name = "Products_Dgv";
            this.Products_Dgv.RowHeadersWidth = 51;
            this.Products_Dgv.RowTemplate.Height = 24;
            this.Products_Dgv.Size = new System.Drawing.Size(775, 200);
            this.Products_Dgv.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Product_Manufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "Product_Manufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Price";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Product_Price";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "Product_Amount";
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "Product_Amount";
            this.productAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet3;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet3
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet3.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet3";
            this._FinalProjectDBContext_MyDbContextModelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 60000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GoBack_Btn
            // 
            this.GoBack_Btn.Location = new System.Drawing.Point(17, 444);
            this.GoBack_Btn.Name = "GoBack_Btn";
            this.GoBack_Btn.Size = new System.Drawing.Size(770, 54);
            this.GoBack_Btn.TabIndex = 10;
            this.GoBack_Btn.Text = "Go Back";
            this.GoBack_Btn.UseVisualStyleBackColor = true;
            this.GoBack_Btn.Click += new System.EventHandler(this.GoBack_Btn_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.GoBack_Btn);
            this.Controls.Add(this.Products_Dgv);
            this.Controls.Add(this.ViewCheck_Btn);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.CheckOutOrder_Btn);
            this.Controls.Add(this.CreateOrder_Btn);
            this.Controls.Add(this.OrderName_tbox);
            this.Controls.Add(this.OrderName_lbl);
            this.Controls.Add(this.AddProducAmount_tbox);
            this.Controls.Add(this.AddProduct_Btn);
            this.Controls.Add(this.ProdList_lbl);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Products_Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProdList_lbl;
        private System.Windows.Forms.Button AddProduct_Btn;
        private System.Windows.Forms.TextBox AddProducAmount_tbox;
        private System.Windows.Forms.Label OrderName_lbl;
        private System.Windows.Forms.TextBox OrderName_tbox;
        private System.Windows.Forms.Button CreateOrder_Btn;
        private System.Windows.Forms.Button CheckOutOrder_Btn;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Button ViewCheck_Btn;
        private System.Windows.Forms.DataGridView Products_Dgv;
        private _FinalProjectDBContext_MyDbContextModelDataSet3 _FinalProjectDBContext_MyDbContextModelDataSet3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet3TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button GoBack_Btn;
    }
}