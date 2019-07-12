using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleSample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Circle circle3;

            //Circle circle = new Circle(5);

            //Console.WriteLine("{0}", circle.getArea());

            //Circle circle2 = new Circle(3);
            //Console.WriteLine("{0}", circle2.getArea());

            Console.WriteLine(Circle.PI);

            Console.ReadKey();
        }
    }


    class Circle
    {
        public static float PI;

        int radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor called.");
            PI = 3.141f;
        }

        public Circle(int radius)
        {
            Console.WriteLine("Non Static Constructor called.");
            this.radius = radius;
        }

        public float getArea()
        {
            return PI * radius * radius;
        }
    }
}
