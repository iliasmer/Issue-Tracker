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
    public partial class AssignUserToIssue : Form
    {
        Home homeReff;
        List<Tuple<int, string>> allIDsList;
        List<UserObj> allUsers;
        public AssignUserToIssue(List<Tuple<int, string>> allIDsList, Home homeReff)
        {
            this.homeReff = homeReff;
            this.allIDsList = allIDsList;
            InitializeComponent();
        }

        private void AssignUserToIssueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Tuple<int, string> user = (Tuple<int, string>)UsersComboBox.SelectedItem;
                Tuple<int, string> issue = (Tuple<int, string>)IssuesComboBox.SelectedItem;

                int userID = user.Item1;
                int issueID = issue.Item1;

                homeReff.assignUser(userID, issueID);
                this.Close();
            }
            catch (Exception ex) {
                Console.Write(ex);
            }
        }

        private void AssignUserToIssue_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < allIDsList.Count; i++)
            {
                IssuesComboBox.Items.Add(allIDsList[i]);
            }

            allUsers = homeReff.getUsers();
            for (int i = 0; i < allUsers.Count; i++) {
                UsersComboBox.Items.Add(new Tuple<int, string>(allUsers[i].getID(), allUsers[i].getName()));
            }
        }
    }
}
