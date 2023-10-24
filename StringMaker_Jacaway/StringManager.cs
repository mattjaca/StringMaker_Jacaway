using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StringMaker_Jacaway
{
    internal class StringManager
    {
        private string input;
        public StringManager(string Input)
        {
            input = Input;
        }

        public string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            string h = string.Empty;
            Stack word = new Stack();

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                h = h + chars[i];
            }
            s = h;
            word.Push(s);
            return s;
        }
        public string Reverse(string s, bool Preservecaselocation)
        {
            Stack word = new Stack();
            string h = string.Empty;

            foreach (char c in s)
            {
                word.Push(c);
            }
            while (word.Count > 0)
            {
                h += word.Pop();
            }






            
            s = h;
            return s;


            
        }
        //public bool Symmetric(string s)
        //{

        //}
        public override string ToString()
        {
            if(input == null)
            {
                input = "Negative One";
            }
            int total = 0;
            foreach (char c in input)
            {
                total += c;
            }
            return WordConverter(total);
        }
        public string WordConverter(int n)
        {
            string answer = string.Empty;
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            while(n > 0)
            {
                int percent = n % 10;
                answer += words[percent] + " ";
            }
            return answer;
        }
        public override bool Equals(object enter)
        {
            if(input is string)
            {
                return input.Equals(enter);
            }
            return false;
        }
    }
}
  
