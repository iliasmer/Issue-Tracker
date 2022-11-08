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
    public partial class UserHub : Form
    {

        private Home homeReff;
        List<UserObj> allUsersList = new List<UserObj>();
        public UserHub(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser(homeReff);
            addUserForm.Show();
        }

        private void GetUsersBtn_Click(object sender, EventArgs e)
        {
            allUsersList = homeReff.getUsers();
            UsersList usersListForm = new UsersList(allUsersList);
            usersListForm.Show();

        }

        private void GetUserBtn_Click(object sender, EventArgs e)
        {
            allUsersList = homeReff.getUsers();
            SearchSpecificUser searchUserForm = new SearchSpecificUser(homeReff);
            searchUserForm.Show();

        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            RemoveUser removeUserForm = new RemoveUser(homeReff);
            removeUserForm.Show();
        }
    }
}
