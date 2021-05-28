using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods
{
    class TestExtensionMethod
    {
      static void Main()
        {
            Program p = new Program();
            p.Method1(); p.Method2(); p.Method3();
            
            
            //int i = 5;
            //long res=i.Factorial();
            //Console.WriteLine("Factorial Of  " + i + " is " + res);

            //string str = "hOw Are yoU";
            //var Proper=str.toProper();
            //Console.WriteLine("Your Proper Formatted String is ==> " + Proper);


            var d =  DateTime.Now;
            string format=d.FormatDate();
            Console.WriteLine("Today's date and Time is " + format);

            Console.ReadLine();

            

        }
    }
}
