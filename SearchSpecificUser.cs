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
    public partial class SearchSpecificUser : Form
    {
        Home homeReff;
        public SearchSpecificUser(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void SearchUserBtn_Click(object sender, EventArgs e)
        {
            string idTxt = UserIDTxt.Text;
            try {
                int id = int.Parse(idTxt);
                List<UserObj> tmp = new List<UserObj>();
                UserObj user = homeReff.getUser(id);
                if (user.getName() != null)
                {
                    tmp.Add(user);
                    UsersList usersListForm = new UsersList(tmp);
                    usersListForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex) {
                Console.Write(ex);
            }
        }

        private void UserIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
