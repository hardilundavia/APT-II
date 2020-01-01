using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace file
{
    class fl
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("D:\\MA038\\Prac-3\\file.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(f1);
            Console.WriteLine("Enter content : ");
            string s = Console.ReadLine();
            writer.Write(s);
            writer.Close();

            //this code segment read data from the file.
            FileStream f2 = new FileStream("D:\\MA038\\Prac-3\\file.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(f2);
            string s1=reader.ReadLine();
            Console.WriteLine("Content of File : {0}", s1);
            reader.Close();
            Console.ReadLine();
        }
    }
}
