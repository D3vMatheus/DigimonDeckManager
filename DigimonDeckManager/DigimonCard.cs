using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager
{
    class DigimonCard : Card
    {
        private int playCost;
        private int digimonPower;
        private string digievolutionCondition;
        private string effects;
        private int lv;
        private string form;
        private string attribute;
        private string inheritedEffect;
        private string type;

        public DigimonCard(string CardNumber, string CardName, string CardRarity, string CardColour, int PlayCost, int DigimonPower, string DigievolutionCondition, string Effects, int Lv, string Form, string Attribute, string InheritedEffect, string Type) : base(CardNumber, CardName, CardRarity, CardColour)
        {
            playCost = PlayCost;
            digimonPower = DigimonPower;
            digievolutionCondition = DigievolutionCondition;
            effects = Effects;
            lv = Lv;
            form = Form;
            attribute = Attribute;
            inheritedEffect = InheritedEffect;
            type = Type;
        }

        public int PlayCost {  get { return playCost; } set {  playCost = value; } }
        public int DigimonPower { get { return digimonPower; } set { digimonPower = value; } }
        public string DigievolutionCondition { get {  return digievolutionCondition; } set {  digievolutionCondition = value; } }
        public string Effects { get {  return effects; } set {  effects = value; } }
        public int Lv { get { return lv; } set { lv = value; } }
        public string Form { get { return form; } set { form = value; } }
        public string Attribute { get { return attribute; } set { attribute = value; } }
        public string InheritedEffect { get { return inheritedEffect; } set { inheritedEffect = value; } }
        public string Type { get { return type; } set { type = value; } }


    }
}
