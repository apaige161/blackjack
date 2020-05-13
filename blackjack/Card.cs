using System;
namespace blackjack
{
    public class Card
    {
        //creates a new random card value
        public static int NewCard()
        {
            Random random = new Random();
            int cardValue = random.Next(2, 12);
            return cardValue;
        }

        public static string NewSuit()
        {
            Random random = new Random();
            string cardSuit = "";
            int cardSuitVal = random.Next(0, 4);

            switch (cardSuitVal)
            {
                case 0:
                    return cardSuit = "clubs";
                case 1:
                    return cardSuit = "spades";
                case 2:
                    return cardSuit = "hearts";
                case 3:
                    return cardSuit = "diamonds";
            }
            return cardSuit;
        }


        //this is a constructor class
        //initialize with some initial value
        public Card()
        {
            //print a card with a value and suit
            //non invocable
            //Console.Write(NewCard());
            //Console.Write(NewSuit());

        }

    }
}
