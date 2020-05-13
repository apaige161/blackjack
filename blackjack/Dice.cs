using System;
namespace blackjack
{
    public class Dice
    {

        //creates a new random card suit
        public static int NewDie()
        {
            Random random = new Random();
            int dieVal = random.Next(1, 7);

            return dieVal;
        }

        public Dice()
        {
        }
    }
}
