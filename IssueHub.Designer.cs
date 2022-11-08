
namespace IssueTracker
{
    partial class IssueHub
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
            this.AddIssueBtn = new System.Windows.Forms.Button();
            this.RemoveIssueBtn = new System.Windows.Forms.Button();
            this.AssignUserToIssueBtn = new System.Windows.Forms.Button();
            this.GetAllIssuesBtn = new System.Windows.Forms.Button();
            this.SetIssueStateBtn = new System.Windows.Forms.Button();
            this.GetSpecificIssueBtn = new System.Windows.Forms.Button();
            this.SetParentIssueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddIssueBtn
            // 
            this.AddIssueBtn.Location = new System.Drawing.Point(84, 354);
            this.AddIssueBtn.Name = "AddIssueBtn";
            this.AddIssueBtn.Size = new System.Drawing.Size(439, 56);
            this.AddIssueBtn.TabIndex = 0;
            this.AddIssueBtn.Text = "Add Issue";
            this.AddIssueBtn.UseVisualStyleBackColor = true;
            this.AddIssueBtn.Click += new System.EventHandler(this.AddIssueBtn_Click);
            // 
            // RemoveIssueBtn
            // 
            this.RemoveIssueBtn.Location = new System.Drawing.Point(326, 262);
            this.RemoveIssueBtn.Name = "RemoveIssueBtn";
            this.RemoveIssueBtn.Size = new System.Drawing.Size(197, 56);
            this.RemoveIssueBtn.TabIndex = 1;
            this.RemoveIssueBtn.Text = "Remove Issue";
            this.RemoveIssueBtn.UseVisualStyleBackColor = true;
            this.RemoveIssueBtn.Click += new System.EventHandler(this.RemoveIssueBtn_Click);
            // 
            // AssignUserToIssueBtn
            // 
            this.AssignUserToIssueBtn.Location = new System.Drawing.Point(84, 262);
            this.AssignUserToIssueBtn.Name = "AssignUserToIssueBtn";
            this.AssignUserToIssueBtn.Size = new System.Drawing.Size(197, 56);
            this.AssignUserToIssueBtn.TabIndex = 2;
            this.AssignUserToIssueBtn.Text = "Assign User to Issue";
            this.AssignUserToIssueBtn.UseVisualStyleBackColor = true;
            this.AssignUserToIssueBtn.Click += new System.EventHandler(this.AssignUserToIssueBtn_Click);
            // 
            // GetAllIssuesBtn
            // 
            this.GetAllIssuesBtn.Location = new System.Drawing.Point(84, 57);
            this.GetAllIssuesBtn.Name = "GetAllIssuesBtn";
            this.GetAllIssuesBtn.Size = new System.Drawing.Size(197, 56);
            this.GetAllIssuesBtn.TabIndex = 3;
            this.GetAllIssuesBtn.Text = "Get All Issues";
            this.GetAllIssuesBtn.UseVisualStyleBackColor = true;
            this.GetAllIssuesBtn.Click += new System.EventHandler(this.GetAllIssuesBtn_Click);
            // 
            // SetIssueStateBtn
            // 
            this.SetIssueStateBtn.Location = new System.Drawing.Point(84, 160);
            this.SetIssueStateBtn.Name = "SetIssueStateBtn";
            this.SetIssueStateBtn.Size = new System.Drawing.Size(197, 56);
            this.SetIssueStateBtn.TabIndex = 4;
            this.SetIssueStateBtn.Text = "Set Issue State";
            this.SetIssueStateBtn.UseVisualStyleBackColor = true;
            this.SetIssueStateBtn.Click += new System.EventHandler(this.SetIssueStateBtn_Click);
            // 
            // GetSpecificIssueBtn
            // 
            this.GetSpecificIssueBtn.Location = new System.Drawing.Point(326, 57);
            this.GetSpecificIssueBtn.Name = "GetSpecificIssueBtn";
            this.GetSpecificIssueBtn.Size = new System.Drawing.Size(197, 56);
            this.GetSpecificIssueBtn.TabIndex = 5;
            this.GetSpecificIssueBtn.Text = "Get a Specific Issue";
            this.GetSpecificIssueBtn.UseVisualStyleBackColor = true;
            this.GetSpecificIssueBtn.Click += new System.EventHandler(this.GetSpecificIssueBtn_Click);
            // 
            // SetParentIssueBtn
            // 
            this.SetParentIssueBtn.Location = new System.Drawing.Point(326, 160);
            this.SetParentIssueBtn.Name = "SetParentIssueBtn";
            this.SetParentIssueBtn.Size = new System.Drawing.Size(197, 56);
            this.SetParentIssueBtn.TabIndex = 6;
            this.SetParentIssueBtn.Text = "Set Parent Issue";
            this.SetParentIssueBtn.UseVisualStyleBackColor = true;
            this.SetParentIssueBtn.Click += new System.EventHandler(this.SetParentIssueBtn_Click);
            // 
            // IssueHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 467);
            this.Controls.Add(this.SetParentIssueBtn);
            this.Controls.Add(this.GetSpecificIssueBtn);
            this.Controls.Add(this.SetIssueStateBtn);
            this.Controls.Add(this.GetAllIssuesBtn);
            this.Controls.Add(this.AssignUserToIssueBtn);
            this.Controls.Add(this.RemoveIssueBtn);
            this.Controls.Add(this.AddIssueBtn);
            this.Name = "IssueHub";
            this.Text = "Issue Hub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddIssueBtn;
        private System.Windows.Forms.Button RemoveIssueBtn;
        private System.Windows.Forms.Button AssignUserToIssueBtn;
        private System.Windows.Forms.Button GetAllIssuesBtn;
        private System.Windows.Forms.Button SetIssueStateBtn;
        private System.Windows.Forms.Button GetSpecificIssueBtn;
        private System.Windows.Forms.Button SetParentIssueBtn;
    }
}