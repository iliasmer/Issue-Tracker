
namespace IssueTracker
{
    partial class RemoveIssue
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
            this.label1 = new System.Windows.Forms.Label();
            this.IssueIDTxt = new System.Windows.Forms.TextBox();
            this.RemoveIssueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type in the ID of an Issue to Remove";
            // 
            // IssueIDTxt
            // 
            this.IssueIDTxt.Location = new System.Drawing.Point(104, 110);
            this.IssueIDTxt.Name = "IssueIDTxt";
            this.IssueIDTxt.Size = new System.Drawing.Size(238, 22);
            this.IssueIDTxt.TabIndex = 1;
            // 
            // RemoveIssueBtn
            // 
            this.RemoveIssueBtn.Location = new System.Drawing.Point(141, 187);
            this.RemoveIssueBtn.Name = "RemoveIssueBtn";
            this.RemoveIssueBtn.Size = new System.Drawing.Size(153, 47);
            this.RemoveIssueBtn.TabIndex = 2;
            this.RemoveIssueBtn.Text = "Remove Issue";
            this.RemoveIssueBtn.UseVisualStyleBackColor = true;
            this.RemoveIssueBtn.Click += new System.EventHandler(this.RemoveIssueBtn_Click);
            // 
            // RemoveIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 321);
            this.Controls.Add(this.RemoveIssueBtn);
            this.Controls.Add(this.IssueIDTxt);
            this.Controls.Add(this.label1);
            this.Name = "RemoveIssue";
            this.Text = "Remove Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IssueIDTxt;
        private System.Windows.Forms.Button RemoveIssueBtn;
    }
}