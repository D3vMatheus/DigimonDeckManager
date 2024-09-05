using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.UseCases
{
    public class Menu
    {
        public void StartMenu()
        {
 
            Console.WriteLine("1 - Card List menu");
            Console.WriteLine("2 - Deck menu");
            Console.WriteLine("3 - Exit");

            Console.WriteLine("Digit a number to choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CardListMenu();
                    break;

                case "2":
                    DeckMenu();
                    break;

                case "3":
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        public void CardListMenu()
        {
            Console.WriteLine("MENU - CARD LIST");
            Console.WriteLine("1 - Add card into list");
            Console.WriteLine("2 - Delete card from list");
            Console.WriteLine("3 - Show all cards in card list");
            Console.WriteLine("4 - Show card (card number)");
            Console.WriteLine("Digit a number to choose an option: ");
            string option = Console.ReadLine();
            CardList cardlist = new();

            switch (option)
            {
                case "1":
                    cardlist.AddCard();
                    break;

                case "2":
                    cardlist.DeleteCard();
                    break;

                case "3":
                    cardlist.ShowAllCards();
                    break;

                case "4":
                    cardlist.ShowCardByCardNumber();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }

        public void DeckMenu()
        {
            Console.WriteLine("MENU - DECK LIST");
            Console.WriteLine("1 - Create new deck");
            Console.WriteLine("2 - Add card into deck");
            Console.WriteLine("3 - Remove card from deck");
            Console.WriteLine("4 - Show deck cards list");
            Console.WriteLine("Digit a number to choose an option: ");
            string option = Console.ReadLine();
            Deck deck = new();

            switch (option)
            {
                case "1":
                    deck.CreateNewDeck();
                    break;

                case "2":
                    deck.AddCard();
                    break;

                case "3":
                    deck.DeleteCard();
                    break;

                case "4":
                    deck.ShowDeckCards();
                    break;
                case "5":
                    deck.DeleteDeck();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
}
