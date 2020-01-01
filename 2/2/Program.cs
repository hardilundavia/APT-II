using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str
{
    class str1
    {
        public delegate string methods(string a);

        public string con(string x)
        {
            Console.WriteLine("Enter String 2 : ");
            string y = Console.ReadLine();
            string s;
            s = string.Concat(x,y);
            return(s);
        }

        public string rev(string x)
        {
            char[] charArray = x.ToCharArray();
            Array.Reverse(charArray);
            return(new string(charArray));
        }
        static void Main(string[] args)
        {
            str1 s1 = new str1();
            //concate
            Console.WriteLine("Enter String1 : ");
            string x =Console.ReadLine();
            methods m = new methods(s1.con);
            string res=m(x);
            Console.WriteLine("Concated String : {0}",res);

            //revserse
            Console.WriteLine("Enter String : ");
            string s = Console.ReadLine();
            methods m1 = new methods(s1.rev);
            string res1=m1(s);
            Console.WriteLine("Reversed String : {0}", res1);

            Console.ReadLine();
        }
    }
}
