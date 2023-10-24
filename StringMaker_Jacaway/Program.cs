using System.Collections;
using System.Collections.Generic;

namespace StringMaker_Jacaway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringManager word = new StringManager("Matthew");
            string m = "Matthew";
            Console.WriteLine(word.Reverse(m));

            string n = "Matthew";
        }
    }
}