using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker
{
    public class IssueObj
    {
        int issueID;
        DateTime timestamp;
        string state;
        string type;
        int parentID;
        string title;
        int userID;

        public int getUserID() {
            return userID;
        }

        public void setUserID(int userID) {
            this.userID = userID;
        }

        public int getIssueID() {
            return issueID;
        }

        public void setIssueID(int issueID) {
            this.issueID = issueID;
        }

        public DateTime getTimestamp() {
            return timestamp;
        }

        public void setTimestamp(DateTime timestamp) {
            this.timestamp = timestamp;
        }

        public string getState() {
            return state;
        }

        public void setState(string state) {
            this.state = state; 
        }

        public string getType() {
            return type;
        }

        public void setType(string type) {
            this.type = type;
        }

        public int getParentID() {
            return parentID;
        }

        public void setParentID(int parentID) {
            this.parentID = parentID;
        }

        public string getTitle() {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }
    }
    
}
