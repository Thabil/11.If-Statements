using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _11.If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the test that can be either true or false
            bool isMale = false;
            if (isMale)
            {
                Console.WriteLine("You are male");
            }

            else
            {
                Console.WriteLine("You are female");
            }
            //can also test 2 conditions with and ie && in C#, or is ||
            bool isTall = false;

            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and tall.");
            }

            else if (!isTall && isMale)
            {
                Console.WriteLine("You are not tall but you are male");
            }

            else if (isTall && !isMale)
            {
                Console.WriteLine("You are tall but you are not male");
            }

            else
            {
                Console.WriteLine("You are neither tall nor male.");
            }
        }
    }
}