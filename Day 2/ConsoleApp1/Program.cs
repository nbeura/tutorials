using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 20, y = 10;
            //var result = x > y ? "x is greater than y" : "x is less than or equal to y";
            //Console.WriteLine(result);

            //A a = new A();
            //B b = new B();

            //a.Id = 10;
            //b.Id = 11;

            //var result = a.Id > b.Id ? a.Name : b.Address;
            //Console.WriteLine(result);

            //int x = 10;

            //switch (x)
            //{
            //    case 5:
            //    case 10:
            //        Console.WriteLine("Value of x is 5 or 10");
            //        break;
            //    case 15:
            //        Console.WriteLine("Value of x is 15");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown value");
            //        break;
            //}

            //for (int i = 0; i < 10; ++i)
            //{
            //    Console.WriteLine("Value of i: " + i);
            //}

            //A[] aArray = new A[10];
            //aArray[0] = new A() { Id = 1, Name = "A1" };
            //aArray[1] = new A() { Id = 2, Name = "A2" };
            //aArray[2] = new A() { Id = 3, Name = "A3" };
            //aArray[3] = new A() { Id = 4, Name = "A4" };
            //aArray[4] = new A() { Id = 5, Name = "A5" };
            //aArray[5] = new A() { Id = 6, Name = "A6" };
            //aArray[6] = new A() { Id = 7, Name = "A7" };
            //aArray[7] = new A() { Id = 8, Name = "A8" };
            //aArray[8] = new A() { Id = 9, Name = "A9" };
            //aArray[9] = new A() { Id = 10, Name = "A10" };

            //for (int i = 0; i < aArray.Length; i++)
            //{
            //    Console.WriteLine("Name: " + aArray[i].Name);
            //}

            //foreach(A item in aArray)
            //{
            //    Console.WriteLine("Name: " + item.Name);
            //}

            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Value of i: {0}", i);

            //    i++;

            //} while (i < 10);

            A a = new A();


            Console.WriteLine(a.ToString());

            Console.ReadKey();

        }

        private int ValidateNumberGroup(int input)
        {
            switch (input)
            {
                case 5:
                case 10:
                    return 1;
                case 15:
                    return 2;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Add of two number
        /// </summary>
        /// <param name="x">First <see cref="int">integer</see> parameter </param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int Add(int[] x)
        {
            int sum = 0;
            int avj = 0;
            try
            {
                foreach (int item in x)
                {
                    sum += item; ;
                }

            }
            catch (Exception ex)
            {
                //log(ex.Message);
                throw ex;
                //throw new Exception("There is exception on Add Method",ex);

                //throw;
            }
            finally
            {
                //avj = (x + y) / 2;
            }

            return sum;// +avj;
        }

        //public string GetStudentNameByEmail(string email)
        //{

        //    if (string.IsNullOrEmpty(email)){
        //        throw new ArgumentNullException("email","email is required");
        //    }

        //    // Rest of the logic
        //}


        class A
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        class B
        {
            public int Id { get; set; }

            public string Address { get; set; }
        }


    }
}
