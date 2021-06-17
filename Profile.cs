using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class Profile
    {
        private User user;
        private string bio;
        private string posts;

        public Profile(string username, string bio, string posts)
        {
            user = new User(username);
            this.bio = bio;
            this.posts = posts;
        }

    }
}
