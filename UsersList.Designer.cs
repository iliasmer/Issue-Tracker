
namespace IssueTracker
{
    partial class UsersList
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
            this.UserListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // UserListView
            // 
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(195, 22);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(271, 426);
            this.UserListView.TabIndex = 2;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            // 
            // UsersList
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 471);
            this.Controls.Add(this.UserListView);
            this.Name = "UsersList";
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.UsersList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView UserListView;
    }
}