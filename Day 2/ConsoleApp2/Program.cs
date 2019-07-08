using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //// String of characters  
            //String authorName = "Arghya Biswas";
            //// String made of an Integer  
            //String age = "33";
            //// String made of a double  
            //String numberString = "33.23";

            //string name = "Test";

            //
            //char[] chars = { 'M', 'a', 'h', 'e', 's', 'h' };

            //string name = new string(chars);
            //Console.WriteLine(name);

            //string firstName = "Arghya";

            //string nowDateTime = "Date: " + DateTime.Now.ToString("D");
            //string firstName = "Arghya";
            //string lastName = "Biswas";
            //string age = "33";
            //string authorDetails = firstName + " " + lastName + " is " + age + " years old.";
            //Console.WriteLine(nowDateTime);

            //string authorInfo = "Arghya Biswas is 33 years old.";

            //int startPosition = authorInfo.IndexOf("is ") + 1;
            //Console.WriteLine(startPosition);
            //string age = authorInfo.Substring(startPosition +2, 2);
            //Console.WriteLine("Age: " + age);

            //string name = "Arghya Biswas";
            //int age = 33;
            ////string authorInfo = string.Format("{0} is {1} years old.", name, age);

            ////Console.WriteLine("{0} is {1} years old.", name, age);
            //Console.WriteLine($"{name} is {age} years old.");

            //string nameString = "Arghya Biswas";
            //for (int counter = 0; counter <= nameString.Length - 1; counter++)
            //    Console.WriteLine(nameString[counter]);

            //string name = "Arghya Biswas";
            //// Get size of string  
            //Console.WriteLine("Size of string: {0}", name.Length);
            //// Remove all empty characters  
            //string nameWithoutEmptyChar = name.Replace(" ", "");
            //// Size after empty characters are removed  
            //Console.WriteLine("Size of non empty char string: {0}", nameWithoutEmptyChar.Length);
            //// Read and print all characters  
            //for (int counter = 0; counter <= nameWithoutEmptyChar.Length - 1; counter++)
            //    Console.WriteLine(nameWithoutEmptyChar[counter]);


            //string sentence = "Arghya Biswas is an author of this document";
            //char[] charArr = sentence.ToCharArray();
            //foreach (char ch in charArr)
            //{
            //    Console.WriteLine(ch);
            //}


            //string name = "";
            //string name;
            //string name = null; // No
            ////string name = string.Empty;

            //if(string.IsNullOrEmpty(name))
            ////if( name == string.Empty)
            //{
            //    Console.WriteLine("String is empty");
            //}
            //else
            //{
            //    Console.WriteLine("String is not empty");
            //}

            //string name = "Horace";
            //int age = 34;
            //Console.WriteLine($"He asked, \"Is your name {name}?\", but didn't wait for a reply :-{{");
            //Console.WriteLine($"{name} is {age} year{(age == 1 ? "" : "s")} old.");

            //string[] names = { "John", "James", "Joan", "Jamie" };
            //for (int ctr = 0; ctr < names.Length; ctr++)
            //{
            //    Console.WriteLine($"Here is your gift, {names[ctr]}!");
            //}

            //string filename1 = @"c:\documents\files\u0066.txt";
            //string filename2 = "c:\\documents\\files\\u0066.txt";

            //Console.WriteLine(filename1);
            //Console.WriteLine(filename2);

            //StringBuilder sb = new StringBuilder("Hello ", 50);

            //sb.Append("World!!");
            //sb.AppendLine("Hello C#!");
            //sb.AppendLine("This is new line.");

            //Console.WriteLine(sb);

            //string html = "<table>";
            //html += "<tr>";
            //html += "<td>";
            //html += "Test";
            //html += "</td>";
            //html += "</tr>";
            //html += "</table>";

            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<table>");
            htmlBuilder.Append("<tr>");
            htmlBuilder.Append("<td>");
            htmlBuilder.Append("Test");
            htmlBuilder.Append("</td>");
            htmlBuilder.Append("</tr>");
            htmlBuilder.Append("</table>");

            string name = "Arghya";
            htmlBuilder.AppendFormat("Name: {0}", name);

            Console.ReadKey();

        }
    }
}

