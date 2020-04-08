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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddMoney_Btn = new System.Windows.Forms.Button();
            this.AddMoney_tbox = new System.Windows.Forms.TextBox();
            this.AddOrder_Btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(478, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddMoney_Btn
            // 
            this.AddMoney_Btn.Location = new System.Drawing.Point(484, 70);
            this.AddMoney_Btn.Name = "AddMoney_Btn";
            this.AddMoney_Btn.Size = new System.Drawing.Size(304, 49);
            this.AddMoney_Btn.TabIndex = 1;
            this.AddMoney_Btn.Text = "Add Money";
            this.AddMoney_Btn.UseVisualStyleBackColor = true;
            this.AddMoney_Btn.Click += new System.EventHandler(this.AddMoney_Btn_Click);
            // 
            // AddMoney_tbox
            // 
            this.AddMoney_tbox.Location = new System.Drawing.Point(484, 36);
            this.AddMoney_tbox.Name = "AddMoney_tbox";
            this.AddMoney_tbox.Size = new System.Drawing.Size(304, 22);
            this.AddMoney_tbox.TabIndex = 2;
            // 
            // AddOrder_Btn
            // 
            this.AddOrder_Btn.Location = new System.Drawing.Point(483, 125);
            this.AddOrder_Btn.Name = "AddOrder_Btn";
            this.AddOrder_Btn.Size = new System.Drawing.Size(303, 60);
            this.AddOrder_Btn.TabIndex = 3;
            this.AddOrder_Btn.Text = "Add Order";
            this.AddOrder_Btn.UseVisualStyleBackColor = true;
            this.AddOrder_Btn.Click += new System.EventHandler(this.AddOrder_Btn_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(481, 9);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(73, 17);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Username";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.AddOrder_Btn);
            this.Controls.Add(this.AddMoney_tbox);
            this.Controls.Add(this.AddMoney_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddMoney_Btn;
        private System.Windows.Forms.TextBox AddMoney_tbox;
        private System.Windows.Forms.Button AddOrder_Btn;
        private System.Windows.Forms.Label Username_lbl;
    }
}