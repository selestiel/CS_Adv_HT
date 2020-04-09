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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet();
            this.AddMoney_Btn = new System.Windows.Forms.Button();
            this.AddMoney_tbox = new System.Windows.Forms.TextBox();
            this.AddOrder_Btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet1 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet1();
            this.ordersTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSetTableAdapters.OrdersTableAdapter();
            this.productsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet1TableAdapters.ProductsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UpdTable_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet1)).BeginInit();
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(659, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Order_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Order_Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order_Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Order_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Order_Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Client_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Client_ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet";
            this._FinalProjectDBContext_MyDbContextModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(659, 280);
            this.dataGridView2.TabIndex = 5;
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
            this.productsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet1;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet1
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet1.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet1";
            this._FinalProjectDBContext_MyDbContextModelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
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
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 580);
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
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddMoney_Btn;
        private System.Windows.Forms.TextBox AddMoney_tbox;
        private System.Windows.Forms.Button AddOrder_Btn;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private _FinalProjectDBContext_MyDbContextModelDataSet _FinalProjectDBContext_MyDbContextModelDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private _FinalProjectDBContext_MyDbContextModelDataSet1 _FinalProjectDBContext_MyDbContextModelDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button UpdTable_Btn;
    }
}