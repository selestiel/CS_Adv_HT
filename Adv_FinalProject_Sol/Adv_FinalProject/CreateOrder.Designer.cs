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
            this.ProductsList_Lbox = new System.Windows.Forms.ListBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProdList_lbl = new System.Windows.Forms.Label();
            this.AddProduct_Btn = new System.Windows.Forms.Button();
            this.AddProducAmount_tbox = new System.Windows.Forms.TextBox();
            this.OrderName_lbl = new System.Windows.Forms.Label();
            this.OrderName_tbox = new System.Windows.Forms.TextBox();
            this.CreateOrder_Btn = new System.Windows.Forms.Button();
            this.CheckOutOrder_Btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsList_Lbox
            // 
            this.ProductsList_Lbox.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.ProductsList_Lbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Product_Price", true));
            this.ProductsList_Lbox.DataSource = this.productsBindingSource;
            this.ProductsList_Lbox.DisplayMember = "Product_Manufacturer";
            this.ProductsList_Lbox.FormattingEnabled = true;
            this.ProductsList_Lbox.ItemHeight = 16;
            this.ProductsList_Lbox.Location = new System.Drawing.Point(12, 34);
            this.ProductsList_Lbox.Name = "ProductsList_Lbox";
            this.ProductsList_Lbox.Size = new System.Drawing.Size(391, 20);
            this.ProductsList_Lbox.TabIndex = 0;
            this.ProductsList_Lbox.ValueMember = "Product_Name";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
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
            this.AddProduct_Btn.Location = new System.Drawing.Point(543, 34);
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
            this.AddProducAmount_tbox.Location = new System.Drawing.Point(409, 34);
            this.AddProducAmount_tbox.Name = "AddProducAmount_tbox";
            this.AddProducAmount_tbox.Size = new System.Drawing.Size(127, 38);
            this.AddProducAmount_tbox.TabIndex = 3;
            this.AddProducAmount_tbox.Text = "0";
            // 
            // OrderName_lbl
            // 
            this.OrderName_lbl.AutoSize = true;
            this.OrderName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderName_lbl.Location = new System.Drawing.Point(9, 126);
            this.OrderName_lbl.Name = "OrderName_lbl";
            this.OrderName_lbl.Size = new System.Drawing.Size(101, 20);
            this.OrderName_lbl.TabIndex = 4;
            this.OrderName_lbl.Text = "Order Name";
            // 
            // OrderName_tbox
            // 
            this.OrderName_tbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.OrderName_tbox.Location = new System.Drawing.Point(115, 126);
            this.OrderName_tbox.Name = "OrderName_tbox";
            this.OrderName_tbox.Size = new System.Drawing.Size(421, 22);
            this.OrderName_tbox.TabIndex = 5;
            this.OrderName_tbox.Text = "-";
            // 
            // CreateOrder_Btn
            // 
            this.CreateOrder_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateOrder_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrder_Btn.Location = new System.Drawing.Point(543, 109);
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
            this.CheckOutOrder_Btn.Location = new System.Drawing.Point(12, 158);
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
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.CheckOutOrder_Btn);
            this.Controls.Add(this.CreateOrder_Btn);
            this.Controls.Add(this.OrderName_tbox);
            this.Controls.Add(this.OrderName_lbl);
            this.Controls.Add(this.AddProducAmount_tbox);
            this.Controls.Add(this.AddProduct_Btn);
            this.Controls.Add(this.ProdList_lbl);
            this.Controls.Add(this.ProductsList_Lbox);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsList_Lbox;
        private System.Windows.Forms.Label ProdList_lbl;
        private System.Windows.Forms.Button AddProduct_Btn;
        private System.Windows.Forms.TextBox AddProducAmount_tbox;
        private System.Windows.Forms.Label OrderName_lbl;
        private System.Windows.Forms.TextBox OrderName_tbox;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Button CreateOrder_Btn;
        private System.Windows.Forms.Button CheckOutOrder_Btn;
        private System.Windows.Forms.Label Username_lbl;
    }
}