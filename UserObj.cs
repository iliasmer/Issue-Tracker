using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker
{
    public class UserObj
    {
        int ID;
        string name;

        public int getID() {
            return ID;
        }

        public void setID(int ID) {
            this.ID = ID;
        }


        public string getName() {
            return name;
        }

        public void setName(string name) {
            this.name = name;
        }
    }

}
