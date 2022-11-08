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
    public partial class SetParentIssueID : Form
    {

        List<Tuple<int, string>> allIDsList;
        Home homeReff;
        public SetParentIssueID(List<Tuple<int, string>> allIDsList, Home homeReff)
        {
            this.allIDsList = allIDsList;
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void SetParentIssueID_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < allIDsList.Count; i++) {
                ParentIssueIDComboBox.Items.Add(allIDsList[i]);
                IssueIDComboBox.Items.Add(allIDsList[i]);
            }
        }

        private void SubmitParentIDBtn_Click(object sender, EventArgs e)
        {
            try {
                Tuple<int, string> parentIssue = (Tuple<int, string>)ParentIssueIDComboBox.SelectedItem;
                Tuple<int, string> issue = (Tuple<int, string>)IssueIDComboBox.SelectedItem;
                
                int parentIssueID = parentIssue.Item1;
                int issueID = issue.Item1;

                string type = issue.Item2;
                string parentType = parentIssue.Item2;

                if (issueID != parentIssueID) {
                    if (checkValidType(type, parentType)) {
                        homeReff.setParentIssue(issueID, parentIssueID);
                        this.Close();
                    }                
                }
            }
            catch (Exception ex) {
                Console.Write(ex);
            }
        }

        private bool checkValidType(string type, string parentType) {
            bool isOkay = false;
            if (type == "Task") {
                if (parentType == "Story" || parentType == "Epic") {
                    isOkay = true;
                }
            }
            if (type == "Story") {
                if (parentType == "Epic") {
                    isOkay = true;
                }
            }

            return isOkay;
        }
    }
}
