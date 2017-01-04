using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Charlie's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3.  Your pick: ");
            string userValue = Console.ReadLine();

            string message = "";
            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won $500!";
            else if (userValue == "3")
                message = "You won a new pair of jeans";
            else
                message = "Why didn't you pick door '1, 2, or 3'? You lost! ";

            Console.WriteLine(message);
            Console.ReadLine();
            */

            //Another method with conditional only an if else statement not multiple elses

            Console.WriteLine("Charlie's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3.  Your pick: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "house" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write("!");
            //Console.ReadLine();

            //Faster/better way to rewrite the 4 lines above
            Console.WriteLine("Since you picked door {0}.... You won a {1}!", userValue, message);
            Console.ReadLine();
        }
    }
}
