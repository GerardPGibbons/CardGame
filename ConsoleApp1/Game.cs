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
       
        for(int i = 0; i < count ; i++)
        {
            deckList.Add(D.Dequeue());
           
        }

        while(deckList.Count != 0)
        {
            randIndex = rand.Next(0, deckList.Count);
            shuffledDeck.Add(deckList[randIndex]);
            deckList.RemoveAt(randIndex);
        }
        
        for(int j = 0; j < 52; j++)
        {
            D.Enqueue(shuffledDeck[j]);
        }
        
        return D;
    }
}
