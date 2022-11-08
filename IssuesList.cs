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
    public partial class IssuesList : Form
    {
        List<IssueObj> allIssuesList;
        public IssuesList(List<IssueObj> allIssuesList)
        {
            this.allIssuesList = allIssuesList;
            InitializeComponent();
        }

        private void IssuesList_Load(object sender, EventArgs e)
        {
            IssuesListView.View = View.Details;
            IssuesListView.GridLines = true;
            IssuesListView.FullRowSelect = true;
            IssuesListView.Columns.Add("ID", 100);
            IssuesListView.Columns.Add("Parent ID", 100);
            IssuesListView.Columns.Add("Title", 100);
            IssuesListView.Columns.Add("Type", 100);
            IssuesListView.Columns.Add("State", 100);
            IssuesListView.Columns.Add("Timestamp", 100);
            IssuesListView.Columns.Add("User", 100);

            ListViewItem item;
            IssueObj issue;
            for (int i = 0; i < allIssuesList.Count; i++)
            {
                issue = allIssuesList[i];
                string[] arg = new string[7];
                arg[0] = issue.getIssueID().ToString();
                arg[1] = issue.getParentID().ToString();
                arg[2] = issue.getTitle().ToString();
                arg[3] = issue.getType().ToString();
                arg[4] = issue.getState().ToString();
                arg[5] = issue.getTimestamp().ToString();
                arg[6] = issue.getUserID().ToString();
                item = new ListViewItem(arg);
                IssuesListView.Items.Add(item);
            }
        }
    }
}
