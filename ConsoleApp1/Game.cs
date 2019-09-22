using System;
using System.Collections.Generic;

public class Game
{
    
    private bool gameOver = false;
	public Game()
	{
	}

    //initialize Deck
    public void initializeDecks(Player player1, Player player2)
    {

        Queue<Card> dealerDeck = new Queue<Card>();
        Queue<Card> player1Deck = new Queue<Card>();
        Queue<Card> player2Deck = new Queue<Card>();

        //create deck of all cards.
        //for each card
        for(int i = 1; i < 14; i++)
        { 
            //for each suit
            for(int j = 1; j < 5; j++)
            {
                //make card
                Card c = new Card(i, j);
                //add card to Deck
                dealerDeck.Enqueue(c);
                
            }
        }


        //shuffle deck
        dealerDeck = Shuffle(dealerDeck);
        
        //Enqueue 26 to both decks
        
        while(dealerDeck.Count != 26)
        {
            player1Deck.Enqueue(dealerDeck.Dequeue());
        }
        while(dealerDeck.Count != 0)
        {
            player2Deck.Enqueue(dealerDeck.Dequeue());
        }
        //set deck
        
        player2.setDeck(player2Deck);
        player1.setDeck(player1Deck);
    }

    //Shuffle method
    public Queue<Card> Shuffle(Queue<Card> D)
    {
        Random rand = new Random();
        int randIndex = 0;
        List<Card> shuffledDeck = new List<Card>();
        int count = D.Count;
        List<Card> deckList = new List<Card>();
       
        //Convert from FIFO to list
        for(int i = 0; i < count ; i++)
        {
            deckList.Add(D.Dequeue());
           
        }
        //Scramble list.
        while(deckList.Count != 0)
        {
            randIndex = rand.Next(0, deckList.Count);
            shuffledDeck.Add(deckList[randIndex]);
            deckList.RemoveAt(randIndex);
        }
        //Convert list back to a FIFO
        for(int j = 0; j < shuffledDeck.Count; j++)
        {
            D.Enqueue(shuffledDeck[j]);
        }
        
        return D;
    }
    
    public void playRound(Player player1, Player player2, Queue<Card> cardList)
    {
        Card player1Card = new Card();
        Card player2Card = new Card();
        
        if ((player1.getDeck().Count != 0) && (player2.getDeck().Count != 0))
        {
            player1Card = player1.getDeck().Dequeue();
            player2Card = player2.getDeck().Dequeue();
            cardList.Enqueue(player1Card);
            cardList.Enqueue(player2Card);

            Console.WriteLine(player1.getName() + " flips " + player1Card.toString());
            Console.WriteLine(player2.getName() + " flips " + player2Card.toString());

            if (player1Card.getNumber() > player2Card.getNumber())
            {
                Console.WriteLine(player1.getName() + " wins the cardpool!\n");
                cardList = Shuffle(cardList);
                while (cardList.Count != 0)
                {
                    player1.getDeck().Enqueue(cardList.Dequeue());
                }

            }
            else if (player1Card.getNumber() < player2Card.getNumber())
            {
                Console.WriteLine(player2.getName() + " wins the cardpool!\n");
                cardList = Shuffle(cardList);
                while (cardList.Count != 0)
                {
                    player2.getDeck().Enqueue(cardList.Dequeue());
                }
            }
            else
            {
                War(player1, player2, cardList);
            }
        }
        else
        {
            if (player1.getDeck().Count == 0)
            {
                Console.WriteLine(player1.getName() + " Loses the War!");
                Console.WriteLine(player2.getName() + " is the winner!");
                gameOver = true;
            }
            if (player2.getDeck().Count == 0)
            {
                Console.WriteLine(player2.getName() + " Loses the War!");
                Console.WriteLine(player1.getName() + " is the winner!");
                gameOver = true;
            }
        }

    }

    //in case War happens, better to keep a seperate function for recursion reasons.
    public void War(Player player1, Player player2, Queue<Card> cL)
    {
        
        Console.WriteLine("It's war time, baby\n1, 2, 3, 4 I de-clare war!");
        for (int i = 0; i != 3; i++)
        {
            if ((player1.getDeck().Count != 0) && (player2.getDeck().Count != 0))
            {
                cL.Enqueue(player1.getDeck().Dequeue());
                cL.Enqueue(player2.getDeck().Dequeue());
            }
            
            
            if (player1.getDeck().Count == 0)
                {
                    Console.WriteLine(player1.getName() + " has run out of cards during the war!");
                    gameOver = true;
                    break;
                }
            if (player2.getDeck().Count == 0)
                {
                    Console.WriteLine(player2.getName() + " has run out of cards during the war!");
                    gameOver = true;
                    break;
                }
            
        }
        
        playRound(player1, player2, cL);
    }
    public void playGame(Player player1, Player player2)
    {
        int turnCount = 1;
        Queue<Card> cardList = new Queue<Card>();
        
        Console.WriteLine("Player 1 Name: ");
        player1.setName(Console.ReadLine());
        Console.WriteLine("Player 2 Name: ");
        player2.setName(Console.ReadLine());
        Console.WriteLine("Game Start!");
        
        //while both decks have cards, play a round.
        while(gameOver != true)
        {
            Console.WriteLine("Turn " + turnCount);
            playRound(player1, player2, cardList);
            turnCount++;
        }
        
    }
}
