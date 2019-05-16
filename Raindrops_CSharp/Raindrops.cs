using System;

namespace Raindrops_CSharp
{
    public class Raindrops
    {
        public string Numbers(int choice)
        {
           var output = "";
            
           if (choice % 3 == 0) output += "Pling";
           if (choice % 5 == 0) output += "Plang";
           if (choice % 7 == 0) output += "Plong";
           if (string.IsNullOrEmpty(output)) output += choice;

           return output;
        }

        public static void main()
        {
            var test = new Raindrops();

            var pling = test.Numbers(3);
            Console.WriteLine(pling);
            
            var plang = test.Numbers(10);
            Console.WriteLine(plang);

            var plong = test.Numbers(14);
            Console.WriteLine(plong);

            var showMeNumber = test.Numbers(8);
            Console.WriteLine(showMeNumber);
        }
    }
}