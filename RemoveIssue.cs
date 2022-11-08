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
    public partial class RemoveIssue : Form
    {
        Home homeReff;
        public RemoveIssue(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void RemoveIssueBtn_Click(object sender, EventArgs e)
        {
            try {
                int issueID = int.Parse(IssueIDTxt.Text);
                homeReff.removeIssue(issueID);
            }
            catch (Exception ex) {
                Console.Write(ex);
            }
        }
    }
}
