using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class UserDS
    {
        //Store, remove, get, update
        //CRUD
        /*
         C - Create/Store
         R - read/get
         U - update
         D - delete/remove*/


        private Posts posts;
        private User user;
        private static List<UserDS> friends;
        //private static List<User> posts;
        //private bool isRoot;
        public UserDS(string username)
        {
            user = new User(username);
            friends = new List<UserDS>();
        }
        public void addFriend(UserDS friend)
        {
            friend.getUser.addFriend();
            this.user.addFriend();
            friends.Add(friend);
        }

        public void removeFriend(UserDS friend)
        {
            friend.getUser.removeFriend();
            this.user.removeFriend();
            friend.Friends.RemoveAll((x) => x.user == friend.user);
            friend.Friends.RemoveAll((x) => x.user == this.user);
        }

        public void updateUser(string username)
        {
            user.Username = username;
        }


        public bool isFriend(Predicate<UserDS> predicate)
        {
            if (friends.Exists(predicate))
            {
                return true;
            }
            else return false;
        }


        public UserDS findFriend(Predicate<UserDS> predicate)
        {
            return friends.Find(predicate);
            
        }
       
        public bool transfer(int money, UserDS user)
        {
            if (this.user.removeMoney(money))
            {
                return user.getUser.addMoney(money);
            }
            else
            {
                return false;
            }
        
        }

        public string getPostsFrom(int i)
        {
            return user.postList[i];
        }

        public void likePost()
        {
            posts.likes++;
        }
        
        public List<UserDS> Friends { get { return friends; } }
    
        public User getUser { get {return user;} }


        public List<string> getPosts { get { return user.postList; } }

        

    }

}
