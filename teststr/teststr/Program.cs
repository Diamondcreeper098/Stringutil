using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace teststr
{
    class Program
    {
        static void Main(string[] args)
        {
            //A thing
            string str = "Hello Wo rl d";
            string str1 = "asd";
            StringUtil stru = new StringUtil(str);
            StringUtil stru1 = new StringUtil(str1);
            string anotherstr = stru.Reverse();
            Console.WriteLine("Text is: {0}",str);
            Console.WriteLine("Reversed Text is: {0}", anotherstr);
            Console.WriteLine("str: Count is : {0} Spaces: {1} Without Space: {2}",stru.Countchars(),stru.Countspaces(),stru.Countwithoutspaces());
            Console.WriteLine("str1: Count is : {0} Spaces: {1} Without Space: {2}", stru1.Countchars(), stru1.Countspaces(), stru1.Countwithoutspaces());
            Console.ReadKey(true);
        }
    }
}
