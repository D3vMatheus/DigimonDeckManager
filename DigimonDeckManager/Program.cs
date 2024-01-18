using DigimonDeckManager;

Card digieggcard = new DigiEggCard("ST1-01", "Koromon", "Uncommon", "Red", 2, "Lesser", "In-Training", "While this Digimon has 4 or more digivolution cards, it gets +1000 DP.");
Console.WriteLine(digieggcard.CardNumber);
digieggcard.CardName = "Agumon";
Console.WriteLine(digieggcard.CardName);
