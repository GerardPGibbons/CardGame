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
    public Queue<Card> getDeck()
    {
        return Deck;
    }

    public void setDeck(Queue<Card> D)
    {
        Deck = D;
    }

    

	
}
