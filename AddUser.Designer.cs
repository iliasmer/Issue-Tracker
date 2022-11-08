
namespace IssueTracker
{
    partial class AddUser
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
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.SubmitUserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserNameTxt.Location = new System.Drawing.Point(101, 74);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(253, 22);
            this.UserNameTxt.TabIndex = 0;
            // 
            // SubmitUserBtn
            // 
            this.SubmitUserBtn.Location = new System.Drawing.Point(166, 120);
            this.SubmitUserBtn.Name = "SubmitUserBtn";
            this.SubmitUserBtn.Size = new System.Drawing.Size(117, 35);
            this.SubmitUserBtn.TabIndex = 1;
            this.SubmitUserBtn.Text = "Submit";
            this.SubmitUserBtn.UseVisualStyleBackColor = true;
            this.SubmitUserBtn.Click += new System.EventHandler(this.SubmitUserBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type the user\'s name..";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitUserBtn);
            this.Controls.Add(this.UserNameTxt);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Button SubmitUserBtn;
        private System.Windows.Forms.Label label1;
    }
}