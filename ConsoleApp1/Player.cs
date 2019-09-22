using System;
using System.Collections.Generic;

public class Player
{
    //Player needs a name.  
    private string name;
    //Deck will be FIFO queue. (Since you draw from the top)
    private Queue<Card> Deck;

    //default constructor
    public Player()
    {
        this.name = "Bob";
    }

    public string getName()
    {
        return name;
    }
    
    public void setName(string n)
    {
        this.name = n;
    }
    public Queue<Card> getDeck()
    {
        return Deck;
    }

    public void setDeck(Queue<Card> D)
    {
        Deck = D;
    }

    //Used for testing decks.
    public void toString()
    {
        Console.WriteLine(this.name + " count: " + Deck.Count);
        Card c = new Card();
        while(Deck.Count > 0)
        {
            c = Deck.Dequeue();
            c.toString();

        }
    }

	
}
