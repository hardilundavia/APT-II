using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class ar
    {
        public delegate void calArea(float a, float b);

        public void areaTriangle(float x,float y)
        {
            Console.WriteLine("Area of Triangle  : {0}",0.5*x*y);
        }

        public void areaRectangle(float x, float y)
        {
            Console.WriteLine("Area of Rectangle  : {0}",x * y);
        }
        static void Main(string[] args)
        {
            ar a = new ar();

            //value of triangle
            Console.WriteLine("Enter base value : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height value : ");
            float h = float.Parse(Console.ReadLine());
            calArea del_ob1 = new calArea(a.areaTriangle);
            del_ob1(b, h);

            //value of rectangle
            Console.WriteLine("Enter length value : ");
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter width value : ");
            float w = float.Parse(Console.ReadLine());
            calArea del_ob2 = new calArea(a.areaRectangle);
            del_ob2(l, w);
        }
    }
}
