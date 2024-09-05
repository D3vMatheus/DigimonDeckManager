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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DigimonDeckManager
{
    public class Deck
    {

        public void CreateNewDeck()
        {
            DeckRepository deck = new();
            deck.CreateDeck();
        }
        public void DeleteDeck()
        {
            DeckRepository deck = new();
            string deckId;
            do
            {
                Console.WriteLine("Insert Deck id");
                deckId = Console.ReadLine();

            } while (string.IsNullOrEmpty(deckId));
            deck.DeleteDeck(Convert.ToInt16(deckId));
        }
        public void AddCard() {
            DeckRepository deck = new();
            
            string deckId;
            string number;

            do
            {
                Console.WriteLine("Insert Deck id");
                deckId = Console.ReadLine();
                Console.WriteLine("Insert card number");
                number = Console.ReadLine().ToUpper();

            } while (string.IsNullOrEmpty(deckId) || string.IsNullOrEmpty(number));


            deck.InsertCardIntoDeck(Convert.ToInt16(deckId), number);
        }
        public void ShowDeckCards()
        {
            DeckRepository deck = new();
            string deckId;

            do
            {
                Console.WriteLine("Insert Deck id");
                deckId = Console.ReadLine();

            } while (string.IsNullOrEmpty(deckId));

            deck.ShowDeckCards(Convert.ToInt16(deckId));
        }

        public void DeleteCard()
        {
            DeckRepository deck = new();
            string deckId;
            string number;

            do
            {
                Console.WriteLine("Insert Deck id");
                deckId = Console.ReadLine();
                Console.WriteLine("Insert card number");
                number = Console.ReadLine().ToUpper();

            } while (string.IsNullOrEmpty(deckId) || string.IsNullOrEmpty(number));

            deck.DeleteCardFromDeck(Convert.ToInt16(deckId), number);
        }
        }
    }
