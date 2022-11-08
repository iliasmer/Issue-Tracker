
namespace IssueTracker
{
    partial class IssuesList
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
            this.IssuesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // IssuesListView
            // 
            this.IssuesListView.HideSelection = false;
            this.IssuesListView.Location = new System.Drawing.Point(33, 25);
            this.IssuesListView.Name = "IssuesListView";
            this.IssuesListView.Size = new System.Drawing.Size(922, 399);
            this.IssuesListView.TabIndex = 0;
            this.IssuesListView.UseCompatibleStateImageBehavior = false;
            // 
            // IssuesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.IssuesListView);
            this.Name = "IssuesList";
            this.Text = "Issues List";
            this.Load += new System.EventHandler(this.IssuesList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView IssuesListView;
    }
}