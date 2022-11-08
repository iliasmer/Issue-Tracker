
namespace IssueTracker
{
    partial class SearchSpecificUser
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
            this.UserIDTxt = new System.Windows.Forms.TextBox();
            this.SearchUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search a User by ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserIDTxt
            // 
            this.UserIDTxt.Location = new System.Drawing.Point(110, 123);
            this.UserIDTxt.Name = "UserIDTxt";
            this.UserIDTxt.Size = new System.Drawing.Size(130, 22);
            this.UserIDTxt.TabIndex = 1;
            this.UserIDTxt.TextChanged += new System.EventHandler(this.UserIDTxt_TextChanged);
            // 
            // SearchUserBtn
            // 
            this.SearchUserBtn.Location = new System.Drawing.Point(108, 191);
            this.SearchUserBtn.Name = "SearchUserBtn";
            this.SearchUserBtn.Size = new System.Drawing.Size(128, 48);
            this.SearchUserBtn.TabIndex = 2;
            this.SearchUserBtn.Text = "Search";
            this.SearchUserBtn.UseVisualStyleBackColor = true;
            this.SearchUserBtn.Click += new System.EventHandler(this.SearchUserBtn_Click);
            // 
            // SearchSpecificUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 326);
            this.Controls.Add(this.SearchUserBtn);
            this.Controls.Add(this.UserIDTxt);
            this.Controls.Add(this.label1);
            this.Name = "SearchSpecificUser";
            this.Text = "SearchSpecificUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserIDTxt;
        private System.Windows.Forms.Button SearchUserBtn;
    }
}