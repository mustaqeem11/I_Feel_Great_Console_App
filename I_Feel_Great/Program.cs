using System;

namespace I_Feel_Great
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducing the App
            string appName = "I Feel Great";
            string appAuthor = "Mustaqeem Ditta";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} by {1}", appName, appAuthor);
            Console.ResetColor();
            // Calling the classes and functions
            Welcome x = new Welcome();
            Calculation y = new Calculation();
            x.startup();
            double totalofyes = x.totalyes();
            double totalofno = x.totalno();
            double totalusers = totalofno + totalofyes;

            // If statement is used to first determine male or female probability
            // This can be done because females reply with a equal yes and no
            // Therefore this if statement can rectify the equal responses
            if (totalofyes == totalofno)
            {
                y.femaleprobability(totalofno, totalofyes, totalusers);
            }
            // Condition can not be met because females reply in equal numbers and males don't say yes
            else if (totalofyes > totalofno)
            {
                Console.WriteLine("No probability because conditions were not met because females reply in equal numbers and males don't say yes");
            }
            //Condition can be met because male users reply with no
            else if (totalofno > totalofyes)
            {
                y.maleprobability(totalofno, totalusers);
            }
            Console.WriteLine("total users = " + totalusers);
        }
    }
}
