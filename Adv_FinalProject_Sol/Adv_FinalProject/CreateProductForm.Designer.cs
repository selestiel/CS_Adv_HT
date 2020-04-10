namespace Adv_FinalProject
{
    partial class CreateProductForm
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
            this.CreateProduct_Btn = new System.Windows.Forms.Button();
            this.ProductName_lbl = new System.Windows.Forms.Label();
            this.ProductName_tbox = new System.Windows.Forms.TextBox();
            this.ProductManuf_tbox = new System.Windows.Forms.TextBox();
            this.ProductManuf_lbl = new System.Windows.Forms.Label();
            this.ProductPrice_tbox = new System.Windows.Forms.TextBox();
            this.ProductPrice_lbl = new System.Windows.Forms.Label();
            this.ProductAmount_tbox = new System.Windows.Forms.TextBox();
            this.ProductAmount_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateProduct_Btn
            // 
            this.CreateProduct_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateProduct_Btn.Location = new System.Drawing.Point(21, 183);
            this.CreateProduct_Btn.Name = "CreateProduct_Btn";
            this.CreateProduct_Btn.Size = new System.Drawing.Size(389, 62);
            this.CreateProduct_Btn.TabIndex = 0;
            this.CreateProduct_Btn.Text = "Create Product";
            this.CreateProduct_Btn.UseVisualStyleBackColor = true;
            this.CreateProduct_Btn.Click += new System.EventHandler(this.CreateProduct_Btn_Click);
            // 
            // ProductName_lbl
            // 
            this.ProductName_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName_lbl.AutoSize = true;
            this.ProductName_lbl.Location = new System.Drawing.Point(18, 15);
            this.ProductName_lbl.Name = "ProductName_lbl";
            this.ProductName_lbl.Size = new System.Drawing.Size(98, 17);
            this.ProductName_lbl.TabIndex = 1;
            this.ProductName_lbl.Text = "Product Name";
            // 
            // ProductName_tbox
            // 
            this.ProductName_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName_tbox.Location = new System.Drawing.Point(169, 12);
            this.ProductName_tbox.Name = "ProductName_tbox";
            this.ProductName_tbox.Size = new System.Drawing.Size(241, 22);
            this.ProductName_tbox.TabIndex = 2;
            // 
            // ProductManuf_tbox
            // 
            this.ProductManuf_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductManuf_tbox.Location = new System.Drawing.Point(169, 54);
            this.ProductManuf_tbox.Name = "ProductManuf_tbox";
            this.ProductManuf_tbox.Size = new System.Drawing.Size(241, 22);
            this.ProductManuf_tbox.TabIndex = 4;
            // 
            // ProductManuf_lbl
            // 
            this.ProductManuf_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductManuf_lbl.AutoSize = true;
            this.ProductManuf_lbl.Location = new System.Drawing.Point(18, 59);
            this.ProductManuf_lbl.Name = "ProductManuf_lbl";
            this.ProductManuf_lbl.Size = new System.Drawing.Size(145, 17);
            this.ProductManuf_lbl.TabIndex = 3;
            this.ProductManuf_lbl.Text = "Product Manufacturer";
            // 
            // ProductPrice_tbox
            // 
            this.ProductPrice_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPrice_tbox.Location = new System.Drawing.Point(169, 94);
            this.ProductPrice_tbox.Name = "ProductPrice_tbox";
            this.ProductPrice_tbox.Size = new System.Drawing.Size(241, 22);
            this.ProductPrice_tbox.TabIndex = 6;
            // 
            // ProductPrice_lbl
            // 
            this.ProductPrice_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPrice_lbl.AutoSize = true;
            this.ProductPrice_lbl.Location = new System.Drawing.Point(18, 99);
            this.ProductPrice_lbl.Name = "ProductPrice_lbl";
            this.ProductPrice_lbl.Size = new System.Drawing.Size(93, 17);
            this.ProductPrice_lbl.TabIndex = 5;
            this.ProductPrice_lbl.Text = "Product Price";
            // 
            // ProductAmount_tbox
            // 
            this.ProductAmount_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductAmount_tbox.Location = new System.Drawing.Point(169, 138);
            this.ProductAmount_tbox.Name = "ProductAmount_tbox";
            this.ProductAmount_tbox.Size = new System.Drawing.Size(241, 22);
            this.ProductAmount_tbox.TabIndex = 8;
            // 
            // ProductAmount_lbl
            // 
            this.ProductAmount_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductAmount_lbl.AutoSize = true;
            this.ProductAmount_lbl.Location = new System.Drawing.Point(17, 141);
            this.ProductAmount_lbl.Name = "ProductAmount_lbl";
            this.ProductAmount_lbl.Size = new System.Drawing.Size(109, 17);
            this.ProductAmount_lbl.TabIndex = 7;
            this.ProductAmount_lbl.Text = "Product Amount";
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 254);
            this.Controls.Add(this.ProductAmount_tbox);
            this.Controls.Add(this.ProductAmount_lbl);
            this.Controls.Add(this.ProductPrice_tbox);
            this.Controls.Add(this.ProductPrice_lbl);
            this.Controls.Add(this.ProductManuf_tbox);
            this.Controls.Add(this.ProductManuf_lbl);
            this.Controls.Add(this.ProductName_tbox);
            this.Controls.Add(this.ProductName_lbl);
            this.Controls.Add(this.CreateProduct_Btn);
            this.Name = "CreateProductForm";
            this.Text = "CreateProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateProduct_Btn;
        private System.Windows.Forms.Label ProductName_lbl;
        private System.Windows.Forms.TextBox ProductName_tbox;
        private System.Windows.Forms.TextBox ProductManuf_tbox;
        private System.Windows.Forms.Label ProductManuf_lbl;
        private System.Windows.Forms.TextBox ProductPrice_tbox;
        private System.Windows.Forms.Label ProductPrice_lbl;
        private System.Windows.Forms.TextBox ProductAmount_tbox;
        private System.Windows.Forms.Label ProductAmount_lbl;
    }
}