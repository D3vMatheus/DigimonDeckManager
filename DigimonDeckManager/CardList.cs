using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;
using Npgsql;
using DigimonDeckManager.DDMDB;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;
using System;

namespace DigimonDeckManager
{
    public class CardList
    {
        public void ShowAllCards()
        {
            CardListRepository cards = new();
            cards.GetAllCardsFromCardList();
        }
        public void ShowCardByCardNumber()
        {
            string cardNumber;
            do
            {
                Console.WriteLine("Insert the card number: ");
                cardNumber = Console.ReadLine().ToUpper();

            } while (string.IsNullOrEmpty(cardNumber));

            CardListRepository card = new();
            card.GetCardFromCardNumber(cardNumber);
        }
        public void AddCard()
        {
            CardListRepository card = new();
            Card newCard = CreateCard.CreateCardAllTypes();
            card.AddCardIntoCardList(newCard);
        }

        public void DeleteCard()
        {
            Console.WriteLine("Digit the card number to delete a card");
            string cardNumber = Console.ReadLine().ToUpper();
            CardListRepository card = new();
            card.DeleteCardFromList(cardNumber);
       }
    }
}
