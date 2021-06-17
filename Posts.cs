using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class Posts
    {
        public string caption;
        public int likes;
        public List<string> comments;

        public Posts(string caption, int likes, List<string> comments)
        {
            this.caption = caption;
            this.likes = likes;
            comments = new List<string>();
        }
    
    public void like()
        {
            likes++;
        }
    
    
    }
}
