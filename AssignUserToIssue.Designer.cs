
namespace IssueTracker
{
    partial class AssignUserToIssue
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
            this.label2 = new System.Windows.Forms.Label();
            this.IssuesComboBox = new System.Windows.Forms.ComboBox();
            this.AssignUserToIssueBtn = new System.Windows.Forms.Button();
            this.UsersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select an Issue";
            // 
            // IssuesComboBox
            // 
            this.IssuesComboBox.FormattingEnabled = true;
            this.IssuesComboBox.Location = new System.Drawing.Point(68, 168);
            this.IssuesComboBox.Name = "IssuesComboBox";
            this.IssuesComboBox.Size = new System.Drawing.Size(166, 24);
            this.IssuesComboBox.TabIndex = 3;
            // 
            // AssignUserToIssueBtn
            // 
            this.AssignUserToIssueBtn.Location = new System.Drawing.Point(85, 244);
            this.AssignUserToIssueBtn.Name = "AssignUserToIssueBtn";
            this.AssignUserToIssueBtn.Size = new System.Drawing.Size(128, 43);
            this.AssignUserToIssueBtn.TabIndex = 4;
            this.AssignUserToIssueBtn.Text = "Assign";
            this.AssignUserToIssueBtn.UseVisualStyleBackColor = true;
            this.AssignUserToIssueBtn.Click += new System.EventHandler(this.AssignUserToIssueBtn_Click);
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Location = new System.Drawing.Point(68, 76);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Size = new System.Drawing.Size(166, 24);
            this.UsersComboBox.TabIndex = 5;
            // 
            // AssignUserToIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 342);
            this.Controls.Add(this.UsersComboBox);
            this.Controls.Add(this.AssignUserToIssueBtn);
            this.Controls.Add(this.IssuesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignUserToIssue";
            this.Text = "Assign User To Issue";
            this.Load += new System.EventHandler(this.AssignUserToIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox IssuesComboBox;
        private System.Windows.Forms.Button AssignUserToIssueBtn;
        private System.Windows.Forms.ComboBox UsersComboBox;
    }
}