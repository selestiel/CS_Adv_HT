namespace Adv_FinalProject
{
    partial class LoginForm
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
            this.Login_lbl = new System.Windows.Forms.Label();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Account_Info_lbl = new System.Windows.Forms.Label();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Override_Btn = new System.Windows.Forms.Button();
            this.Admin_Checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Login_lbl
            // 
            this.Login_lbl.AutoSize = true;
            this.Login_lbl.Font = new System.Drawing.Font("Noto Kufi Arabic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lbl.Location = new System.Drawing.Point(55, 172);
            this.Login_lbl.Name = "Login_lbl";
            this.Login_lbl.Size = new System.Drawing.Size(125, 53);
            this.Login_lbl.TabIndex = 1;
            this.Login_lbl.Text = "Login";
            // 
            // Login_textbox
            // 
            this.Login_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.Login_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_textbox.Location = new System.Drawing.Point(360, 178);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(382, 38);
            this.Login_textbox.TabIndex = 1;
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Noto Kufi Arabic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(55, 289);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(204, 53);
            this.Password_lbl.TabIndex = 2;
            this.Password_lbl.Text = "Password";
            // 
            // Password_textbox
            // 
            this.Password_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.Password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textbox.Location = new System.Drawing.Point(360, 295);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(382, 38);
            this.Password_textbox.TabIndex = 2;
            // 
            // Account_Info_lbl
            // 
            this.Account_Info_lbl.AutoSize = true;
            this.Account_Info_lbl.Font = new System.Drawing.Font("Noto Kufi Arabic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_Info_lbl.Location = new System.Drawing.Point(55, 36);
            this.Account_Info_lbl.Name = "Account_Info_lbl";
            this.Account_Info_lbl.Size = new System.Drawing.Size(458, 53);
            this.Account_Info_lbl.TabIndex = 0;
            this.Account_Info_lbl.Text = "Enter Your Account Info";
            // 
            // Login_Btn
            // 
            this.Login_Btn.Location = new System.Drawing.Point(360, 395);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(381, 43);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "Log-In";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Override_Btn
            // 
            this.Override_Btn.Location = new System.Drawing.Point(64, 415);
            this.Override_Btn.Name = "Override_Btn";
            this.Override_Btn.Size = new System.Drawing.Size(195, 23);
            this.Override_Btn.TabIndex = 4;
            this.Override_Btn.Text = "Override";
            this.Override_Btn.UseVisualStyleBackColor = true;
            this.Override_Btn.Click += new System.EventHandler(this.Override_Btn_Click);
            // 
            // Admin_Checkbox
            // 
            this.Admin_Checkbox.AutoSize = true;
            this.Admin_Checkbox.Location = new System.Drawing.Point(644, 368);
            this.Admin_Checkbox.Name = "Admin_Checkbox";
            this.Admin_Checkbox.Size = new System.Drawing.Size(77, 21);
            this.Admin_Checkbox.TabIndex = 5;
            this.Admin_Checkbox.Text = "Admin?";
            this.Admin_Checkbox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admin_Checkbox);
            this.Controls.Add(this.Override_Btn);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Account_Info_lbl);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Login_textbox);
            this.Controls.Add(this.Login_lbl);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_lbl;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Label Account_Info_lbl;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Button Override_Btn;
        private System.Windows.Forms.CheckBox Admin_Checkbox;
    }
}