using System;

namespace Delegates
{
    public class Program
    {
        public static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }


        private static void Main(string[] args)
        {
            StringerBell mcnulty = null;
            Joiner joiner1 = new("== The Wire ==");
            Joiner joiner2 = new("<<FAKE JOINER>>");

            mcnulty += joiner2.JoinAndPrint;
            mcnulty += PrintUpper;
            mcnulty += PrintLower;
            mcnulty += joiner1.JoinAndPrint;

            mcnulty.Invoke("This is The Standard String!!");
        }
    }
}
