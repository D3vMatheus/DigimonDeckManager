using DigimonDeckManager.DDMDB;
using DigimonDeckManager.UseCases;
using Microsoft.VisualBasic;
using Npgsql;
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

        public void CreateNewDeck()
        {
            DeckRepository deck = new();
            deck.DeckTable();
        }
        public void AddCard() {
            DeckRepository deck = new();
            string deckId;
            string number;

            Console.WriteLine("Insert Deck id");
            deckId = Console.ReadLine();
            Console.WriteLine("Insert card number");
            number = Console.ReadLine().ToUpper();

            deck.InsertCardIntoDeck(Convert.ToInt16(deckId), number);
        }
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

                if (card.CardNumber == number && CardLimit>0)
                {
                    CardDeck.Add(card);
                    CardLimit--;
                    Console.WriteLine($"{card.CardNumber} - {card.CardName} was sucessfully added to {DeckName}");
                }
                else
                    Console.WriteLine("Couldn't add to deck because this card doesn't exist");
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
