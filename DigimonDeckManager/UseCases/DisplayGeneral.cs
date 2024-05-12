using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.UseCases
{
    public class DisplayGeneral
    {
        public static void GeneralCardInfo(Card card)
        {
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
        }
    }
}
