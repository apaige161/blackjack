using System;

namespace blackjack
{
    class Program
    {

        //As of now I get a random card from 2 to 11 and randomly assigns a suit

        /*What will i need?
        *
        * player
        * dealer
        * random cards
        * test winner
        *
       */

        static int CardValMethod()
        {
            Random random = new Random();
            int cardVal = random.Next(2, 12);
            return cardVal;
        }

        static string CardSuitMethod()
        {
            Random random = new Random();
            string cardSuit = "";
            int cardSuitVal = random.Next(0, 4);

            switch (cardSuitVal)
            {
                case 0:
                    cardSuit = "clubs";
                    break;
                case 1:
                    cardSuit = "spades";
                    break;
                case 2:
                    cardSuit = "hearts";
                    break;
                case 3:
                    cardSuit = "diamonds";
                    break;
            }
            return cardSuit;
        }

        //gather cards into a variable
        static void numOfCards(int num)
        {

        }

        //hand total overload
        static int HandTotal(int card1, int card2)
        { return card1 + card2; }

        static int HandTotal(int card1, int card2, int card3)
        { return card1 + card2 + card3; }

        static int HandTotal(int card1, int card2, int card3, int card4)
        { return card1 + card2 + card3 + card4; }

        static int HandTotal(int card1, int card2, int card3, int card4, int card5)
        { return card1 + card2 + card3 + card4 + card5; }

        static void Main(string[] args)
        {
            Console.WriteLine("blackjack coming soon");
            //create instance of object
            Card card = new Card();
            Player player = new Player();
            Player dealer = new Player();
            

            //random card test -returns the same value for all
            Console.WriteLine($"{CardValMethod()}, {CardSuitMethod()}");
            Console.WriteLine($"{CardValMethod()}, {CardSuitMethod()}");
            Console.WriteLine($"{CardValMethod()}, {CardSuitMethod()}");
            Console.WriteLine($"{CardValMethod()}, {CardSuitMethod()}");


            //card totaller test
            Console.WriteLine(HandTotal(CardValMethod(), CardValMethod()));
            Console.WriteLine(HandTotal(CardValMethod(), CardValMethod(), CardValMethod()));
            Console.WriteLine(HandTotal(CardValMethod(), CardValMethod(), CardValMethod(), CardValMethod()));
            Console.WriteLine(HandTotal(CardValMethod(), CardValMethod(), CardValMethod(), CardValMethod(), CardValMethod()));


        }
    }
}
