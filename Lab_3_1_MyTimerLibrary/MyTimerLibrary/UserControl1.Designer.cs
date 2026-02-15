namespace MyTimerLibrary
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlTimer1 = new MyTimerLibrary.UserControlTimer();
            this.SuspendLayout();
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Location = new System.Drawing.Point(29, 27);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(89, 36);
            this.userControlTimer1.TabIndex = 0;
            this.userControlTimer1.TimeEnabled = true;
            this.userControlTimer1.Load += new System.EventHandler(this.userControlTimer1_Load);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlTimer1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer userControlTimer1;
    }
}
