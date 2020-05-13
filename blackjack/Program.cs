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
            Console.WriteLine("blackjack and the dice game is currently working but ready for improvements");

            Console.WriteLine("Are you ready for a game of blackjack or dice?, Enter BLACKJACK or DICE");
            string play = Console.ReadLine().ToLower();
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
            while(play == "blackjack")
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
                    play = Console.ReadLine().ToLower();
                    Console.WriteLine("\n");
                }

                //tie
                else if (playerCards == 21 && dealerCards == 21)
                {
                    Console.WriteLine("You tied, dealer wins");
                    Console.WriteLine("play another round? Yes or No");
                    play = Console.ReadLine().ToLower();
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
                        play = Console.ReadLine().ToLower();
                        Console.WriteLine("\n");
                    }
                    //player loss
                    else
                    {
                        Console.WriteLine("Dealer wins");
                        Console.WriteLine("play another round? Yes or No");
                        play = Console.ReadLine().ToLower();
                        Console.WriteLine("\n");
                    }
                }

                //player loss
                else
                {
                    Console.WriteLine("Dealer wins");
                    Console.WriteLine("play another round? Yes or No");
                    play = Console.ReadLine().ToLower();
                    Console.WriteLine("\n");
                }
            //end of game loop
            }

            //add a system exception error handler for Console.ReadLine(), validate string

            Console.WriteLine("The objective is to roll a higher number than your opponent");
            //Console.WriteLine("Play dice?, yes or no");
            //play = Console.ReadLine().ToLower();

            int playerScore = 100;

            while (play == "dice")
            {
                Console.WriteLine("\n");
                //place a bet
                Console.WriteLine("How much would you like to wager?, must be an integer");
                Console.WriteLine($"You have {playerScore} to wager");
                string wagerStr = Console.ReadLine();

                int wager = Convert.ToInt32(wagerStr);
                //if player is out of money break out of program

                if (wager > playerScore)
                {
                    Console.WriteLine("You do not have that much to gamble. End of game");
                    break;
                }
                else if (wager <= playerScore)
                {
                    //player recieves 2 dice
                    int playerTotal = Dice.NewDie() + Dice.NewDie();
                    Console.WriteLine($"Your total is {playerTotal}");

                    //computer recieves 2 dice
                    int oppTotal = Dice.NewDie() + Dice.NewDie();
                    Console.WriteLine($"Opponent total is {oppTotal}");
                    Console.WriteLine("\n");

                    //won
                    if (playerTotal > oppTotal)
                    {
                        playerScore += wager;
                        Console.WriteLine($"You won {wager}! You have {playerScore}");
                    }
                    //lost
                    else if (playerTotal < oppTotal)
                    {
                        playerScore -= wager;
                        Console.WriteLine($"You lost {wager}! You have {playerScore}");
                        if (playerScore <= 0)
                        {
                            Console.WriteLine("You are our of money come back another time");
                            break;
                        }
                    }
                    //tie
                    else
                    {
                        Console.WriteLine("It is a tie! try again");
                    }
                }
                Console.WriteLine("Play dice?, yes or no");
                play = Console.ReadLine().ToLower();
            }//end of game loop


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
