using System;

namespace Strings

{
    class Program
    {
        static void Main(string[] args)
        {
            //MyGuide();
            //FormatString();
            //Compare();
            //StartsEndsWith();
            Equals();
        }

        static void MyGuide()
        {
            var myGuide = Guid.NewGuid();

            myGuide = new Guid("bc5282f6-01bd-4ccd-a928-f10cbde68937");
            Console.WriteLine(myGuide.ToString().Substring(0, 8));
        }

        static void FormatString()
        {
            var price = 15.5;
            var text = "";
            text = "Price: " + price + " sold";
            text = string.Format("Price is {0} sold", price);
            text = $"Price is {price} sold";

            Console.WriteLine(text);
        }

        static void Compare()
        {
            var text = "Different";
            var result = text.CompareTo("different"); // result 1 True and result 0 False

            var text2 = "This equals";
            var result2 = text2.Contains("Equals", StringComparison.OrdinalIgnoreCase); // True
            var result3 = text2.Contains("Equals"); // False

            Console.Clear();
            Console.WriteLine(result3);
        }

        static void StartsEndsWith()
        {
            var text = "This equals";
            Console.WriteLine(text.StartsWith("this equals"));
            Console.WriteLine(text.StartsWith("This equals")); // True because the initial string starts the same
            Console.WriteLine(text.StartsWith(" This equals"));

            Console.WriteLine(text.EndsWith("This Equals"));
            Console.WriteLine(text.StartsWith("This equals")); // True because the final string starts the same
            Console.WriteLine(text.EndsWith("This Equals "));


        }

        static void Equals()
        {
            var text = "My equal is Equals";
            Console.WriteLine(text.Equals("My equal Is Equals"));
            Console.WriteLine(text.Equals("My equal is Equals")); // True
            Console.WriteLine(text.Equals("My equal IS Equals", StringComparison.OrdinalIgnoreCase)); // True
        }
    }
}

