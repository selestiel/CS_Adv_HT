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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreateClient_Btn = new System.Windows.Forms.Button();
            this.CreateAdmin_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // CreateClient_Btn
            // 
            this.CreateClient_Btn.Location = new System.Drawing.Point(464, 13);
            this.CreateClient_Btn.Name = "CreateClient_Btn";
            this.CreateClient_Btn.Size = new System.Drawing.Size(324, 38);
            this.CreateClient_Btn.TabIndex = 1;
            this.CreateClient_Btn.Text = "Create Client";
            this.CreateClient_Btn.UseVisualStyleBackColor = true;
            this.CreateClient_Btn.Click += new System.EventHandler(this.CreateClient_Btn_Click);
            // 
            // CreateAdmin_Btn
            // 
            this.CreateAdmin_Btn.Location = new System.Drawing.Point(464, 57);
            this.CreateAdmin_Btn.Name = "CreateAdmin_Btn";
            this.CreateAdmin_Btn.Size = new System.Drawing.Size(324, 38);
            this.CreateAdmin_Btn.TabIndex = 2;
            this.CreateAdmin_Btn.Text = "Create Admin";
            this.CreateAdmin_Btn.UseVisualStyleBackColor = true;
            this.CreateAdmin_Btn.Click += new System.EventHandler(this.CreateAdmin_Btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateAdmin_Btn);
            this.Controls.Add(this.CreateClient_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CreateClient_Btn;
        private System.Windows.Forms.Button CreateAdmin_Btn;
    }
}