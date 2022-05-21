using System;
using System.Text;

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
            //Equals();
            //Index();
            //MetodeAddition();
            //ManipulationString();
            //StringBuilder();
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

        static void Index()
        {
            var text = "My index is Index";

            Console.WriteLine(text.IndexOf("x")); // x in position 7
            Console.WriteLine(text.LastIndexOf("x")); // x in position 16
        }

        static void MetodeAddition()
        {
            var text = "Metode addition for text";
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(7, "HERE INSERTED "));
            Console.WriteLine(text.Remove(7, 9));
            Console.WriteLine(text.Length);

        }

        static void ManipulationString()
        {
            var text = "The Manipulation string for text";

            Console.WriteLine(text.Replace("The", "For"));
            Console.WriteLine(text.Replace("i", "@"));

            var division = text.Split();
            Console.WriteLine(division[0]); // The
            Console.WriteLine(division[4]); // text

            var result = text.Substring(1, 6); // he Man
            Console.WriteLine(result);

            text = " The Manipulation string for text ";
            Console.WriteLine(text.Trim()); // remove spaces initial and final the string

        }

        static void StringBuilder()
        {
            var text = new StringBuilder();

            text.Append("First Name: ");
            text.Append("Dev81log");
            text.Append(" ");
            text.Append("email: ");
            text.Append("dev81log@gmail.com");

            text.ToString();
            Console.WriteLine(text);
        }
    }
}

