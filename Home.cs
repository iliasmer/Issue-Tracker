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
    public partial class Home : Form
    {

        int userIDCount = -1;
        int issueIDCount = -1;
        List<UserObj> usersList = new List<UserObj>();
        List<IssueObj> issuesList = new List<IssueObj>();
        public Home()
        {
            InitializeComponent();
        }

        public void addUser(string name) {
            userIDCount++;
            UserObj user = new UserObj();
            user.setID(userIDCount);
            user.setName(name);
            usersList.Add(user);
        }

        public void addIssue(string title, string type) {
            issueIDCount++;
            IssueObj issue = new IssueObj();
            issue.setIssueID(issueIDCount);
            issue.setParentID(-1);
            issue.setTimestamp(new DateTime());
            issue.setState("ToDo");
            issue.setType(type);
            issue.setTitle(title);
            issue.setUserID(-1);
            issuesList.Add(issue);
        }

        public void setIssueState(int issueID, string state) {
            for (int i = 0; i < issuesList.Count; i++)
            {
                if (issuesList[i].getIssueID() == issueID)
                {
                    issuesList[i].setState(state);
                }
            }
        }

        public void setParentIssue(int issueID, int parentIssueID) {
            for (int i = 0; i < issuesList.Count; i++)
            {
                if (issuesList[i].getIssueID() == issueID)
                {
                    issuesList[i].setParentID(parentIssueID);
                }
            }
        }

        public void assignUser(int userID, int issueID) {
            for (int i = 0; i < issuesList.Count; i++) {
                if (issuesList[i].getIssueID() == issueID) {
                    issuesList[i].setUserID(userID);
                }
            }
        }

        public void removeIssue(int issueID) {
            for (int i = 0; i < issuesList.Count; i++) {
                if (issuesList[i].getIssueID() == issueID) {

                    for (int j = 0; j < issuesList.Count; j++) {
                        //find all children of issueID
                        if (issuesList[j].getParentID() == issueID) {
                            if (issuesList[i].getParentID() == -1)
                            {
                                issuesList[j].setParentID(-1);
                            }
                            else {
                                issuesList[j].setParentID(issuesList[i].getParentID());
                            }
                        }
                    }
                    RemoveIssue removeIssueForm = (RemoveIssue)Application.OpenForms["RemoveIssue"];
                    removeIssueForm.Close();
                    issuesList.RemoveAt(i);
                    break;
                }
            }
        }

        public List<UserObj> getUsers() {
            return usersList;
        }

        public UserObj getUser(int userID)
        {
            UserObj user = new UserObj();
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].getID() == userID)
                {
                    user = usersList[i];
                    break;
                }
            }
            return user;
        }

        public List<IssueObj> getIssues() {
            return issuesList;
        }

        public IssueObj getIssue(int issueID) {
            IssueObj issue = new IssueObj();
            for (int i = 0; i < issuesList.Count; i++) {
                if (issuesList[i].getIssueID() == issueID) {
                    issue = issuesList[i];
                    break;
                }
            }
            return issue;
        }

        public void removeUser(int userID) {
            for (int i = 0; i < issuesList.Count; i++) {
                if (issuesList[i].getUserID() == userID) {
                    issuesList[i].setUserID(-1);
                }
            }
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].getID() == userID)
                {
                    RemoveUser removeUserForm = (RemoveUser)Application.OpenForms["RemoveUser"];
                    removeUserForm.Close();
                    usersList.RemoveAt(i);
                }
            }
        }

        public int incrementUserID () {
            userIDCount++;
            return userIDCount;
        }

        private void UserHubBtn_Click(object sender, EventArgs e)
        {
            UserHub userHub = new UserHub(this);
            userHub.Show();
        }

        private void IssueHubBtn_Click(object sender, EventArgs e)
        {
            IssueHub issueHub = new IssueHub(this);
            issueHub.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
