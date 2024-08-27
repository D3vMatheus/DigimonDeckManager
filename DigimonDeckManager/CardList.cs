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
        private static List<Card> _listcards;
        public List<Card> ListCards { get { return _listcards; } set { _listcards = value; } }

        public CardList()
        {
            ListCards = new List<Card>(GetAllCardsFromCardList());
        }

        public static List<Card> GetAllCardsFromCardList()
        {
            List<Card> cards = new()
            {
                new Card() {CardNumber = "ST1-01", CardName = "Koromon", CardRarity = CardRarity.Uncommon, CardColour = CardColor.Red,
                            CardCategory= CardCategory.DigiEgg, Type = "Lesser", Attribute = "vaccine", Lv = 2,
                            PlayCost = null, DigimonPower = null,DigievolutionCondition= null, Form = "In-Training",
                            MainEffect= null,SecondaryEffect = "While this Digimon has 4 or more digivolution cards, it gets +1000 DP."}
            };
            return cards;
        }
        public void ShowAllCards()
        {
            CardListRepository cards = new();
            cards.GetAllCardsFromCardList();
        }
        public void ShowCardByCardNumber(string cardNumber)
        {
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

        public void UpdateCard(string number)
        {

            var cardFound = ListCards.Find(n => n.CardNumber.Contains(number.ToUpper()));

            if (cardFound == null)
                Console.WriteLine("Couldn't update because this card doesn't exist");
            else
            {
                CardUpdate.Update(cardFound);
                Console.WriteLine($"{cardFound.CardNumber} - {cardFound.CardName} was sucessfully updated");

            }
        }


    }
}
