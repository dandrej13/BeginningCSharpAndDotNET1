﻿using Ch10CardGame;
using Ch10CardLib;

Deck myDeck = new Deck();
myDeck.Shuffle();
for (int i = 0; i < 52; i++)
{
    Card tempCard = myDeck.GetCard(i);
    Console.Write(tempCard.ToString());
    if (i != 51)
    {
        Console.WriteLine(", ");
    }
    else
    {
        Console.WriteLine("");
    }
}
    Console.ReadKey();