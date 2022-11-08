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
    public partial class SearchSpecificIssue : Form
    {
        Home homeReff;
        public SearchSpecificIssue(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void SearchIssueBtn_Click(object sender, EventArgs e)
        {
            string idTxt = IssueIDTxt.Text;
            try
            {
                int id = int.Parse(idTxt); 
                List<IssueObj> tmp = new List<IssueObj>();
                IssueObj issue = homeReff.getIssue(id);
                if (issue.getState() != null) {
                    tmp.Add(issue);
                    IssuesList issuesListForm = new IssuesList(tmp);
                    issuesListForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
