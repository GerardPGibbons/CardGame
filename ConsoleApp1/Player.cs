using System;
using System.Collections.Generic;

public class Player
{
    //default constructor
    public Player()
    {
        this.name = "Bob";
    }

    public Player(string n, Queue<Card> D)
    {
        this.Deck = D;
        this.name = n;
    }

    //Player needs a name.  
    private string name;
    //Deck will be FIFO queue.
    private Queue<Card> Deck;

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
