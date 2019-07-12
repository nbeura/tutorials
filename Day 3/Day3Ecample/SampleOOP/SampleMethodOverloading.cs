using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOOP
{
    class SampleMethodOverloading
    {
        int Add(int x, int y)
        {
            return x + y;
        }

        //string Add(int x, int y)
        //{
        //    return "TEST";
        //}

        float Add(float x, float y)
        {
            return x + y;
        }

        double Add(double x, double y, double z)
        {
            return x + y + z;
        }

    }
}
