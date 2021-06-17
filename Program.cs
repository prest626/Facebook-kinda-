using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDS n1 = new UserDS("prest626");
            UserDS n2 = new UserDS("prince");
            UserDS n3 = new UserDS("chibu");
            UserDS n4 = new UserDS("preston");

            n1.addFriend(n2);
            n1.addFriend(n3);

            n2.addFriend(n1);
            n2.addFriend(n4);

            n4.addFriend(n3);
            n4.addFriend(n2);

            Console.WriteLine("User\t\t\t\tFriends");
            Console.WriteLine("{0}\t\t\t\t\t{1}", n1.getUser.Username, string.Join(",",n1.Friends.Select(x=>x.getUser.Username)));
            Console.WriteLine("{0}\t\t\t\t\t{1}", n2.getUser.Username, string.Join(",", n2.Friends.Select(x => x.getUser.Username)));
            Console.WriteLine("{0}\t\t\t\t\t{1}", n3.getUser.Username, string.Join(",", n3.Friends.Select(x => x.getUser.Username)));
            Console.WriteLine("{0}\t\t\t\t\t{1}", n4.getUser.Username, string.Join(",", n4.Friends.Select(x => x.getUser.Username)));





            Console.ReadKey();
        }

        public delegate void freind(User username);

    }
}
