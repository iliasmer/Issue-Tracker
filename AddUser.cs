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
    public partial class AddUser : Form
    {
        private Home homeReff;
        public AddUser(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void SubmitUserBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxt.Text;
            if (userName != null && userName != "") {
                homeReff.addUser(userName);
                this.Close();
            }
        }
    }
}
