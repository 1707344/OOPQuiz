using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuiz
{
    class Card
    {
        /// <summary>
        /// The Number on the card
        /// </summary>
        int number;
        public enum Type
        {
            Spade, 
            Clover,
            Heart,
            Diamond
        }
        public enum Color{
            Red,
            Black
        }

        Color cardColor;
        Type cardType;
        float width;
        float height;
        string backColor;

        public Card(int number, Color cardColor, Type cardType)
        {
            this.number = number;
            this.cardColor = cardColor;
            this.cardType = cardType;
        }

        public Card(int number, Color cardColor, Type cardType, float width, float height, string backColor) : this(number, cardColor, cardType)
        {
            this.width = width;
            this.height = height;
            this.backColor = backColor;
        }

        public static Card[] Shuffle(Card[] cards)
        {
            Random random = new Random();
            for (int i = 0; i < cards.Length; i++)
            {
                int randomCardIndex = random.Next(0, cards.Length);
                Card card = cards[i];
                Card randomCard = cards[randomCardIndex];

                cards[i] = null;
                cards[randomCardIndex] = null;

                cards[i] = randomCard;
                cards[randomCardIndex] = card;
            }

            return cards;
        }

        public void Throw()
        {
            Random random = new Random();

            string text = random.Next(0, 5) > 3 ? "You threw the card perfectly!" : "Some how the card went backwards";
            Console.WriteLine(text);
        }

        public void Display()
        {
            string type = "";
            switch (cardType)
            {
                case Type.Clover:
                    type = "♣";
                    break;
                case Type.Spade:
                    type = "♠";
                    break;
                case Type.Heart:
                    type = "♥";
                    break;
                case Type.Diamond:
                    type = "♦";
                    break;
            }

            string color = "";
            switch (cardColor)
            {
                case Color.Red:
                    color = "Red";
                    break;
                case Color.Black:
                    color = "Black";
                    break;

            }

            Console.WriteLine($"Card type: {type}\nColor: {color}\nNumber: {number}\n\n\n");
        }
    }
}
