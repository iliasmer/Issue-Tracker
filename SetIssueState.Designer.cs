
namespace IssueTracker
{
    partial class SetIssueState
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.IssueStateComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitStateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Issue\'s ID";
            // 
            // IssueIDTxt
            // 
            this.IssueIDTxt.Location = new System.Drawing.Point(40, 94);
            this.IssueIDTxt.Name = "IssueIDTxt";
            this.IssueIDTxt.Size = new System.Drawing.Size(225, 22);
            this.IssueIDTxt.TabIndex = 1;
            // 
            // IssueStateComboBox
            // 
            this.IssueStateComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IssueStateComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ToDo",
            "In Progress",
            "Done"});
            this.IssueStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IssueStateComboBox.FormattingEnabled = true;
            this.IssueStateComboBox.Items.AddRange(new object[] {
            "ToDo",
            "In Progress",
            "Done"});
            this.IssueStateComboBox.Location = new System.Drawing.Point(40, 171);
            this.IssueStateComboBox.Name = "IssueStateComboBox";
            this.IssueStateComboBox.Size = new System.Drawing.Size(225, 24);
            this.IssueStateComboBox.TabIndex = 4;
            // 
            // SubmitStateBtn
            // 
            this.SubmitStateBtn.Location = new System.Drawing.Point(89, 245);
            this.SubmitStateBtn.Name = "SubmitStateBtn";
            this.SubmitStateBtn.Size = new System.Drawing.Size(134, 43);
            this.SubmitStateBtn.TabIndex = 5;
            this.SubmitStateBtn.Text = "Submit State";
            this.SubmitStateBtn.UseVisualStyleBackColor = true;
            this.SubmitStateBtn.Click += new System.EventHandler(this.SubmitStateBtn_Click);
            // 
            // SetIssueState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 338);
            this.Controls.Add(this.SubmitStateBtn);
            this.Controls.Add(this.IssueStateComboBox);
            this.Controls.Add(this.IssueIDTxt);
            this.Controls.Add(this.label1);
            this.Name = "SetIssueState";
            this.Text = "SetIssue State";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IssueIDTxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox IssueStateComboBox;
        private System.Windows.Forms.Button SubmitStateBtn;
    }
}