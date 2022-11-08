
namespace IssueTracker
{
    partial class AddIssue
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
            this.IssueTitleTxt = new System.Windows.Forms.TextBox();
            this.IssueTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitIssueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Issue Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Issue Type";
            // 
            // IssueTitleTxt
            // 
            this.IssueTitleTxt.Location = new System.Drawing.Point(102, 114);
            this.IssueTitleTxt.Name = "IssueTitleTxt";
            this.IssueTitleTxt.Size = new System.Drawing.Size(546, 22);
            this.IssueTitleTxt.TabIndex = 2;
            // 
            // IssueTypeComboBox
            // 
            this.IssueTypeComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IssueTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IssueTypeComboBox.FormattingEnabled = true;
            this.IssueTypeComboBox.Items.AddRange(new object[] {
            "Task",
            "Story",
            "Epic"});
            this.IssueTypeComboBox.Location = new System.Drawing.Point(102, 222);
            this.IssueTypeComboBox.Name = "IssueTypeComboBox";
            this.IssueTypeComboBox.Size = new System.Drawing.Size(219, 24);
            this.IssueTypeComboBox.TabIndex = 3;
            // 
            // SubmitIssueBtn
            // 
            this.SubmitIssueBtn.Location = new System.Drawing.Point(102, 309);
            this.SubmitIssueBtn.Name = "SubmitIssueBtn";
            this.SubmitIssueBtn.Size = new System.Drawing.Size(147, 57);
            this.SubmitIssueBtn.TabIndex = 4;
            this.SubmitIssueBtn.Text = "Submit Issue";
            this.SubmitIssueBtn.UseVisualStyleBackColor = true;
            this.SubmitIssueBtn.Click += new System.EventHandler(this.SubmitIssueBtn_Click);
            // 
            // AddIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitIssueBtn);
            this.Controls.Add(this.IssueTypeComboBox);
            this.Controls.Add(this.IssueTitleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddIssue";
            this.Text = "AddIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IssueTitleTxt;
        private System.Windows.Forms.ComboBox IssueTypeComboBox;
        private System.Windows.Forms.Button SubmitIssueBtn;
    }
}