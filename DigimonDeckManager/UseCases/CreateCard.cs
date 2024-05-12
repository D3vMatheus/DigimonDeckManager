using DigimonDeckManager.Enums;
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

            Console.WriteLine("Card number: ");
            string number = Console.ReadLine();

            Console.WriteLine("Card name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Card rarity: ");
            string rarity = Console.ReadLine();

            Console.WriteLine("Card color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Card category: ");
            Console.WriteLine($" 0-{CardCategory.DigiEgg}\n 1-{CardCategory.Digimon}\n 2-{CardCategory.Tamer}\n 3-{CardCategory.Option}");
            int selectOption= Convert.ToUInt16(Console.ReadLine());
            CardCategory category = new ();

            switch (selectOption)
            {
                case 0:
                    category = CardCategory.DigiEgg;
                    break;
                case 1:
                    category = CardCategory.Digimon;
                    break;
                case 2:
                    category = CardCategory.Tamer;
                    break;
                case 3:
                    category = CardCategory.Option;
                    break;
            }
            Console.WriteLine("Card type: ");
            string type = Console.ReadLine();

            Console.WriteLine("Card attribute: ");
            string attribute= Console.ReadLine();

            Console.WriteLine("Card level: ");
            int lv= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Play cost: ");
            int pc= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digimon power: ");
            int dp= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digievolution Condition: ");
            string evolutionCondition = Console.ReadLine();

            Console.WriteLine("Card form/stage: ");
            string form = Console.ReadLine();

            Console.WriteLine("Card main effect: ");
            string mainEff= Console.ReadLine();

            Console.WriteLine("Card secondary effect: ");
            string secondEff= Console.ReadLine();

            Card card = new Card(number, name, rarity, color, category, type, attribute, lv, pc, dp, evolutionCondition, form, mainEff, secondEff);
            
            return card;
        }
    }
}
