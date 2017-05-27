namespace SimpleTTS
{
    partial class MacroForm
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
            this.Save_Btn = new System.Windows.Forms.Button();
            this.macro1_tBox = new System.Windows.Forms.TextBox();
            this.macro2_tBox = new System.Windows.Forms.TextBox();
            this.macro3_tBox = new System.Windows.Forms.TextBox();
            this.macro4_tBox = new System.Windows.Forms.TextBox();
            this.Submit_Btn = new System.Windows.Forms.Button();
            this.text_gBox = new System.Windows.Forms.GroupBox();
            this.sKey_gBox = new System.Windows.Forms.GroupBox();
            this.skey4_tBox = new System.Windows.Forms.TextBox();
            this.skey3_tBox = new System.Windows.Forms.TextBox();
            this.skey2_tBox = new System.Windows.Forms.TextBox();
            this.skey1_tBox = new System.Windows.Forms.TextBox();
            this.text_gBox.SuspendLayout();
            this.sKey_gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(137, 244);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 23);
            this.Save_Btn.TabIndex = 0;
            this.Save_Btn.Text = "저장";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // macro1_tBox
            // 
            this.macro1_tBox.Location = new System.Drawing.Point(10, 30);
            this.macro1_tBox.Name = "macro1_tBox";
            this.macro1_tBox.Size = new System.Drawing.Size(229, 21);
            this.macro1_tBox.TabIndex = 4;
            // 
            // macro2_tBox
            // 
            this.macro2_tBox.Location = new System.Drawing.Point(10, 70);
            this.macro2_tBox.Name = "macro2_tBox";
            this.macro2_tBox.Size = new System.Drawing.Size(229, 21);
            this.macro2_tBox.TabIndex = 5;
            // 
            // macro3_tBox
            // 
            this.macro3_tBox.Location = new System.Drawing.Point(10, 110);
            this.macro3_tBox.Name = "macro3_tBox";
            this.macro3_tBox.Size = new System.Drawing.Size(229, 21);
            this.macro3_tBox.TabIndex = 6;
            // 
            // macro4_tBox
            // 
            this.macro4_tBox.Location = new System.Drawing.Point(10, 150);
            this.macro4_tBox.Name = "macro4_tBox";
            this.macro4_tBox.Size = new System.Drawing.Size(229, 21);
            this.macro4_tBox.TabIndex = 7;
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.Location = new System.Drawing.Point(233, 244);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_Btn.TabIndex = 8;
            this.Submit_Btn.Text = "확인";
            this.Submit_Btn.UseVisualStyleBackColor = true;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // text_gBox
            // 
            this.text_gBox.Controls.Add(this.macro1_tBox);
            this.text_gBox.Controls.Add(this.macro2_tBox);
            this.text_gBox.Controls.Add(this.macro4_tBox);
            this.text_gBox.Controls.Add(this.macro3_tBox);
            this.text_gBox.Location = new System.Drawing.Point(12, 27);
            this.text_gBox.Name = "text_gBox";
            this.text_gBox.Size = new System.Drawing.Size(252, 191);
            this.text_gBox.TabIndex = 9;
            this.text_gBox.TabStop = false;
            this.text_gBox.Text = "하고싶은 말";
            // 
            // sKey_gBox
            // 
            this.sKey_gBox.Controls.Add(this.skey4_tBox);
            this.sKey_gBox.Controls.Add(this.skey3_tBox);
            this.sKey_gBox.Controls.Add(this.skey2_tBox);
            this.sKey_gBox.Controls.Add(this.skey1_tBox);
            this.sKey_gBox.Location = new System.Drawing.Point(270, 27);
            this.sKey_gBox.Name = "sKey_gBox";
            this.sKey_gBox.Size = new System.Drawing.Size(144, 191);
            this.sKey_gBox.TabIndex = 8;
            this.sKey_gBox.TabStop = false;
            this.sKey_gBox.Text = "단축키";
            // 
            // skey4_tBox
            // 
            this.skey4_tBox.Location = new System.Drawing.Point(19, 150);
            this.skey4_tBox.Name = "skey4_tBox";
            this.skey4_tBox.ReadOnly = true;
            this.skey4_tBox.Size = new System.Drawing.Size(100, 21);
            this.skey4_tBox.TabIndex = 3;
            this.skey4_tBox.Text = "Alt + 4";
            this.skey4_tBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // skey3_tBox
            // 
            this.skey3_tBox.Location = new System.Drawing.Point(19, 110);
            this.skey3_tBox.Name = "skey3_tBox";
            this.skey3_tBox.ReadOnly = true;
            this.skey3_tBox.Size = new System.Drawing.Size(100, 21);
            this.skey3_tBox.TabIndex = 2;
            this.skey3_tBox.Text = "Alt + 3";
            this.skey3_tBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // skey2_tBox
            // 
            this.skey2_tBox.Location = new System.Drawing.Point(19, 70);
            this.skey2_tBox.Name = "skey2_tBox";
            this.skey2_tBox.ReadOnly = true;
            this.skey2_tBox.Size = new System.Drawing.Size(100, 21);
            this.skey2_tBox.TabIndex = 1;
            this.skey2_tBox.Text = "Alt + 2";
            this.skey2_tBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // skey1_tBox
            // 
            this.skey1_tBox.Location = new System.Drawing.Point(19, 30);
            this.skey1_tBox.Name = "skey1_tBox";
            this.skey1_tBox.ReadOnly = true;
            this.skey1_tBox.Size = new System.Drawing.Size(100, 21);
            this.skey1_tBox.TabIndex = 0;
            this.skey1_tBox.Text = "Alt + 1";
            this.skey1_tBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MacroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 291);
            this.Controls.Add(this.sKey_gBox);
            this.Controls.Add(this.text_gBox);
            this.Controls.Add(this.Submit_Btn);
            this.Controls.Add(this.Save_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MacroForm";
            this.Text = "매크로 설정 창";
            this.TopMost = true;
            this.text_gBox.ResumeLayout(false);
            this.text_gBox.PerformLayout();
            this.sKey_gBox.ResumeLayout(false);
            this.sKey_gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.TextBox macro1_tBox;
        private System.Windows.Forms.TextBox macro2_tBox;
        private System.Windows.Forms.TextBox macro3_tBox;
        private System.Windows.Forms.TextBox macro4_tBox;
        private System.Windows.Forms.Button Submit_Btn;
        private System.Windows.Forms.GroupBox text_gBox;
        private System.Windows.Forms.GroupBox sKey_gBox;
        private System.Windows.Forms.TextBox skey4_tBox;
        private System.Windows.Forms.TextBox skey3_tBox;
        private System.Windows.Forms.TextBox skey2_tBox;
        private System.Windows.Forms.TextBox skey1_tBox;
    }
}