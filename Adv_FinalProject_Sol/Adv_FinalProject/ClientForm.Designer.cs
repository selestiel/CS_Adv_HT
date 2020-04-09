namespace Adv_FinalProject
{
    partial class ClientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet2 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet2();
            this.AddMoney_Btn = new System.Windows.Forms.Button();
            this.AddMoney_tbox = new System.Windows.Forms.TextBox();
            this.AddOrder_Btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UpdTable_Btn = new System.Windows.Forms.Button();
            this.GoBack_Btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet3TableAdapters.ProductsTableAdapter();
            this._FinalProjectDBContext_MyDbContextModelDataSet3 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet3();
            this.ordersTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet2TableAdapters.OrdersTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderNameDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(659, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNameDataGridViewTextBoxColumn
            // 
            this.orderNameDataGridViewTextBoxColumn.DataPropertyName = "Order_Name";
            this.orderNameDataGridViewTextBoxColumn.HeaderText = "Order_Name";
            this.orderNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "Order_Price";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "Order_Price";
            this.orderPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet2;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet2
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet2.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet2";
            this._FinalProjectDBContext_MyDbContextModelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddMoney_Btn
            // 
            this.AddMoney_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMoney_Btn.Location = new System.Drawing.Point(701, 60);
            this.AddMoney_Btn.Name = "AddMoney_Btn";
            this.AddMoney_Btn.Size = new System.Drawing.Size(126, 49);
            this.AddMoney_Btn.TabIndex = 1;
            this.AddMoney_Btn.Text = "Add Money";
            this.AddMoney_Btn.UseVisualStyleBackColor = true;
            this.AddMoney_Btn.Click += new System.EventHandler(this.AddMoney_Btn_Click);
            // 
            // AddMoney_tbox
            // 
            this.AddMoney_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMoney_tbox.Location = new System.Drawing.Point(701, 32);
            this.AddMoney_tbox.Name = "AddMoney_tbox";
            this.AddMoney_tbox.Size = new System.Drawing.Size(126, 22);
            this.AddMoney_tbox.TabIndex = 2;
            // 
            // AddOrder_Btn
            // 
            this.AddOrder_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrder_Btn.Location = new System.Drawing.Point(701, 115);
            this.AddOrder_Btn.Name = "AddOrder_Btn";
            this.AddOrder_Btn.Size = new System.Drawing.Size(126, 47);
            this.AddOrder_Btn.TabIndex = 3;
            this.AddOrder_Btn.Text = "Add Order";
            this.AddOrder_Btn.UseVisualStyleBackColor = true;
            this.AddOrder_Btn.Click += new System.EventHandler(this.AddOrder_Btn_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(698, 9);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(73, 17);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Username";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UpdTable_Btn
            // 
            this.UpdTable_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdTable_Btn.Location = new System.Drawing.Point(701, 168);
            this.UpdTable_Btn.Name = "UpdTable_Btn";
            this.UpdTable_Btn.Size = new System.Drawing.Size(126, 48);
            this.UpdTable_Btn.TabIndex = 6;
            this.UpdTable_Btn.Text = "Update Table";
            this.UpdTable_Btn.UseVisualStyleBackColor = true;
            this.UpdTable_Btn.Click += new System.EventHandler(this.UpdTable_Btn_Click);
            // 
            // GoBack_Btn
            // 
            this.GoBack_Btn.Location = new System.Drawing.Point(701, 232);
            this.GoBack_Btn.Name = "GoBack_Btn";
            this.GoBack_Btn.Size = new System.Drawing.Size(126, 60);
            this.GoBack_Btn.TabIndex = 7;
            this.GoBack_Btn.Text = "Go Back";
            this.GoBack_Btn.UseVisualStyleBackColor = true;
            this.GoBack_Btn.Click += new System.EventHandler(this.GoBack_Btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(659, 280);
            this.dataGridView2.TabIndex = 5;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet3
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet3.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet3";
            this._FinalProjectDBContext_MyDbContextModelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.Width = 101;
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
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataSource = typeof(Adv_FinalProject.Products);
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet3;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 580);
            this.Controls.Add(this.GoBack_Btn);
            this.Controls.Add(this.UpdTable_Btn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.AddOrder_Btn);
            this.Controls.Add(this.AddMoney_tbox);
            this.Controls.Add(this.AddMoney_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddMoney_Btn;
        private System.Windows.Forms.TextBox AddMoney_tbox;
        private System.Windows.Forms.Button AddOrder_Btn;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button UpdTable_Btn;
        private System.Windows.Forms.Button GoBack_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private _FinalProjectDBContext_MyDbContextModelDataSet2 _FinalProjectDBContext_MyDbContextModelDataSet2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet3TableAdapters.ProductsTableAdapter productsTableAdapter;
        private _FinalProjectDBContext_MyDbContextModelDataSet3 _FinalProjectDBContext_MyDbContextModelDataSet3;
        private _FinalProjectDBContext_MyDbContextModelDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource2;
    }
}