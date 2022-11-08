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
    public partial class UsersList : Form
    {
        List<UserObj> allUsersList;
        public UsersList(List<UserObj> allUsersList)
        {
            this.allUsersList = allUsersList;
            InitializeComponent();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {

            UserListView.View = View.Details;
            UserListView.GridLines = true;
            UserListView.FullRowSelect = true;
            UserListView.Columns.Add("User ID", 100);
            UserListView.Columns.Add("User Name", 100);

            ListViewItem item;
            UserObj user;
            for (int i = 0; i < allUsersList.Count; i++) {
                user = allUsersList[i]; 
                string[] arg = new string[2];
                arg[0] = user.getID().ToString();
                arg[1] = user.getName().ToString();
                item = new ListViewItem(arg);
                UserListView.Items.Add(item);
            }
     
        }
    }
}
