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
    public partial class SetIssueState : Form
    {
        Home homeReff;
        public SetIssueState(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void SubmitStateBtn_Click(object sender, EventArgs e)
        {

            try {
                int issueID = int.Parse(IssueIDTxt.Text);
                string state = IssueStateComboBox.Text;

                if (state != null && state != "")
                {
                    homeReff.setIssueState(issueID, state);
                    this.Close();
                }
            }
            catch (Exception ex) {
                Console.Write(ex);
            }

            
        }
    }
}
