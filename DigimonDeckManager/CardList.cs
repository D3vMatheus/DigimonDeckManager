using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (Card card in ListCards)
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine($"Number: {card.CardNumber}");
                Console.WriteLine($"Name: {card.CardName}");
                Console.WriteLine($"Rarity: {card.CardRarity}");
                Console.WriteLine($"Color: {card.CardColour}");
                Console.WriteLine($"Category: {card.CardCategory}");
                Console.WriteLine($"Type: {card.Type}");
                Console.WriteLine($"Attribute: {card.Attribute}");
                Console.WriteLine($"Level: {card.Lv}");
                Console.WriteLine($"PC: {card.PlayCost}");
                Console.WriteLine($"DP: {card.DigimonPower}");
                Console.WriteLine($"Digievolution Condition: {card.DigievolutionCondition}");
                Console.WriteLine($"Form/Stage: {card.Form}");
                Console.WriteLine($"Main effect: {card.MainEffect}");
                Console.WriteLine($"Secondary effect: {card.SecondaryEffect}");
                Console.WriteLine("___________________________________");
            }
        }
        public void AddCard(Card card)
        {
            ListCards.Add(card);
        }

        public void AddCard()
        {
            Card newCard = CreateCard.CreateCardAllTypes();
            bool cardExist = ListCards.Any(n => n.CardNumber.Contains(newCard.CardNumber));

            if (!cardExist)
            {
                ListCards.Add(newCard);
                Console.WriteLine(ListCards);
                Console.WriteLine("Card sucessfully addded.");
            }
            else
                Console.WriteLine("Can't add this card beacause already exists one with the same Number.");
        }

        public void DeleteCard(string number)
        {

            var cardFound = ListCards.Find(n => n.CardNumber.Contains(number.ToUpper()));

            if (cardFound == null)
                Console.WriteLine("Couldn't remove because this card doesn't exist");
            else
            {
                ListCards.Remove(cardFound);
                Console.WriteLine($"{cardFound.CardNumber} - {cardFound.CardName} was sucessfully removed");
            }
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
