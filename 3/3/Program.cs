using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void DelEventHandler();

    class Program
    {
        public static event DelEventHandler add;

        static void Main(string[] args)
        {
            add += new DelEventHandler(replace);
            add.Invoke();

            Console.ReadLine();
        }
        static void replace()
        {
            Console.WriteLine("Enter String : ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Old String : {0}",s1);
            Console.WriteLine("Enter String to replace : ");
            string s2 = Console.ReadLine();
            Console.WriteLine("Enter String new string on old string : ");
            string s3 = Console.ReadLine();
            Console.WriteLine("NewString: " + s1.Replace(s2, s3));
            Console.WriteLine("String modified");
            Console.ReadLine();
        }
    }
}
