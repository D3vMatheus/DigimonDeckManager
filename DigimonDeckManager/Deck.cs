using DigimonDeckManager.UseCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DigimonDeckManager
{
    public class Deck : CardList
    {
        private string _deckName;
        public string DeckName { get { return _deckName; } set { _deckName = value; } }
        private int _cardLimit = 50;
        public int CardLimit { get { return _cardLimit; } set { _cardLimit = value; } }
        
        private List<Card> _deck;
        public List<Card> CardDeck { get { return _deck; } set { _deck = value; } }

        public Deck(string DeckName)
        {
            _deckName = DeckName;
            _deck = new List<Card>();
        }

/*        public bool MaxCopyCard(string number)
        {
            int count =0;
            foreach(Card n in CardDeck)
            {
                if(n != null && n.ToString().StartsWith(number))
                    count++;

            }
            if (count > 5)
                return true;
            return false;
            
        }*/

        public void ShowDeckCards()
        {
            Console.WriteLine($"Deck - {DeckName}");
            foreach (Card card in CardDeck)
            {
                Console.WriteLine($"{card.CardNumber} - {card.CardName}");
            }
        }

        public void AddCardToDeck(string number)
        {
            List<Card> cards = GetAllCardsFromCardList();
            foreach (Card card in cards)
            {
                if (card == null)
                    Console.WriteLine("Couldn't add to deck because this card doesn't exist");
                else
                {
                    if (card.CardNumber == number)
                    {
                        _deck.Add(card);
                        CardLimit--;
                        Console.WriteLine($"{card.CardNumber} - {card.CardName} was sucessfully added to {DeckName}");
                    }
                }
            }
        }

        public void RemoveCardFromDeck(string number)
        {

            var cardFound = CardDeck.Find(n => n.CardNumber.Contains(number));

            if (cardFound == null)
                Console.WriteLine("Couldn't remove from deck because this card doesn't exist");
            else
            {
                CardDeck.Remove(cardFound);
                CardLimit++;
                Console.WriteLine($"{cardFound.CardNumber} - {cardFound.CardName} was sucessfully removed from {DeckName}");
            }
        }
    }
}
