using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class User
    {
        private int Friends;

        public string Username { get; set; }
       
        public int NumberOfFriends { get { return Friends; } }

        public string favoriteColor { get; set; }
        public string name { get; set; }
        public string height { get; set; }

        private int money;
        public List<string> postList;
        public void addFriend()
        {
            Friends++;
        }
        
        public void removeFriend()
        {
            Friends--;
        }
        
        public User(string username, Dictionary<string, string> profiles)
        {
            Username = username;
            Friends = 0;
            money = 0;
        }

        
        public bool addMoney(int addmon)
        {
            money = money + addmon;
            return true;
        }




        public bool removeMoney(int removemon)
        {
            if (money - removemon < 0)
            {
                return false;
            }
            else
            {
                money = money - removemon;
                return true;
            }
            
        }
        
        
        public User(string username)
        {
            Username = username;
        }

        public override bool Equals(object obj)
        {
            if(this.GetType() != obj.GetType())
            {
                return false;
            }
            User other = (User)obj;
            return other.Username == this.Username;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
       
    
    
    }
}
