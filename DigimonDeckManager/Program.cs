using DigimonDeckManager;
using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;



//Create method Display info
//Initiate cards CRUD

CardList cardlist = new();
List<Card> cards = CardList.GetAllCardsFromCardList();
cardlist.AddCard();

Console.WriteLine(CardList.GetAllCardsFromCardList());

cardlist.ShowAllCards();
foreach (Card card in CardList.GetAllCardsFromCardList())
{
    DisplayGeneral.GeneralCardInfo(card);
}

Deck test = new("test");
test.AddCardToDeck("ST1-01");
test.AddCardToDeck("BT1-010");
test.ShowDeckCards();
test.RemoveCardFromDeck("ST1-01");
test.ShowDeckCards();

cardlist.ShowAllCards();
