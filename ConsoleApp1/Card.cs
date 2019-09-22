using System;

public class Card
{
    public Card()
    {
    }

    public Card(int x, int z)
    {
        this.number = x;
        this.suit = z;
    }
    
    private int suit;
    private int number;

    public int getNumber()
    {
        return this.number;
    }

    //Could be optimized to take up less lines. 
    public string toString()
    {
        string N = "";
        string S = "";

        switch (suit)
        {
            case 1:
                S = "clubs";
                break;
            case 2:
                S = "diamonds";
                break;
            case 3:
                S = "spades";
                break;
            case 4:
                S = "hearts";
                break;
        }
        switch (number)
        {
            
            case 1:
                N = "2";
                break;
            case 2:
                N = "3";
                break;
            case 3:
                N = "4";
                break;
            case 4:
                N = "5";
                break;
            case 5:
                N = "6";
                break;
            case 6:
                N = "7";
                break;
            case 7:
                N = "8";
                break;
            case 8:
                N = "9";
                break;
            case 9:
                N = "10";
                break;
            case 10:
                N = "Jack";
                break;
            case 11:
                N = "Queen";
                break;
            case 12:
                N = "King";
                break;
            case 13:
                N = "Ace";
                break;
        }
        return N + " of " + S + "\n";
    }
}
