
namespace IssueTracker
{
    partial class UserHub
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
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.RemoveUserBtn = new System.Windows.Forms.Button();
            this.GetUsersBtn = new System.Windows.Forms.Button();
            this.GetUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(89, 93);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(167, 66);
            this.AddUserBtn.TabIndex = 0;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.Location = new System.Drawing.Point(89, 189);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(167, 66);
            this.RemoveUserBtn.TabIndex = 1;
            this.RemoveUserBtn.Text = "Remove User";
            this.RemoveUserBtn.UseVisualStyleBackColor = true;
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // GetUsersBtn
            // 
            this.GetUsersBtn.Location = new System.Drawing.Point(294, 93);
            this.GetUsersBtn.Name = "GetUsersBtn";
            this.GetUsersBtn.Size = new System.Drawing.Size(167, 66);
            this.GetUsersBtn.TabIndex = 2;
            this.GetUsersBtn.Text = "Get List Of Users";
            this.GetUsersBtn.UseVisualStyleBackColor = true;
            this.GetUsersBtn.Click += new System.EventHandler(this.GetUsersBtn_Click);
            // 
            // GetUserBtn
            // 
            this.GetUserBtn.Location = new System.Drawing.Point(294, 189);
            this.GetUserBtn.Name = "GetUserBtn";
            this.GetUserBtn.Size = new System.Drawing.Size(167, 66);
            this.GetUserBtn.TabIndex = 3;
            this.GetUserBtn.Text = "Get A Specific User";
            this.GetUserBtn.UseVisualStyleBackColor = true;
            this.GetUserBtn.Click += new System.EventHandler(this.GetUserBtn_Click);
            // 
            // UserHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 368);
            this.Controls.Add(this.GetUserBtn);
            this.Controls.Add(this.GetUsersBtn);
            this.Controls.Add(this.RemoveUserBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Name = "UserHub";
            this.Text = "User Hub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button RemoveUserBtn;
        private System.Windows.Forms.Button GetUsersBtn;
        private System.Windows.Forms.Button GetUserBtn;
    }
}