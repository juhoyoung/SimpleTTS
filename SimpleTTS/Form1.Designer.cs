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
            this.OpenMacro_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenMacro_Btn
            // 
            this.OpenMacro_Btn.Location = new System.Drawing.Point(13, 24);
            this.OpenMacro_Btn.Name = "OpenMacro_Btn";
            this.OpenMacro_Btn.Size = new System.Drawing.Size(95, 23);
            this.OpenMacro_Btn.TabIndex = 0;
            this.OpenMacro_Btn.Text = "매크로 설정";
            this.OpenMacro_Btn.UseVisualStyleBackColor = true;
            this.OpenMacro_Btn.Click += new System.EventHandler(this.OpenMacro_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 201);
            this.Controls.Add(this.OpenMacro_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "이거라도 해라";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Macro1_btn;
        private System.Windows.Forms.Button OpenMacro_Btn;
    }
}

