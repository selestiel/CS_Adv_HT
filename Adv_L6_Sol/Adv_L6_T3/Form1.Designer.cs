namespace Adv_L6_T3
{
    public partial class Form1
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
            TEXTOUTPUT = new System.Windows.Forms.RichTextBox();
            TempNameIN = new System.Windows.Forms.TextBox();
            TempValueIN = new System.Windows.Forms.TextBox();
            this.BTN_CVT = new System.Windows.Forms.Button();
            this.BTN_TypeInfo = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEXTOUTPUT
            // 
            TEXTOUTPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TEXTOUTPUT.Location = new System.Drawing.Point(12, 125);
            TEXTOUTPUT.Name = "TEXTOUTPUT";
            TEXTOUTPUT.Size = new System.Drawing.Size(766, 325);
            TEXTOUTPUT.TabIndex = 0;
            TEXTOUTPUT.Text = "";
            // 
            // TempNameIN
            // 
            TempNameIN.Location = new System.Drawing.Point(12, 12);
            TempNameIN.Name = "TempNameIN";
            TempNameIN.Size = new System.Drawing.Size(229, 22);
            TempNameIN.TabIndex = 1;
            // 
            // TempValueIN
            // 
            TempValueIN.Location = new System.Drawing.Point(247, 12);
            TempValueIN.Name = "TempValueIN";
            TempValueIN.Size = new System.Drawing.Size(125, 22);
            TempValueIN.TabIndex = 2;
            // 
            // BTN_CVT
            // 
            this.BTN_CVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CVT.Location = new System.Drawing.Point(378, 12);
            this.BTN_CVT.Name = "BTN_CVT";
            this.BTN_CVT.Size = new System.Drawing.Size(276, 42);
            this.BTN_CVT.TabIndex = 3;
            this.BTN_CVT.Text = "Convert";
            this.BTN_CVT.UseVisualStyleBackColor = true;
            this.BTN_CVT.Click += new System.EventHandler(this.BTN_CVT_Click);
            // 
            // BTN_TypeInfo
            // 
            this.BTN_TypeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TypeInfo.Location = new System.Drawing.Point(12, 60);
            this.BTN_TypeInfo.Name = "BTN_TypeInfo";
            this.BTN_TypeInfo.Size = new System.Drawing.Size(642, 39);
            this.BTN_TypeInfo.TabIndex = 4;
            this.BTN_TypeInfo.Text = "Type Info";
            this.BTN_TypeInfo.UseVisualStyleBackColor = true;
            this.BTN_TypeInfo.Click += new System.EventHandler(this.BTN_TypeInfo_Click);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLEAR.Location = new System.Drawing.Point(666, 12);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(111, 86);
            this.BTN_CLEAR.TabIndex = 5;
            this.BTN_CLEAR.Text = "Clear";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.BTN_TypeInfo);
            this.Controls.Add(this.BTN_CVT);
            this.Controls.Add(TempValueIN);
            this.Controls.Add(TempNameIN);
            this.Controls.Add(TEXTOUTPUT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_CVT;
        private System.Windows.Forms.Button BTN_TypeInfo;
        private System.Windows.Forms.Button BTN_CLEAR;
        public static System.Windows.Forms.RichTextBox TEXTOUTPUT;
        public static System.Windows.Forms.TextBox TempNameIN;
        public static System.Windows.Forms.TextBox TempValueIN;
    }
}

