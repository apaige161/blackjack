using System;

namespace blackjack
{
    class Program
    {

        //As of now I get a random card from 2 to 11 and randomly assigns a suit, no face cards

        /*What will i need?
        *
        * player
        * dealer
        * random cards
        * test winner
        *
        * **would like to add a dice game
        *
        * **would like to add a betting aspect
        *
       */


        static void Main(string[] args)
        {
            Console.WriteLine("blackjack is currently working but ready for improvements");

            Console.WriteLine("Are you ready for a game of blackjack?");
            string keepGoing = Console.ReadLine().ToLower();
            Console.WriteLine("\n");


            //bool playerWon = false;

            //calls the method to create a new card
            //has to be a better way
            //player cards

            /* figuer out how to encapsulate these arrays */
            //use getters and setters??
            //how do i create a new card as i go? what if i needed 40+ new cards
            int[] listOfCards = { Card.NewCard(), Card.NewCard(), Card.NewCard(),
                                  Card.NewCard(), Card.NewCard(), Card.NewCard(),
                                  Card.NewCard(), Card.NewCard(), Card.NewCard()
                                };
            string[] listOfSuit = { Card.NewSuit(), Card.NewSuit(), Card.NewSuit(),
                                    Card.NewSuit(), Card.NewSuit(), Card.NewSuit(),
                                    Card.NewSuit(), Card.NewSuit(), Card.NewSuit()
                                  };

            //main blackjack loop 
            while(keepGoing == "yes")
            {
                //allows a player to "hit" and gives total
                //needs to improve user option to add card (method)?? need to DRY
                    //if the player choses to play again the same cards are given
                int playerCards = listOfCards[0] + listOfCards[1];
                Console.WriteLine($" {listOfCards[0]}: {listOfSuit[0]}, " +
                    $"{listOfCards[1]}: {listOfSuit[1]}");

                if (playerCards < 21)
                {
                    Console.WriteLine($"Player cards equal {playerCards}, hit or stay?");
                    string playerChoice = Console.ReadLine();
                    if (playerChoice == "stay")
                    {
                        Console.WriteLine($"Player cards equal {playerCards}");
                    }
                    //first hit
                    else if (playerChoice == "hit")
                    {
                        playerCards += listOfCards[2];
                        if (playerCards <= 21)
                        {
                            Console.WriteLine($"{playerCards}, hit or stay?");
                            Console.WriteLine($"{listOfCards[0]}: {listOfSuit[0]}, " +
                                $"{listOfCards[1]}: {listOfSuit[1]}, " +
                                $"{listOfCards[2]}: {listOfSuit[2]}");
                            playerChoice = Console.ReadLine();
                            if (playerChoice == "stay")
                            {
                                Console.WriteLine($"Player cards equal {playerCards}");
                            }
                            //second hit
                            else if (playerChoice == "hit")
                            {
                                playerCards += listOfCards[3];
                                if (playerCards <= 21)
                                {
                                    Console.WriteLine($"{playerCards}, hit or stay?");
                                    Console.WriteLine($"{listOfCards[0]}: {listOfSuit[0]}, " +
                                        $"{listOfCards[1]}: {listOfSuit[1]}, " +
                                        $"{listOfCards[2]}: {listOfSuit[2]}, " +
                                        $"{listOfCards[3]}: {listOfSuit[3]}");
                                    playerChoice = Console.ReadLine();
                                    if (playerChoice == "stay")
                                    {
                                        Console.WriteLine($"Player cards equal {playerCards}");
                                    }
                                    //third hit
                                    else if (playerChoice == "hit")
                                    {
                                        playerCards += listOfCards[4];
                                        if (playerCards <= 21)
                                        {
                                            Console.WriteLine($"{playerCards}, hit or stay?");
                                            Console.WriteLine($"{listOfCards[0]}: {listOfSuit[0]}, " +
                                                $"{listOfCards[1]}: {listOfSuit[1]}, " +
                                                $"{listOfCards[2]}: {listOfSuit[2]}, " +
                                                $"{listOfCards[3]}: {listOfSuit[3]}, " +
                                                $"{listOfCards[4]}: {listOfSuit[4]}");
                                            playerChoice = Console.ReadLine();
                                            if (playerChoice == "stay")
                                            {
                                                Console.WriteLine($"Player cards equal {playerCards}");
                                            }
                                            //fourth hit
                                            else if (playerChoice == "hit")
                                            {
                                                playerCards += listOfCards[5];
                                                if (playerCards <= 21)
                                                {
                                                    Console.WriteLine($"{playerCards}, hit or stay?");
                                                    Console.WriteLine($"{listOfCards[0]}: {listOfSuit[0]}, " +
                                                        $"{listOfCards[1]}: {listOfSuit[1]}, " +
                                                        $"{listOfCards[2]}: {listOfSuit[2]}, " +
                                                        $"{listOfCards[3]}: {listOfSuit[3]}, " +
                                                        $"{listOfCards[4]}: {listOfSuit[4]}, " +
                                                        $"{listOfCards[5]}: {listOfSuit[5]} ");
                                                    playerChoice = Console.ReadLine();
                                                    if (playerChoice == "stay")
                                                    {
                                                        Console.WriteLine($"Player cards equal {playerCards}");
                                                    }
                                                    //fifth hit
                                                    else if (playerChoice == "hit")
                                                    {
                                                        Console.WriteLine("cannot hit again at this time");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Player busted with {playerCards}");
                                                }
                                                //end of fourth hit
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Player busted with {playerCards}");
                                        }
                                        //end of third hit
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Player busted with {playerCards}");
                                }
                                //end of second hit
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Player busted with {playerCards}");
                        }
                        //end of first hit
                    }
                    //player bust
                    else if (playerCards > 21)
                    {
                        Console.WriteLine($"Player busted with a total of {playerCards}");
                    }
                    //blackjack
                    else if (playerCards == 21)
                    {
                        Console.WriteLine("Player has 21!");
                    }
                    else
                    {
                        Console.WriteLine("something went wrong");
                    }
                    //end of player cards
                }

                //add a dealer
                //then compare values between player and dealer, dealer wins on a tie
                //put Card.NewCard() in a variable and display dealer cards

                int dealerCards = Card.NewCard() + Card.NewCard();
                Console.WriteLine($"dealer card value: {dealerCards}");
                if (dealerCards < 15 && playerCards <= 21)
                {
                    dealerCards += Card.NewCard();
                    Console.WriteLine($"dealer hits, dealer card value: {dealerCards}");
                    //dealer hit 1
                    if (dealerCards < 15)
                    {
                        dealerCards += Card.NewCard();
                        Console.WriteLine($"dealer hits, dealer card value: {dealerCards}");
                        //dealer hit 2
                        if (dealerCards < 15)
                        {
                            dealerCards += Card.NewCard();
                            Console.WriteLine($"dealer hits, dealer card value: {dealerCards}");
                            //dealer hit 3
                            if (dealerCards < 15)
                            {
                                dealerCards += Card.NewCard();
                                Console.WriteLine($"dealer hits, dealer card value: {dealerCards}");
                                //dealer hit 4
                                if (dealerCards < 15)
                                {
                                    dealerCards += Card.NewCard();
                                    Console.WriteLine($"dealer hits, dealer card value: {dealerCards}");
                                    //dealer hit 5
                                    if (dealerCards < 15)
                                    {
                                        dealerCards += Card.NewCard();
                                        Console.WriteLine($"dealer hits, dealer card value: {dealerCards}");
                                    }
                                }
                            }
                        }
                    }
                    //end of dealer hits
                }
                //displays dealer cards value if over 15 to start, end of dealer card logic
                else
                {
                    Console.WriteLine(dealerCards);
                }


                //test winner logic

                //bust
                if (playerCards > 21)
                {
                    Console.WriteLine("player busted, you lose");
                    Console.WriteLine("play another round? Yes or No");
                    keepGoing = Console.ReadLine().ToLower();
                    Console.WriteLine("\n");
                }

                //tie
                else if (playerCards == 21 && dealerCards == 21)
                {
                    Console.WriteLine("You tied, dealer wins");
                    Console.WriteLine("play another round? Yes or No");
                    keepGoing = Console.ReadLine().ToLower();
                    Console.WriteLine("\n");
                }

                //player win
                else if (playerCards <= 21)
                {
                    if (playerCards > dealerCards || dealerCards > 21)
                    {
                        Console.WriteLine("Player wins!");
                        //playerWon = true;
                        Console.WriteLine("play another round? Yes or No");
                        keepGoing = Console.ReadLine().ToLower();
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("Dealer wins");
                        Console.WriteLine("play another round? Yes or No");
                        keepGoing = Console.ReadLine().ToLower();
                        Console.WriteLine("\n");
                    }
                }

                //player loss
                else
                {
                    Console.WriteLine("Dealer wins");
                    Console.WriteLine("play another round? Yes or No");
                    keepGoing = Console.ReadLine().ToLower();
                    Console.WriteLine("\n");
                }
            }



            /*
            if(playerWon == true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("        \"                      /    ");
                Console.WriteLine("         \"                    /     ");
                Console.WriteLine("          \"                  /      ");
                Console.WriteLine("           \"                /       ");
                Console.WriteLine("            \"      /\"      /        ");
                Console.WriteLine("             \"    /  \"    /         ");
                Console.WriteLine("              \"  /    \"  /          ");
                Console.WriteLine("               \"/      \"/           ");
            }
            */
        }

    }

}
