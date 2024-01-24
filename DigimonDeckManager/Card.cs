using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DigimonDeckManager
{
    abstract class Card
    {
        private string cardNumber;
        private string cardName;
        private string cardRarity;
        private string cardColour;

        public Card(string CardNumber, string CardName, string CardRarity, string CardColour) {
            cardNumber = CardNumber;
            cardName = CardName;
            cardRarity = CardRarity;
            cardColour = CardColour;
        }

        public string CardNumber { get { return cardNumber; } set { cardNumber = value; } }
        public string CardName { get { return cardName; } set { cardName = value; } }
        public string CardRarity { get { return cardRarity; } set { cardRarity = value; } }
        public string CardColour { get { return cardColour; } set { cardColour = value; } }
    }
}
