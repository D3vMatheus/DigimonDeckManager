using DigimonDeckManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager
{
    public class DigiEggCard : Card
    {
        private int lv;
        private string type;
        private string form;
        private string inheritedEffect;

        public DigiEggCard(string CardNumber, string CardName, string CardRarity, string CardColour, int Lv, string Type, string Form, string InheritedEffect) : base(CardNumber, CardName, CardRarity, CardColour)
        {
            lv = Lv;
            type = Type;
            form = Form;
            inheritedEffect = InheritedEffect;
        }
    }
}