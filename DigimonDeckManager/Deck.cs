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
            deck.CreateDeck();
        }
        public void DeleteDeck()
        {

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
            DeckRepository deck = new();
            string deckId;

            Console.WriteLine("Insert Deck id");
            deckId = Console.ReadLine();
            deck.ShowDeckCards(Convert.ToInt16(deckId));
        }

        public void DeleteCard()
        {
            DeckRepository deck = new();
            string deckId;
            string number;

            Console.WriteLine("Insert Deck id");
            deckId = Console.ReadLine();
            Console.WriteLine("Insert card number");
            number = Console.ReadLine().ToUpper();

            deck.DeleteCardFromDeck(Convert.ToInt16(deckId), number);
        }
        }
    }
