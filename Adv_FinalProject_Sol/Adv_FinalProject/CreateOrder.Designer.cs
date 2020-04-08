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
            this.ProductsList_Lbox = new System.Windows.Forms.ListBox();
            this.ProdList_lbl = new System.Windows.Forms.Label();
            this.AddProduct_Btn = new System.Windows.Forms.Button();
            this.AddProducAmount_tbox = new System.Windows.Forms.TextBox();
            this.OrderName_lbl = new System.Windows.Forms.Label();
            this.OrderName_tbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProductsList_Lbox
            // 
            this.ProductsList_Lbox.FormattingEnabled = true;
            this.ProductsList_Lbox.ItemHeight = 16;
            this.ProductsList_Lbox.Location = new System.Drawing.Point(12, 34);
            this.ProductsList_Lbox.Name = "ProductsList_Lbox";
            this.ProductsList_Lbox.Size = new System.Drawing.Size(391, 20);
            this.ProductsList_Lbox.TabIndex = 0;
            // 
            // ProdList_lbl
            // 
            this.ProdList_lbl.AutoSize = true;
            this.ProdList_lbl.Location = new System.Drawing.Point(13, 13);
            this.ProdList_lbl.Name = "ProdList_lbl";
            this.ProdList_lbl.Size = new System.Drawing.Size(90, 17);
            this.ProdList_lbl.TabIndex = 1;
            this.ProdList_lbl.Text = "Products List";
            // 
            // AddProduct_Btn
            // 
            this.AddProduct_Btn.Location = new System.Drawing.Point(543, 34);
            this.AddProduct_Btn.Name = "AddProduct_Btn";
            this.AddProduct_Btn.Size = new System.Drawing.Size(245, 22);
            this.AddProduct_Btn.TabIndex = 2;
            this.AddProduct_Btn.Text = "Add Product";
            this.AddProduct_Btn.UseVisualStyleBackColor = true;
            this.AddProduct_Btn.Click += new System.EventHandler(this.AddProduct_Btn_Click);
            // 
            // AddProducAmount_tbox
            // 
            this.AddProducAmount_tbox.Location = new System.Drawing.Point(410, 34);
            this.AddProducAmount_tbox.Name = "AddProducAmount_tbox";
            this.AddProducAmount_tbox.Size = new System.Drawing.Size(127, 22);
            this.AddProducAmount_tbox.TabIndex = 3;
            // 
            // OrderName_lbl
            // 
            this.OrderName_lbl.AutoSize = true;
            this.OrderName_lbl.Location = new System.Drawing.Point(12, 62);
            this.OrderName_lbl.Name = "OrderName_lbl";
            this.OrderName_lbl.Size = new System.Drawing.Size(86, 17);
            this.OrderName_lbl.TabIndex = 4;
            this.OrderName_lbl.Text = "Order Name";
            // 
            // OrderName_tbox
            // 
            this.OrderName_tbox.Location = new System.Drawing.Point(12, 82);
            this.OrderName_tbox.Name = "OrderName_tbox";
            this.OrderName_tbox.Size = new System.Drawing.Size(391, 22);
            this.OrderName_tbox.TabIndex = 5;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderName_tbox);
            this.Controls.Add(this.OrderName_lbl);
            this.Controls.Add(this.AddProducAmount_tbox);
            this.Controls.Add(this.AddProduct_Btn);
            this.Controls.Add(this.ProdList_lbl);
            this.Controls.Add(this.ProductsList_Lbox);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
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
    }
}