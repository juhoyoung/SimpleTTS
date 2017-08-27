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
            this.label3 = new System.Windows.Forms.Label();
            this.tType_cBox = new System.Windows.Forms.ComboBox();
            this.tCSecret_tBox = new System.Windows.Forms.TextBox();
            this.tCID_tBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Trans_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.voiceType_cBox = new System.Windows.Forms.ComboBox();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Submit_Btn = new System.Windows.Forms.Button();
            this.Lang_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Lang_StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Ptt_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbSpeed_label = new System.Windows.Forms.Label();
            this.Pbspeed_tBar = new System.Windows.Forms.TrackBar();
            this.NaverAPI_TabControl = new System.Windows.Forms.TabControl();
            this.TSS_tabPage = new System.Windows.Forms.TabPage();
            this.Translate_tabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sCID_tBox = new System.Windows.Forms.TextBox();
            this.sCSecret_tBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Lang_StatusStrip.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbspeed_tBar)).BeginInit();
            this.NaverAPI_TabControl.SuspendLayout();
            this.TSS_tabPage.SuspendLayout();
            this.Translate_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LangType_cBox
            // 
            this.LangType_cBox.FormattingEnabled = true;
            this.LangType_cBox.Items.AddRange(new object[] {
            "한국인",
            "미국인",
            "중국인"});
            this.LangType_cBox.Location = new System.Drawing.Point(7, 30);
            this.LangType_cBox.Name = "LangType_cBox";
            this.LangType_cBox.Size = new System.Drawing.Size(110, 20);
            this.LangType_cBox.TabIndex = 0;
            this.LangType_cBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LangType_cBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "언어 설정";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "한국어 ->";
            // 
            // tType_cBox
            // 
            this.tType_cBox.FormattingEnabled = true;
            this.tType_cBox.Items.AddRange(new object[] {
            "영어",
            "중국어"});
            this.tType_cBox.Location = new System.Drawing.Point(187, 10);
            this.tType_cBox.Name = "tType_cBox";
            this.tType_cBox.Size = new System.Drawing.Size(81, 20);
            this.tType_cBox.TabIndex = 5;
            this.tType_cBox.TabStop = false;
            // 
            // tCSecret_tBox
            // 
            this.tCSecret_tBox.Location = new System.Drawing.Point(93, 63);
            this.tCSecret_tBox.Name = "tCSecret_tBox";
            this.tCSecret_tBox.Size = new System.Drawing.Size(177, 21);
            this.tCSecret_tBox.TabIndex = 4;
            this.tCSecret_tBox.TabStop = false;
            // 
            // tCID_tBox
            // 
            this.tCID_tBox.Location = new System.Drawing.Point(93, 36);
            this.tCID_tBox.Name = "tCID_tBox";
            this.tCID_tBox.Size = new System.Drawing.Size(177, 21);
            this.tCID_tBox.TabIndex = 3;
            this.tCID_tBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client-Secret";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client-ID";
            // 
            // Trans_checkBox
            // 
            this.Trans_checkBox.AutoSize = true;
            this.Trans_checkBox.Location = new System.Drawing.Point(6, 15);
            this.Trans_checkBox.Name = "Trans_checkBox";
            this.Trans_checkBox.Size = new System.Drawing.Size(76, 16);
            this.Trans_checkBox.TabIndex = 0;
            this.Trans_checkBox.TabStop = false;
            this.Trans_checkBox.Text = "번역 사용";
            this.Trans_checkBox.UseVisualStyleBackColor = true;
            this.Trans_checkBox.CheckedChanged += new System.EventHandler(this.Trans_checkBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.voiceType_cBox);
            this.groupBox3.Location = new System.Drawing.Point(166, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "목소리 설정";
            // 
            // voiceType_cBox
            // 
            this.voiceType_cBox.FormattingEnabled = true;
            this.voiceType_cBox.Items.AddRange(new object[] {
            "1번 타입",
            "2번 타입",
            "3번 타입"});
            this.voiceType_cBox.Location = new System.Drawing.Point(9, 30);
            this.voiceType_cBox.Name = "voiceType_cBox";
            this.voiceType_cBox.Size = new System.Drawing.Size(110, 20);
            this.voiceType_cBox.TabIndex = 0;
            this.voiceType_cBox.TabStop = false;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(160, 222);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 23);
            this.Save_Btn.TabIndex = 3;
            this.Save_Btn.TabStop = false;
            this.Save_Btn.Text = "저장";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.Location = new System.Drawing.Point(250, 221);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_Btn.TabIndex = 4;
            this.Submit_Btn.TabStop = false;
            this.Submit_Btn.Text = "확인";
            this.Submit_Btn.UseVisualStyleBackColor = true;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // Lang_StatusStrip
            // 
            this.Lang_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lang_StatusLabel1});
            this.Lang_StatusStrip.Location = new System.Drawing.Point(0, 256);
            this.Lang_StatusStrip.Name = "Lang_StatusStrip";
            this.Lang_StatusStrip.Size = new System.Drawing.Size(460, 22);
            this.Lang_StatusStrip.TabIndex = 5;
            this.Lang_StatusStrip.Text = "statusStrip1";
            // 
            // Lang_StatusLabel1
            // 
            this.Lang_StatusLabel1.Name = "Lang_StatusLabel1";
            this.Lang_StatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Ptt_checkBox);
            this.groupBox4.Location = new System.Drawing.Point(308, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 69);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "푸시 투 토크";
            // 
            // Ptt_checkBox
            // 
            this.Ptt_checkBox.AutoSize = true;
            this.Ptt_checkBox.Location = new System.Drawing.Point(9, 31);
            this.Ptt_checkBox.Name = "Ptt_checkBox";
            this.Ptt_checkBox.Size = new System.Drawing.Size(76, 16);
            this.Ptt_checkBox.TabIndex = 0;
            this.Ptt_checkBox.TabStop = false;
            this.Ptt_checkBox.Text = "PTT 사용";
            this.Ptt_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pbSpeed_label);
            this.groupBox5.Controls.Add(this.Pbspeed_tBar);
            this.groupBox5.Location = new System.Drawing.Point(307, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 86);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "재생 속도";
            // 
            // pbSpeed_label
            // 
            this.pbSpeed_label.AutoSize = true;
            this.pbSpeed_label.Location = new System.Drawing.Point(13, 21);
            this.pbSpeed_label.Name = "pbSpeed_label";
            this.pbSpeed_label.Size = new System.Drawing.Size(21, 12);
            this.pbSpeed_label.TabIndex = 1;
            this.pbSpeed_label.Text = "1.0";
            // 
            // Pbspeed_tBar
            // 
            this.Pbspeed_tBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pbspeed_tBar.LargeChange = 4;
            this.Pbspeed_tBar.Location = new System.Drawing.Point(6, 36);
            this.Pbspeed_tBar.Maximum = 20;
            this.Pbspeed_tBar.Name = "Pbspeed_tBar";
            this.Pbspeed_tBar.Size = new System.Drawing.Size(129, 45);
            this.Pbspeed_tBar.TabIndex = 0;
            this.Pbspeed_tBar.Scroll += new System.EventHandler(this.Pbspeed_tBar_Scroll);
            // 
            // NaverAPI_TabControl
            // 
            this.NaverAPI_TabControl.Controls.Add(this.TSS_tabPage);
            this.NaverAPI_TabControl.Controls.Add(this.Translate_tabPage);
            this.NaverAPI_TabControl.Location = new System.Drawing.Point(12, 95);
            this.NaverAPI_TabControl.Name = "NaverAPI_TabControl";
            this.NaverAPI_TabControl.SelectedIndex = 0;
            this.NaverAPI_TabControl.Size = new System.Drawing.Size(289, 119);
            this.NaverAPI_TabControl.TabIndex = 8;
            // 
            // TSS_tabPage
            // 
            this.TSS_tabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TSS_tabPage.Controls.Add(this.label6);
            this.TSS_tabPage.Controls.Add(this.sCSecret_tBox);
            this.TSS_tabPage.Controls.Add(this.sCID_tBox);
            this.TSS_tabPage.Controls.Add(this.label5);
            this.TSS_tabPage.Controls.Add(this.label4);
            this.TSS_tabPage.Location = new System.Drawing.Point(4, 22);
            this.TSS_tabPage.Name = "TSS_tabPage";
            this.TSS_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TSS_tabPage.Size = new System.Drawing.Size(281, 93);
            this.TSS_tabPage.TabIndex = 0;
            this.TSS_tabPage.Text = "음성 합성";
            // 
            // Translate_tabPage
            // 
            this.Translate_tabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Translate_tabPage.Controls.Add(this.label3);
            this.Translate_tabPage.Controls.Add(this.Trans_checkBox);
            this.Translate_tabPage.Controls.Add(this.tCSecret_tBox);
            this.Translate_tabPage.Controls.Add(this.tCID_tBox);
            this.Translate_tabPage.Controls.Add(this.label1);
            this.Translate_tabPage.Controls.Add(this.tType_cBox);
            this.Translate_tabPage.Controls.Add(this.label2);
            this.Translate_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Translate_tabPage.Name = "Translate_tabPage";
            this.Translate_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Translate_tabPage.Size = new System.Drawing.Size(281, 93);
            this.Translate_tabPage.TabIndex = 1;
            this.Translate_tabPage.Text = "번역";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Client-ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Client-Secret";
            // 
            // sCID_tBox
            // 
            this.sCID_tBox.Location = new System.Drawing.Point(93, 36);
            this.sCID_tBox.Name = "sCID_tBox";
            this.sCID_tBox.Size = new System.Drawing.Size(177, 21);
            this.sCID_tBox.TabIndex = 9;
            this.sCID_tBox.TabStop = false;
            // 
            // sCSecret_tBox
            // 
            this.sCSecret_tBox.Location = new System.Drawing.Point(93, 63);
            this.sCSecret_tBox.Name = "sCSecret_tBox";
            this.sCSecret_tBox.Size = new System.Drawing.Size(177, 21);
            this.sCSecret_tBox.TabIndex = 10;
            this.sCSecret_tBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Naver 음성 합성 API";
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 278);
            this.Controls.Add(this.NaverAPI_TabControl);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Lang_StatusStrip);
            this.Controls.Add(this.Submit_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbspeed_tBar)).EndInit();
            this.NaverAPI_TabControl.ResumeLayout(false);
            this.TSS_tabPage.ResumeLayout(false);
            this.TSS_tabPage.PerformLayout();
            this.Translate_tabPage.ResumeLayout(false);
            this.Translate_tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LangType_cBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox voiceType_cBox;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Submit_Btn;
        private System.Windows.Forms.StatusStrip Lang_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Lang_StatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Trans_checkBox;
        private System.Windows.Forms.TextBox tCID_tBox;
        private System.Windows.Forms.TextBox tCSecret_tBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tType_cBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox Ptt_checkBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar Pbspeed_tBar;
        private System.Windows.Forms.Label pbSpeed_label;
        private System.Windows.Forms.TabControl NaverAPI_TabControl;
        private System.Windows.Forms.TabPage TSS_tabPage;
        private System.Windows.Forms.TabPage Translate_tabPage;
        private System.Windows.Forms.TextBox sCSecret_tBox;
        private System.Windows.Forms.TextBox sCID_tBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}