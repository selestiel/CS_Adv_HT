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
            this.AddMoney_Btn = new System.Windows.Forms.Button();
            this.AddMoney_tbox = new System.Windows.Forms.TextBox();
            this.AddOrder_Btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this._FinalProjectDBContext_MyDbContextModelDataSet = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSetTableAdapters.OrdersTableAdapter();
            this._FinalProjectDBContext_MyDbContextModelDataSet1 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet1TableAdapters.ProductsTableAdapter();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(309, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddMoney_Btn
            // 
            this.AddMoney_Btn.Location = new System.Drawing.Point(644, 70);
            this.AddMoney_Btn.Name = "AddMoney_Btn";
            this.AddMoney_Btn.Size = new System.Drawing.Size(144, 49);
            this.AddMoney_Btn.TabIndex = 1;
            this.AddMoney_Btn.Text = "Add Money";
            this.AddMoney_Btn.UseVisualStyleBackColor = true;
            this.AddMoney_Btn.Click += new System.EventHandler(this.AddMoney_Btn_Click);
            // 
            // AddMoney_tbox
            // 
            this.AddMoney_tbox.Location = new System.Drawing.Point(644, 36);
            this.AddMoney_tbox.Name = "AddMoney_tbox";
            this.AddMoney_tbox.Size = new System.Drawing.Size(144, 22);
            this.AddMoney_tbox.TabIndex = 2;
            // 
            // AddOrder_Btn
            // 
            this.AddOrder_Btn.Location = new System.Drawing.Point(644, 125);
            this.AddOrder_Btn.Name = "AddOrder_Btn";
            this.AddOrder_Btn.Size = new System.Drawing.Size(142, 60);
            this.AddOrder_Btn.TabIndex = 3;
            this.AddOrder_Btn.Text = "Add Order";
            this.AddOrder_Btn.UseVisualStyleBackColor = true;
            this.AddOrder_Btn.Click += new System.EventHandler(this.AddOrder_Btn_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(641, 16);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(73, 17);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Username";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(327, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(311, 413);
            this.dataGridView2.TabIndex = 5;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet";
            this._FinalProjectDBContext_MyDbContextModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet1
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet1.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet1";
            this._FinalProjectDBContext_MyDbContextModelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Product_Manufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "Product_Manufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            this.productManufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Price";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Product_Price";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "Product_Amount";
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "Product_Amount";
            this.productAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            this.productAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Order_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Order_Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order_Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Order_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Order_Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Client_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Client_ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
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
    }
}