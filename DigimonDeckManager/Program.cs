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

List<Card> card = new();
card.Add(koromon);
List<Card> newCards = new();

Deck newdeck = new("teste", newCards);

newdeck.AddCardToDeck(koromon.CardNumber);
newdeck.ShowDeckCards();
newdeck.RemoveCardFromDeck("BT1-01");
newdeck.ShowDeckCards();

/*
newCard.UpdateCard("ST102");
newCard.DeleteCard("ST1-02");
newCard.ShowAllCards();
*/

