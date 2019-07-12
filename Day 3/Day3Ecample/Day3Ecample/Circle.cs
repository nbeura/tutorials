using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Ecample
{
    class Circle
    {
        public static float PI;

        public int redius;

        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            PI = 3.141f;
        }
        
        public Circle(int redius)
        {
            Console.WriteLine("Instance Constructor Called");
            this.redius = redius;
        }

        public float getArea()
        {
            return PI * redius * redius;
        }

    }
}
