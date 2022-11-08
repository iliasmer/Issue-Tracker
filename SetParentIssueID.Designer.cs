
namespace IssueTracker
{
    partial class SetParentIssueID
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
            this.SubmitParentIDBtn = new System.Windows.Forms.Button();
            this.ParentIssueIDComboBox = new System.Windows.Forms.ComboBox();
            this.IssueIDComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify Issue ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Specify Issue ID to be assigned as Parent (ID, Type)";
            // 
            // SubmitParentIDBtn
            // 
            this.SubmitParentIDBtn.Location = new System.Drawing.Point(51, 289);
            this.SubmitParentIDBtn.Name = "SubmitParentIDBtn";
            this.SubmitParentIDBtn.Size = new System.Drawing.Size(134, 43);
            this.SubmitParentIDBtn.TabIndex = 7;
            this.SubmitParentIDBtn.Text = "Submit";
            this.SubmitParentIDBtn.UseVisualStyleBackColor = true;
            this.SubmitParentIDBtn.Click += new System.EventHandler(this.SubmitParentIDBtn_Click);
            // 
            // ParentIssueIDComboBox
            // 
            this.ParentIssueIDComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ParentIssueIDComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ToDo",
            "In Progress",
            "Done"});
            this.ParentIssueIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParentIssueIDComboBox.FormattingEnabled = true;
            this.ParentIssueIDComboBox.Location = new System.Drawing.Point(51, 209);
            this.ParentIssueIDComboBox.Name = "ParentIssueIDComboBox";
            this.ParentIssueIDComboBox.Size = new System.Drawing.Size(225, 24);
            this.ParentIssueIDComboBox.TabIndex = 6;
            // 
            // IssueIDComboBox
            // 
            this.IssueIDComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IssueIDComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ToDo",
            "In Progress",
            "Done"});
            this.IssueIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IssueIDComboBox.FormattingEnabled = true;
            this.IssueIDComboBox.Location = new System.Drawing.Point(51, 90);
            this.IssueIDComboBox.Name = "IssueIDComboBox";
            this.IssueIDComboBox.Size = new System.Drawing.Size(225, 24);
            this.IssueIDComboBox.TabIndex = 8;
            // 
            // SetParentIssueID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IssueIDComboBox);
            this.Controls.Add(this.SubmitParentIDBtn);
            this.Controls.Add(this.ParentIssueIDComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetParentIssueID";
            this.Text = "Set Parent Issue ID";
            this.Load += new System.EventHandler(this.SetParentIssueID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitParentIDBtn;
        private System.Windows.Forms.ComboBox ParentIssueIDComboBox;
        private System.Windows.Forms.ComboBox IssueIDComboBox;
    }
}