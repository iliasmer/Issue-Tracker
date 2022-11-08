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
    public partial class IssueHub : Form
    {
        Home homeReff;
        List<IssueObj> issuesList = new List<IssueObj>();
        public IssueHub(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void AddIssueBtn_Click(object sender, EventArgs e)
        {
            AddIssue addIssueForm = new AddIssue(homeReff);
            addIssueForm.Show();
        }

        private void GetAllIssuesBtn_Click(object sender, EventArgs e)
        {
            issuesList = homeReff.getIssues();
            IssuesList issuesListForm = new IssuesList(issuesList);
            issuesListForm.Show();
        }

        private void SetIssueStateBtn_Click(object sender, EventArgs e)
        {
            SetIssueState issueStateForm = new SetIssueState(homeReff);
            issueStateForm.Show();
        }

        private void GetSpecificIssueBtn_Click(object sender, EventArgs e)
        {
            SearchSpecificIssue searchIssueForm = new SearchSpecificIssue(homeReff);
            searchIssueForm.Show();
        }

        private void SetParentIssueBtn_Click(object sender, EventArgs e)
        {
            issuesList = homeReff.getIssues();
            List<Tuple<int, string>> allIDsList = getAllIDs(issuesList);
            SetParentIssueID setParentIssueForm = new SetParentIssueID(allIDsList, homeReff);
            setParentIssueForm.Show();
        }

        private List<Tuple<int, string>> getAllIDs(List<IssueObj> issuesList) {
            var allIDsList = new List<Tuple<int, string>>(){};

            for (int i = 0; i < issuesList.Count; i++) {
                allIDsList.Add(new Tuple<int, string>(issuesList[i].getIssueID(), issuesList[i].getType()));
            }
            return allIDsList;
        }

        private void AssignUserToIssueBtn_Click(object sender, EventArgs e)
        {
            issuesList = homeReff.getIssues();
            List<Tuple<int, string>> allIDsList = getAllIDs(issuesList);
            AssignUserToIssue assignUserToIssueForm = new AssignUserToIssue(allIDsList, homeReff);
            assignUserToIssueForm.Show();
        }

        private void RemoveIssueBtn_Click(object sender, EventArgs e)
        {
            RemoveIssue removeIssueForm = new RemoveIssue(homeReff);
            removeIssueForm.Show();
        }
    }
}
