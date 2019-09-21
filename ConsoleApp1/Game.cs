using System;
using System.Collections.Generic;

public class Game
{
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
        for(int i = 1; i < 15; i++)
        { 
            //for each suit
            for(int j = 1; j < 5; j++)
            {
                //make card
                Card c = new Card(i, j);
                c.toString();
                //add card to Deck
                dealerDeck.Enqueue(c);
            }
            
        }

        //shuffle deck
       // Shuffle(dealerDeck);
        //Enqueue 26 to both decks

        //set deck
       // player2.setDeck(player2Deck);
       // player1.setDeck(player1Deck);
    }

    //Shuffle method
    public void Shuffle(Queue<Card> D)
    {

    }
}
