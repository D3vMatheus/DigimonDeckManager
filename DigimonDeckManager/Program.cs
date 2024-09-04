using DigimonDeckManager;
using DigimonDeckManager.DDMDB;
using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;

Connection db= new Connection();
db.OpenConnection();
CardList cardlist = new();
Deck deck = new();
deck.ShowDeckCards();
deck.DeleteCard();
cardlist.ShowCardByCardNumber("SGT-1");
cardlist.ShowCardByCardNumber("SBT-");
deck.AddCard();
//cardlist.DeleteCard();
cardlist.ShowAllCards();
cardlist.AddCard();
cardlist.ShowAllCards();

//Create method Display info
//Initiate cards CRUD

/*List<Card> cards = CardList.GetAllCardsFromCardList();
cardlist.AddCard();

Console.WriteLine(CardList.GetAllCardsFromCardList());



Deck test = new("test");
test.AddCardToDeck("ST1-01");
test.AddCardToDeck("BT1-010");
test.ShowDeckCards();
test.RemoveCardFromDeck("ST1-01");
test.ShowDeckCards();

cardlist.ShowAllCards();
*/