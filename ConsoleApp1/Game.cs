using System;
using System.Collections.Generic;

public class Game
{
	public Game()
	{
	}

    //initialize Deck
    public void initializeDeck(Player player)
    {
        Queue<Card> Deck = null;

        //for each card
        for(int i = 1; i < 14; i++)
        { 
            //for each suit
            for(int j = 1; j < 5; i++)
            {
                //make card
                Card c = new Card(i, j);
                //add card to Deck
                Deck.Enqueue(c);
            }
            
        }
        //set deck
        player.setDeck(Deck);
    }

    //Shuffle method
    public void Shuffle(Queue<Card> D)
    {

    }
}
