using System;

namespace Raindrops_CSharp
{
    public class Raindrops
    {
        public String Numbers(int choice)
        {
           String output = "";
            
           if (choice % 3 == 0) output += "Pling";
           if (choice % 5 == 0) output += "Plang";
           if (choice % 7 == 0) output += "Plong";
           if (String.IsNullOrEmpty(output)) output += choice;

           return output;
        }

        public static void main()
        {
            Raindrops test = new Raindrops();

            String pling = test.Numbers(3);
            Console.WriteLine(pling);

            String plang = test.Numbers(10);
            Console.WriteLine(plang);

            String plong = test.Numbers(14);
            Console.WriteLine(plong);

            String showMeNumber = test.Numbers(8);
            Console.WriteLine(showMeNumber);
        }
    }
}