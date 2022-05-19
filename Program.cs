using System;

namespace Strings

{
    class Program
    {
        static void Main(string[] args)
        {
            MyGuide();
            FormatString();
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
    }
}

