using DigimonDeckManager.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.UseCases
{
    public class Selectable
    {
        public static CardCategory Category()
        {
            string? selectOption;
            CardCategory category;

            do
            {
                Console.WriteLine($" 0-{CardCategory.DigiEgg}\n 1-{CardCategory.Digimon}\n 2-{CardCategory.Tamer}\n 3-{CardCategory.Option}");

                selectOption = Console.ReadLine();

                switch (selectOption)
                {
                    case "0":
                        category = CardCategory.DigiEgg;
                        break;
                    case "1":
                        category = CardCategory.Digimon;
                        break;
                    case "2":
                        category = CardCategory.Tamer;
                        break;
                    case "3":
                        category = CardCategory.Option;
                        break;
                    default:
                        Console.WriteLine("This isn't a valid option");
                        category = (CardCategory)(-1);
                        break;
                }
            } while (category < CardCategory.DigiEgg || category > CardCategory.Option);
            Console.WriteLine(category);
            return category;
        }
        public static CardRarity Rarity()
        {
            string? selectOption;
            CardRarity rarity;

            do
            {
                Console.WriteLine($" 0-{CardRarity.Common}\n 1-{CardRarity.Uncommon}\n 2-{CardRarity.Rare}\n 3-{CardRarity.SuperRare}\n 4-{CardRarity.SecretRare}\n 5-{CardRarity.Promo}");

                selectOption = Console.ReadLine();

                switch (selectOption)
                {
                    case "0":
                        rarity = CardRarity.Common;
                        break;
                    case "1":
                        rarity = CardRarity.Uncommon;
                        break;
                    case "2":
                        rarity = CardRarity.Rare;
                        break;
                    case "3":
                        rarity = CardRarity.SuperRare;
                        break;
                    case "4":
                        rarity = CardRarity.SecretRare;
                        break;
                    case "5":
                        rarity = CardRarity.Promo;
                        break;
                    default:
                        Console.WriteLine("This isn't a valid option");
                        rarity = (CardRarity)(-1);
                        break;
                }
            } while (rarity < CardRarity.Common || rarity > CardRarity.Promo);
            Console.WriteLine(rarity);
            return rarity;
        }


        public static CardColor Color()
        {
            string? selectOption;
            CardColor color;

            do
            {
                Console.WriteLine($" 0-{CardColor.Red}\n 1-{CardColor.Blue}\n 2-{CardColor.Yellow}\n 3-{CardColor.Green}\n 4-{CardColor.Black}\n 5-{CardColor.Purple}\n 6-{CardColor.White}");

                selectOption = Console.ReadLine();

                switch (selectOption)
                {
                    case "0":
                        color = CardColor.Red;
                        break;
                    case "1":
                        color = CardColor.Blue;
                        break;
                    case "2":
                        color = CardColor.Yellow;
                        break;
                    case "3":
                        color = CardColor.Green;
                        break;
                    case "4":
                        color = CardColor.Black;
                        break;
                    case "5":
                        color = CardColor.Purple;
                        break;
                    case "6":
                        color = CardColor.White;
                        break;
                    default:
                        Console.WriteLine("This isn't a valid option");
                        color = (CardColor)(-1);
                        break;
                }
            } while (color < CardColor.Red || color > CardColor.White);
            Console.WriteLine(color);
            return color;
        }
    }
}
