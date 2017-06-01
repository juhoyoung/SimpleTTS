namespace SimpleTTS
{
    partial class LanguageForm
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
            this.LangType_cBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.voiceType_cBox = new System.Windows.Forms.ComboBox();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Submit_Btn = new System.Windows.Forms.Button();
            this.Lang_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Lang_StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Lang_StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LangType_cBox
            // 
            this.LangType_cBox.FormattingEnabled = true;
            this.LangType_cBox.Items.AddRange(new object[] {
            "한국인",
            "미국인"});
            this.LangType_cBox.Location = new System.Drawing.Point(7, 30);
            this.LangType_cBox.Name = "LangType_cBox";
            this.LangType_cBox.Size = new System.Drawing.Size(120, 20);
            this.LangType_cBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LangType_cBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "언어 설정";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "번역";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.voiceType_cBox);
            this.groupBox3.Location = new System.Drawing.Point(172, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "목소리 설정";
            // 
            // voiceType_cBox
            // 
            this.voiceType_cBox.FormattingEnabled = true;
            this.voiceType_cBox.Items.AddRange(new object[] {
            "1번 타입",
            "2번 타입"});
            this.voiceType_cBox.Location = new System.Drawing.Point(9, 30);
            this.voiceType_cBox.Name = "voiceType_cBox";
            this.voiceType_cBox.Size = new System.Drawing.Size(120, 20);
            this.voiceType_cBox.TabIndex = 0;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(82, 215);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 23);
            this.Save_Btn.TabIndex = 3;
            this.Save_Btn.Text = "저장";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.Location = new System.Drawing.Point(172, 215);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_Btn.TabIndex = 4;
            this.Submit_Btn.Text = "확인";
            this.Submit_Btn.UseVisualStyleBackColor = true;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // Lang_StatusStrip
            // 
            this.Lang_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lang_StatusLabel1});
            this.Lang_StatusStrip.Location = new System.Drawing.Point(0, 246);
            this.Lang_StatusStrip.Name = "Lang_StatusStrip";
            this.Lang_StatusStrip.Size = new System.Drawing.Size(332, 22);
            this.Lang_StatusStrip.TabIndex = 5;
            this.Lang_StatusStrip.Text = "statusStrip1";
            // 
            // Lang_StatusLabel1
            // 
            this.Lang_StatusLabel1.Name = "Lang_StatusLabel1";
            this.Lang_StatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 268);
            this.Controls.Add(this.Lang_StatusStrip);
            this.Controls.Add(this.Submit_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanguageForm";
            this.Text = "언어 설정 창";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LanguageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.Lang_StatusStrip.ResumeLayout(false);
            this.Lang_StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LangType_cBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox voiceType_cBox;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Submit_Btn;
        private System.Windows.Forms.StatusStrip Lang_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Lang_StatusLabel1;
    }
}