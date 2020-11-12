using System;
using System.Text;

namespace StringRemove_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(remove_("___hello___world___"));

            Console.ReadKey();
        }

        public static string remove_(string s)
        {
            var sb = new StringBuilder(s);

            for (int i = 0; i < sb.Length; i++)
            {
                var count = 0;
                if (sb[i] == '_')
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    { 
                        
                    }
                }
            }

            return "";
        }
    }
}
