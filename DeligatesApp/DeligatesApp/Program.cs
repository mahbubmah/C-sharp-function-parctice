using System;

namespace DeligatesApp
{
    class Program
    {
        private delegate string StrMod(string str);

        class DelegateTest
        {
            public static string ReplaceSpaces(string s)
            {
                Console.WriteLine("Repleacing space with hypens.");
                return s.Replace(' ', '-');
            }

            public static string RemoveSpace(string s)
            {
                string temp = "";
                int i;
                Console.WriteLine("Removing spaces");
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j]!=' ')
                    {
                        temp += s[j];
                    }
                }
                return temp;
            }

            public static string Reverse(string s)
            {
                string temp = "";
                
                Console.WriteLine("Reversing string.");
                for (int j = 0,i=s.Length-1; i>=0;i--, j++)
                {
                    temp += s[i];
                }
                return temp;
            }
        }
        static void Main(string[] args)
        {
            StrMod strOP = new StrMod(DelegateTest.ReplaceSpaces);
            string str;
            str = strOP("This is a test.");
            Console.WriteLine("Resulting string: "+str);
            Console.WriteLine();

            strOP=new StrMod(DelegateTest.RemoveSpace);
            str = strOP("This is a test.");
            Console.WriteLine("Resulting string: "+str);
            Console.WriteLine();

            strOP=new StrMod(DelegateTest.Reverse);
            str = strOP("This is a test.");
            Console.WriteLine("Resulting string: "+str);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
