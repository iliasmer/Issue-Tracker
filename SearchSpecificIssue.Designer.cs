
namespace IssueTracker
{
    partial class SearchSpecificIssue
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
            this.SearchIssueBtn = new System.Windows.Forms.Button();
            this.IssueIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchIssueBtn
            // 
            this.SearchIssueBtn.Location = new System.Drawing.Point(53, 161);
            this.SearchIssueBtn.Name = "SearchIssueBtn";
            this.SearchIssueBtn.Size = new System.Drawing.Size(128, 48);
            this.SearchIssueBtn.TabIndex = 5;
            this.SearchIssueBtn.Text = "Search";
            this.SearchIssueBtn.UseVisualStyleBackColor = true;
            this.SearchIssueBtn.Click += new System.EventHandler(this.SearchIssueBtn_Click);
            // 
            // IssueIDTxt
            // 
            this.IssueIDTxt.Location = new System.Drawing.Point(55, 93);
            this.IssueIDTxt.Name = "IssueIDTxt";
            this.IssueIDTxt.Size = new System.Drawing.Size(130, 22);
            this.IssueIDTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search an Issue by ID";
            // 
            // SearchSpecificIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 280);
            this.Controls.Add(this.SearchIssueBtn);
            this.Controls.Add(this.IssueIDTxt);
            this.Controls.Add(this.label1);
            this.Name = "SearchSpecificIssue";
            this.Text = "SearchSpecificIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchIssueBtn;
        private System.Windows.Forms.TextBox IssueIDTxt;
        private System.Windows.Forms.Label label1;
    }
}