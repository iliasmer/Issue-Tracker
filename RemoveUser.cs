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
    public partial class RemoveUser : Form
    {

        Home homeReff;
        public RemoveUser(Home homeReff)
        {
            this.homeReff = homeReff;
            InitializeComponent();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = int.Parse(userIDTxt.Text);
                homeReff.removeUser(userID);
            }
            catch (Exception ex) {
                Console.Write(ex);
            }
        }
    }
}
