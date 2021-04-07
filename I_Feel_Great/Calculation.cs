using System;

namespace I_Feel_Great
{
    class Calculation
    {
        // This class is used to calculate all probability!!
        // Probability works by a possible outcome over the outcomes which can occur
        // Such landing a 3 in a 6 sixed dice, the probability is 1 over 6
        // Therefore, working with 1 user input is difficult and results are not good, although having
        // more users this program works well, I have added this function is so it can be chosen how many users
        // you want to go through
        public void maleprobability(double a, double b)
        {
            // a is total no therefore, work out 65% of total no
            double first = (a / 100.0);
            // Take value of first then to times it by 65%
            double sec = first * 65;
            // Divide percentage total by total users to get probability
            double total = sec / b;
            // Sometimes the percentage could be 0. value therefore times it by 100 to work out percentage accuratly
            if(total < 100.00)
            {
                Console.WriteLine("Probability that it is male = " + Math.Round(total * 100.00, MidpointRounding.AwayFromZero)+ "%");
            }
            else
            {
                Console.WriteLine("Probability that it is male = " + Math.Round(total, MidpointRounding.AwayFromZero)+ "%");
            }
        }
        public void femaleprobability(double x, double y, double z)
        {
            // Work out 35% of no values (x is no values)
            double first = (x / 100.00);
            double sec = first * 35;
            // add all of yes because no males will say yes! (y is yes values)
            double total = sec + y;
            // total divided by total users (z)
            double finaltotal = total / z;
            // Sometimes the percentage could be 0. value therefore times it by 100 to work out percentage accuratly
            if (finaltotal < 100.00)
            {
                Console.WriteLine("Probability that it is female = " + Math.Round(finaltotal * 100.00, MidpointRounding.AwayFromZero) + "%");
            }
            else
            {
                Console.WriteLine("Probability that it is female = " + Math.Round(finaltotal, MidpointRounding.AwayFromZero) + "%");
            }
        }
    }
}
