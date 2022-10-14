using Ch10CardGame;
using Ch10CardLib;

Deck deck = new Deck();
for (int j = 0; j < 1000; j++) { 
deck.Shuffle();

Card[] hand = new Card[5];
Random random = new Random();

for (int i = 0; i <= 4; i++)
{

    int randomIndex = random.Next(52);
    hand[i] = deck.GetCard(randomIndex);

    bool notFoundCard = true;

    while (notFoundCard == true)
    {
        Card card = deck.GetCard(randomIndex);
        if (!hand.Contains(card))
        {
            notFoundCard = false;
            hand[i] = card;
        }

    }

}
    Suit suit = hand[0].suit;
    bool flush = true;
    for (int i = 1; i < hand.Length; i++)
    {
    if (suit != hand[i].suit)
      {
         flush = false;
            break;
      }
    }

if (flush)
{
    for (int i = 0; i < hand.Length; i++)
    {
        Console.WriteLine(hand[i].ToString());
    }
    Console.WriteLine("You got flush");
}
else
{
    
    Console.WriteLine("You got no flush");

}

}

