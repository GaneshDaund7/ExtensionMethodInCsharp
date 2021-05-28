using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods
{
    public static class ExtensionMethodClass
    {
        public static void Method3(this Program p)
        {
            Console.WriteLine("P is " + p);
            Console.WriteLine("Method 3");
           
            
        }
        public static long Factorial(this Int32 x)
        {
            long fact = 1;
            for (int i = 1; i <= x; i++)
                fact *= i;
            return fact;
        }

        public static string toProper(this String OldStr)
        {
            string NewStr = null;
            OldStr = OldStr.ToLower();
            string[] sarr = OldStr.Split(' ');
            foreach (string str in sarr)
            {
               char [] carr= str.ToCharArray();
               carr[0] = char.ToUpper(carr[0]);
               
                if(NewStr==null)
                    NewStr = new String(carr);
                else 
                    NewStr+=" " + new String(carr);

            }
            return NewStr;
        }

        public static string FormatDate(this DateTime datetime)
        {
            return datetime.ToString("dd MMMM yyyy ddddd hh:mm:ss tt");
        }
    }
}
