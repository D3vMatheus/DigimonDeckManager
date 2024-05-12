using DigimonDeckManager;
using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;


Card koromon = new Card("ST1-01", "Koromon", "Uncommon", "Red",
                        CardCategory.DigiEgg, "Lesser", "vaccine", 2,
                        null, null, null, "In-Training",
                        null, "While this Digimon has 4 or more digivolution cards, it gets +1000 DP.");


DisplayGeneral.GeneralCardInfo(koromon);




//Create method Display info
//Initiate cards CRUD
Card newCard = new();
newCard.AddCard();
newCard.AddCard(koromon); 
newCard.ShowAllCards();