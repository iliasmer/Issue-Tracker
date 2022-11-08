
namespace IssueTracker
{
    partial class Home
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
            this.UserHubBtn = new System.Windows.Forms.Button();
            this.IssueHubBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserHubBtn
            // 
            this.UserHubBtn.Location = new System.Drawing.Point(108, 93);
            this.UserHubBtn.Name = "UserHubBtn";
            this.UserHubBtn.Size = new System.Drawing.Size(239, 75);
            this.UserHubBtn.TabIndex = 0;
            this.UserHubBtn.Text = "User Hub";
            this.UserHubBtn.UseVisualStyleBackColor = true;
            this.UserHubBtn.Click += new System.EventHandler(this.UserHubBtn_Click);
            // 
            // IssueHubBtn
            // 
            this.IssueHubBtn.Location = new System.Drawing.Point(389, 93);
            this.IssueHubBtn.Name = "IssueHubBtn";
            this.IssueHubBtn.Size = new System.Drawing.Size(239, 75);
            this.IssueHubBtn.TabIndex = 1;
            this.IssueHubBtn.Text = "Issue Hub";
            this.IssueHubBtn.UseVisualStyleBackColor = true;
            this.IssueHubBtn.Click += new System.EventHandler(this.IssueHubBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 286);
            this.Controls.Add(this.IssueHubBtn);
            this.Controls.Add(this.UserHubBtn);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserHubBtn;
        private System.Windows.Forms.Button IssueHubBtn;
    }
}

