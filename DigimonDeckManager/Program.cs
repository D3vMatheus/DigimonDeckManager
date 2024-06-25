using DigimonDeckManager;
using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;

Card koromon = new ("ST1-01", "Koromon", CardRarity.Uncommon, CardColor.Red,
                        CardCategory.DigiEgg, "Lesser", "vaccine", 2,
                        null, null, null, "In-Training",
                        null, "While this Digimon has 4 or more digivolution cards, it gets +1000 DP.");
DisplayGeneral.GeneralCardInfo(koromon);



//Create method Display info
//Initiate cards CRUD

CardList cardlist = new();
cardlist.AddCard(koromon);

cardlist.AddCard();
cardlist.UpdateCard("ST1-010");
cardlist.DeleteCard("BT1-010");

foreach (Card card in CardList.listcards)
{
    DisplayGeneral.GeneralCardInfo(card);
}

/*Card card = new();
card.AddCard(koromon);

List<Card> cardList = new();
cardList.Add(card);

Deck newdeck = new("teste", Card._listcards);

newdeck.AddCardToDeck(koromon.CardNumber);
newdeck.ShowDeckCards();
newdeck.RemoveCardFromDeck("BT1-01");
newdeck.ShowDeckCards();*/

/*
newCard.UpdateCard("ST102");
newCard.DeleteCard("ST1-02");
newCard.ShowAllCards();
*/

