using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager
{
    class TamerCard : Card
    {
        private int playCost;
        private string effects;
        private string securityEffects;

        public TamerCard(string CardNumber, string CardName, string CardRarity, string CardColour, int playCost, string effects, string securityEffects) : base(CardNumber, CardName, CardRarity, CardColour)
        {
            this.playCost = playCost;
            this.effects = effects;
            this.securityEffects = securityEffects;
        }

        public int PlayCost {  get { return playCost; } set {  playCost = value; } }
        public string Effects { get {  return effects; } set {  effects = value; } }
        public string SecurityEffects { get {  return securityEffects; } set {  securityEffects = value; } }
    }
}
