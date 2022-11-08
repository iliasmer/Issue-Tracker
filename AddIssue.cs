using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTracker
{
    public partial class AddIssue : Form
    {
        Home homeReff;
        public AddIssue(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void SubmitIssueBtn_Click(object sender, EventArgs e)
        {
            string issueName = IssueTitleTxt.Text;
            string issueType = IssueTypeComboBox.Text;

            if (issueName != null && issueName != "" & issueType != null && issueType != "") {
                homeReff.addIssue(issueName, issueType);
                this.Close();
            }
        }
    }
}
