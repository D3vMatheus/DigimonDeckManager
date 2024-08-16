using DigimonDeckManager.DDMDB;
using DigimonDeckManager.Enums;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.UseCases
{
    public class CreateCard
    {
        public static Card CreateCardAllTypes() {

            string? number, name, type, attribute, evolutionCondition, form, mainEff, secondEff, stringLv, stringPc, stringDp;
            int? lv, pc, dp;
            CardCategory category;
            CardRarity rarity;
            CardColor color;

            do
            {
                Console.WriteLine("Card number: ");
                number = Console.ReadLine().ToUpper();
             
                Console.WriteLine("Card name: ");
                name = Console.ReadLine();
            
            } while (string.IsNullOrEmpty(number) && string.IsNullOrEmpty(name));

            Console.WriteLine("Card rarity: ");
            rarity = Selectable.Rarity();
            
            Console.WriteLine("Card color: ");
            color = Selectable.Color();
            
            Console.WriteLine("Card category: ");
            category = Selectable.Category();
            
            Console.WriteLine("Card type: (Press enter if doesn't have)");
            type = Console.ReadLine();
            
            Console.WriteLine("Card attribute: (Press enter if doesn't have)");
            attribute = Console.ReadLine();
            
            Console.WriteLine("Card level: (Press enter if doesn't have)");
            stringLv = Console.ReadLine();
            lv = IntOrNull.ConvertToNullableInt(stringLv);

            Console.WriteLine("Play cost: (Press enter if doesn't have)");
            stringPc = Console.ReadLine();
            pc = IntOrNull.ConvertToNullableInt(stringPc);

            Console.WriteLine("Digimon power: (Press enter if doesn't have)");
            stringDp = Console.ReadLine();
            dp = IntOrNull.ConvertToNullableInt(stringDp);

            Console.WriteLine("Digievolution Condition: (Press enter if doesn't have)");
            evolutionCondition = Console.ReadLine();
            
            Console.WriteLine("Card form/stage: (Press enter if doesn't have)");
            form = Console.ReadLine();
            
            Console.WriteLine("Card main effect: (Press enter if doesn't have)");
            mainEff = Console.ReadLine();
            
            Console.WriteLine("Card secondary effect: (Press enter if doesn't have)");
            secondEff = Console.ReadLine();


            Card card = new(number, name, rarity, color, category, type, attribute, lv, pc, dp, evolutionCondition, form, mainEff, secondEff);
            
            return card;
        }
    }
}
