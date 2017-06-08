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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Macro_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Macro_StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.text_gBox.SuspendLayout();
            this.Macro_StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(105, 235);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 23);
            this.Save_Btn.TabIndex = 0;
            this.Save_Btn.TabStop = false;
            this.Save_Btn.Text = "저장";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // macro1_tBox
            // 
            this.macro1_tBox.Location = new System.Drawing.Point(90, 30);
            this.macro1_tBox.Name = "macro1_tBox";
            this.macro1_tBox.Size = new System.Drawing.Size(229, 21);
            this.macro1_tBox.TabIndex = 4;
            // 
            // macro2_tBox
            // 
            this.macro2_tBox.Location = new System.Drawing.Point(90, 70);
            this.macro2_tBox.Name = "macro2_tBox";
            this.macro2_tBox.Size = new System.Drawing.Size(229, 21);
            this.macro2_tBox.TabIndex = 5;
            // 
            // macro3_tBox
            // 
            this.macro3_tBox.Location = new System.Drawing.Point(90, 110);
            this.macro3_tBox.Name = "macro3_tBox";
            this.macro3_tBox.Size = new System.Drawing.Size(229, 21);
            this.macro3_tBox.TabIndex = 6;
            // 
            // macro4_tBox
            // 
            this.macro4_tBox.Location = new System.Drawing.Point(90, 150);
            this.macro4_tBox.Name = "macro4_tBox";
            this.macro4_tBox.Size = new System.Drawing.Size(229, 21);
            this.macro4_tBox.TabIndex = 7;
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.Location = new System.Drawing.Point(201, 235);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_Btn.TabIndex = 8;
            this.Submit_Btn.TabStop = false;
            this.Submit_Btn.Text = "확인";
            this.Submit_Btn.UseVisualStyleBackColor = true;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // text_gBox
            // 
            this.text_gBox.Controls.Add(this.label4);
            this.text_gBox.Controls.Add(this.label3);
            this.text_gBox.Controls.Add(this.label2);
            this.text_gBox.Controls.Add(this.label1);
            this.text_gBox.Controls.Add(this.macro1_tBox);
            this.text_gBox.Controls.Add(this.macro2_tBox);
            this.text_gBox.Controls.Add(this.macro4_tBox);
            this.text_gBox.Controls.Add(this.macro3_tBox);
            this.text_gBox.Location = new System.Drawing.Point(12, 27);
            this.text_gBox.Name = "text_gBox";
            this.text_gBox.Size = new System.Drawing.Size(332, 191);
            this.text_gBox.TabIndex = 9;
            this.text_gBox.TabStop = false;
            this.text_gBox.Text = "하고싶은 말";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "매크로 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "매크로 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "매크로 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "매크로 1";
            // 
            // Macro_StatusStrip
            // 
            this.Macro_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Macro_StatusLabel1});
            this.Macro_StatusStrip.Location = new System.Drawing.Point(0, 269);
            this.Macro_StatusStrip.Name = "Macro_StatusStrip";
            this.Macro_StatusStrip.Size = new System.Drawing.Size(373, 22);
            this.Macro_StatusStrip.SizingGrip = false;
            this.Macro_StatusStrip.TabIndex = 10;
            // 
            // Macro_StatusLabel1
            // 
            this.Macro_StatusLabel1.Name = "Macro_StatusLabel1";
            this.Macro_StatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MacroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 291);
            this.Controls.Add(this.Macro_StatusStrip);
            this.Controls.Add(this.text_gBox);
            this.Controls.Add(this.Submit_Btn);
            this.Controls.Add(this.Save_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MacroForm";
            this.Text = "매크로 설정 창";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MacroForm_Load);
            this.text_gBox.ResumeLayout(false);
            this.text_gBox.PerformLayout();
            this.Macro_StatusStrip.ResumeLayout(false);
            this.Macro_StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.TextBox macro1_tBox;
        private System.Windows.Forms.TextBox macro2_tBox;
        private System.Windows.Forms.TextBox macro3_tBox;
        private System.Windows.Forms.TextBox macro4_tBox;
        private System.Windows.Forms.Button Submit_Btn;
        private System.Windows.Forms.GroupBox text_gBox;
        private System.Windows.Forms.StatusStrip Macro_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Macro_StatusLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}