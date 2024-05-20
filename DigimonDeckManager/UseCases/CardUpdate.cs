using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.UseCases
{
    public class CardUpdate
    {

        public static void Update(Card card)
        {

            string? stringLv, stringPc, stringDp;
            
            do
            {
                Console.WriteLine("Card number: ");
                card.CardNumber = Console.ReadLine();

                Console.WriteLine("Card name: ");
                card.CardName = Console.ReadLine();

            } while (string.IsNullOrEmpty(card.CardNumber) && string.IsNullOrEmpty(card.CardName));

            Console.WriteLine("Card rarity: ");
            card.CardRarity= Selectable.Rarity();

            Console.WriteLine("Card color: ");
            card.CardColour= Selectable.Color();

            Console.WriteLine("Card category: ");
            card.CardCategory = Selectable.Category();

            Console.WriteLine("Card type: (Press enter if doesn't have)");
            card.Type= Console.ReadLine();

            Console.WriteLine("Card attribute: (Press enter if doesn't have)");
            card.Attribute = Console.ReadLine();

            Console.WriteLine("Card level: (Press enter if doesn't have)");
            stringLv = Console.ReadLine();
            card.Lv = IntOrNull.ConvertToNullableInt(stringLv);

            Console.WriteLine("Play cost: (Press enter if doesn't have)");
            stringPc = Console.ReadLine();
            card.PlayCost = IntOrNull.ConvertToNullableInt(stringPc);

            Console.WriteLine("Digimon power: (Press enter if doesn't have)");
            stringDp = Console.ReadLine();
            card.DigimonPower = IntOrNull.ConvertToNullableInt(stringDp);

            Console.WriteLine("Digievolution Condition: (Press enter if doesn't have)");
            card.DigievolutionCondition = Console.ReadLine();

            Console.WriteLine("Card form/stage: (Press enter if doesn't have)");
            card.Form= Console.ReadLine();

            Console.WriteLine("Card main effect: (Press enter if doesn't have)");
            card.MainEffect= Console.ReadLine();

            Console.WriteLine("Card secondary effect: (Press enter if doesn't have)");
            card.SecondaryEffect = Console.ReadLine();
        }
    }
}