namespace SimpleTTS
{
    partial class ChatingForm
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
            this.chat_tBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chat_tBox
            // 
            this.chat_tBox.Location = new System.Drawing.Point(1, 1);
            this.chat_tBox.Margin = new System.Windows.Forms.Padding(0);
            this.chat_tBox.Name = "chat_tBox";
            this.chat_tBox.Size = new System.Drawing.Size(375, 21);
            this.chat_tBox.TabIndex = 0;
            // 
            // ChatingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(378, 24);
            this.Controls.Add(this.chat_tBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ChatingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ChatingForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChatingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chat_tBox;
    }
}