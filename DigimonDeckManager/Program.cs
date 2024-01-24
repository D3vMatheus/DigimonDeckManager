using DigimonDeckManager;

DigiEggCard digieggcard = new DigiEggCard("ST1-01", "Koromon", "Uncommon", "Red", 2, "Lesser", "In-Training", "While this Digimon has 4 or more digivolution cards, it gets +1000 DP.");
Console.WriteLine(digieggcard.CardNumber);
Console.WriteLine("Original card name: "+ digieggcard.CardName);
digieggcard.CardName = "Agumon";
Console.WriteLine(digieggcard.Lv);
Console.WriteLine(digieggcard.InheritedEffect);
Console.WriteLine("Card name setted: " + digieggcard.CardName);

Console.WriteLine();

DigimonCard digimonCard = new DigimonCard("BT1-010", "Agumon", "Rare", "Red", 3, 2000, "Colour Red Level 2 DigivolveCost 0" ,"[On Play] Reveal the top 5 cards of your deck. Add 1 Tamer card among them to your hand. Place the rest at the bottom of the deck in any order.", 2, "Rookie", "Vaccine", "", "Reptile");
Console.WriteLine("Digimon card info");
Console.WriteLine(digimonCard.CardNumber);
Console.WriteLine(digimonCard.CardName);
Console.WriteLine(digimonCard.CardRarity);
Console.WriteLine(digimonCard.CardColour);
Console.WriteLine(digimonCard.PlayCost);
Console.WriteLine(digimonCard.DigimonPower);
Console.WriteLine(digimonCard.DigievolutionCondition);
Console.WriteLine(digimonCard.Effects);
Console.WriteLine(digimonCard.Lv);
Console.WriteLine(digimonCard.InheritedEffect);
Console.WriteLine(digimonCard.Type);

Console.WriteLine();

TamerCard tamerCard = new TamerCard("ST2-12", "Matt Ishida", "Rare", "Blue", 2, "[Start of Your Turn] If your opponent has a Digimon with no Digivolution cards, gain 1 memory.", "[Security] Play this card without paying its memory cost.");
Console.WriteLine("Tamer Card Info");
Console.WriteLine(tamerCard.CardNumber);
Console.WriteLine(tamerCard.CardName);
Console.WriteLine(tamerCard.CardRarity);
Console.WriteLine(tamerCard.PlayCost);
Console.WriteLine(tamerCard.Effects);
Console.WriteLine(tamerCard.SecurityEffects);

Console.WriteLine();

OptionCard optionCard = new OptionCard("ST3-15", "Holy Flame", "Common", "Yellow", 2, "[Main] 1 of your opponent's Digimon gains ＜Security Attack -3＞ (This Digimon checks 3 fewer security cards) until the end of their turn.", "[Security] All of your opponent's Digimon gain ＜Security Attack -1＞ (This Digimon checks 1 fewer security card) for the turn.");
Console.WriteLine("Option Card Info");
Console.WriteLine(optionCard.CardNumber);
Console.WriteLine(optionCard.CardName);
Console.WriteLine(optionCard.CardRarity);
Console.WriteLine(optionCard.PlayCost);
Console.WriteLine(optionCard.Effects);
Console.WriteLine(optionCard.SecurityEffects);
