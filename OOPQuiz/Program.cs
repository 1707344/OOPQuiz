using System;

namespace OOPQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card(3, Card.Color.Black, Card.Type.Diamond);
            Card card2 = new Card(5, Card.Color.Red, Card.Type.Spade);
            Card card3 = new Card(9, Card.Color.Black, Card.Type.Clover);

            Card[] cards = { card1, card2, card3 };
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].Display();
            }

            Console.WriteLine("Shuffle\n\n");
            cards = Card.Shuffle(cards);

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].Display();
            }
        }
    }
}
