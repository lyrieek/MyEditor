namespace MyEditor
{
    partial class Set
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Encoding = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_md5key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "编码方式：";
            // 
            // cbx_Encoding
            // 
            this.cbx_Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Encoding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_Encoding.FormattingEnabled = true;
            this.cbx_Encoding.Items.AddRange(new object[] {
            "Default",
            "ASCII",
            "Unicode",
            "UTF-7",
            "UTF-8",
            "UTF-16(BigEndianUnicode)",
            "UTF-32"});
            this.cbx_Encoding.Location = new System.Drawing.Point(109, 23);
            this.cbx_Encoding.Name = "cbx_Encoding";
            this.cbx_Encoding.Size = new System.Drawing.Size(121, 20);
            this.cbx_Encoding.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "您的设置再重新打开文件后有效";
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(155, 342);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "确定";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = " MD5密钥：";
            // 
            // txt_md5key
            // 
            this.txt_md5key.Location = new System.Drawing.Point(109, 68);
            this.txt_md5key.Name = "txt_md5key";
            this.txt_md5key.Size = new System.Drawing.Size(121, 21);
            this.txt_md5key.TabIndex = 5;
            this.txt_md5key.Text = "--------";
            // 
            // Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 417);
            this.Controls.Add(this.txt_md5key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Encoding);
            this.Controls.Add(this.label1);
            this.Name = "Set";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Set_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Encoding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_md5key;
    }
}