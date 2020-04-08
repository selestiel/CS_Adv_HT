namespace Adv_FinalProject
{
    partial class AdminForm
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
            this.finalProjectDBContextDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreateClient_Btn = new System.Windows.Forms.Button();
            this.CreateAdmin_Btn = new System.Windows.Forms.Button();
            this.Override2_Btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDBContextDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.finalProjectDBContextDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // CreateClient_Btn
            // 
            this.CreateClient_Btn.Location = new System.Drawing.Point(464, 31);
            this.CreateClient_Btn.Name = "CreateClient_Btn";
            this.CreateClient_Btn.Size = new System.Drawing.Size(324, 38);
            this.CreateClient_Btn.TabIndex = 1;
            this.CreateClient_Btn.Text = "Create Client";
            this.CreateClient_Btn.UseVisualStyleBackColor = true;
            this.CreateClient_Btn.Click += new System.EventHandler(this.CreateClient_Btn_Click);
            // 
            // CreateAdmin_Btn
            // 
            this.CreateAdmin_Btn.Location = new System.Drawing.Point(464, 84);
            this.CreateAdmin_Btn.Name = "CreateAdmin_Btn";
            this.CreateAdmin_Btn.Size = new System.Drawing.Size(324, 38);
            this.CreateAdmin_Btn.TabIndex = 2;
            this.CreateAdmin_Btn.Text = "Create Admin";
            this.CreateAdmin_Btn.UseVisualStyleBackColor = true;
            this.CreateAdmin_Btn.Click += new System.EventHandler(this.CreateAdmin_Btn_Click);
            // 
            // Override2_Btn
            // 
            this.Override2_Btn.Location = new System.Drawing.Point(464, 137);
            this.Override2_Btn.Name = "Override2_Btn";
            this.Override2_Btn.Size = new System.Drawing.Size(324, 51);
            this.Override2_Btn.TabIndex = 3;
            this.Override2_Btn.Text = "Override2";
            this.Override2_Btn.UseVisualStyleBackColor = true;
            this.Override2_Btn.Click += new System.EventHandler(this.Override2_Btn_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(464, 8);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(73, 17);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Username";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Override2_Btn);
            this.Controls.Add(this.CreateAdmin_Btn);
            this.Controls.Add(this.CreateClient_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDBContextDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CreateClient_Btn;
        private System.Windows.Forms.Button CreateAdmin_Btn;
        private System.Windows.Forms.BindingSource finalProjectDBContextDataSet1BindingSource;

        private System.Windows.Forms.Button Override2_Btn;
        private System.Windows.Forms.Label Username_lbl;
    }
}