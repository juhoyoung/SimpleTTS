namespace SimpleTTS
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenMacro_Btn = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxt_Menu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Macro_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hide_Btn = new System.Windows.Forms.Button();
            this.OpenLang_Btn = new System.Windows.Forms.Button();
            this.ctxt_Menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenMacro_Btn
            // 
            this.OpenMacro_Btn.Location = new System.Drawing.Point(13, 75);
            this.OpenMacro_Btn.Name = "OpenMacro_Btn";
            this.OpenMacro_Btn.Size = new System.Drawing.Size(95, 23);
            this.OpenMacro_Btn.TabIndex = 1;
            this.OpenMacro_Btn.TabStop = false;
            this.OpenMacro_Btn.Text = "매크로 설정";
            this.OpenMacro_Btn.UseVisualStyleBackColor = true;
            this.OpenMacro_Btn.Click += new System.EventHandler(this.OpenMacro_Btn_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ctxt_Menu1;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "말하세요";
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // ctxt_Menu1
            // 
            this.ctxt_Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Macro_MenuItem,
            this.exit_MenuItem});
            this.ctxt_Menu1.Name = "ctxt_Menu1";
            this.ctxt_Menu1.Size = new System.Drawing.Size(139, 48);
            // 
            // Macro_MenuItem
            // 
            this.Macro_MenuItem.Name = "Macro_MenuItem";
            this.Macro_MenuItem.Size = new System.Drawing.Size(138, 22);
            this.Macro_MenuItem.Text = "매크로 설정";
            this.Macro_MenuItem.Click += new System.EventHandler(this.OpenMacro_Btn_Click);
            // 
            // exit_MenuItem
            // 
            this.exit_MenuItem.Name = "exit_MenuItem";
            this.exit_MenuItem.Size = new System.Drawing.Size(138, 22);
            this.exit_MenuItem.Text = "종료";
            this.exit_MenuItem.Click += new System.EventHandler(this.exit_MenuItem_Click);
            // 
            // Hide_Btn
            // 
            this.Hide_Btn.Location = new System.Drawing.Point(12, 125);
            this.Hide_Btn.Name = "Hide_Btn";
            this.Hide_Btn.Size = new System.Drawing.Size(96, 23);
            this.Hide_Btn.TabIndex = 2;
            this.Hide_Btn.TabStop = false;
            this.Hide_Btn.Text = "숨기기";
            this.Hide_Btn.UseVisualStyleBackColor = true;
            this.Hide_Btn.Click += new System.EventHandler(this.Hide_Btn_Click);
            // 
            // OpenLang_Btn
            // 
            this.OpenLang_Btn.Location = new System.Drawing.Point(12, 25);
            this.OpenLang_Btn.Name = "OpenLang_Btn";
            this.OpenLang_Btn.Size = new System.Drawing.Size(95, 23);
            this.OpenLang_Btn.TabIndex = 0;
            this.OpenLang_Btn.TabStop = false;
            this.OpenLang_Btn.Text = "언어 설정";
            this.OpenLang_Btn.UseVisualStyleBackColor = true;
            this.OpenLang_Btn.Click += new System.EventHandler(this.OpenLang_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(120, 201);
            this.Controls.Add(this.OpenLang_Btn);
            this.Controls.Add(this.Hide_Btn);
            this.Controls.Add(this.OpenMacro_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "이거라도 하셈";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ctxt_Menu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenMacro_Btn;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ctxt_Menu1;
        private System.Windows.Forms.ToolStripMenuItem exit_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Macro_MenuItem;
        private System.Windows.Forms.Button Hide_Btn;
        private System.Windows.Forms.Button OpenLang_Btn;
    }
}

