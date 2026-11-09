using System;

namespace Delegates
{
    public class Joiner
    {
        private readonly string firstString;

        public Joiner(string str)
        {
            firstString = str;
        }

        public void JoinAndPrint(string secondString)
        {
            Console.WriteLine(firstString + secondString);
        }
    }
}