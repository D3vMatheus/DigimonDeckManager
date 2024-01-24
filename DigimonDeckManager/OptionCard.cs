using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager
{
    class OptionCard : TamerCard
    {
        public OptionCard(string CardNumber, string CardName, string CardRarity, string CardColour, int playCost, string effects, string securityEffects) : base(CardNumber, CardName, CardRarity, CardColour, playCost, effects, securityEffects)
        {
        }
    }
}
