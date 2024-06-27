using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DigimonDeckManager
{
    public class Card
    {
        
        private string _cardNumber;
        private string _cardName;
        private CardRarity _cardRarity;
        private CardColor _cardColour;
        private CardCategory _cardCategory;
        private string? _type;
        private string? _attribute;
        private int? _lv;
        private int? _playCost;
        private int? _digimonPower;
        private string? _digievolutionCondition;
        private string? _form;
        private string? _mainEffect;
        private string? _secondaryEffect;

        public Card()
        {

        }
        public Card(string cardNumber, string cardName, CardRarity cardRarity, CardColor cardColour, CardCategory cardCategory, string? type, string? attribute, int? lv, int? playCost, int? digimonPower, string? digievolutionCondition, string? form, string? mainEffect, string? secondaryEffect)
        {
            _cardNumber = cardNumber;
            _cardName = cardName;
            _cardRarity = cardRarity;
            _cardColour = cardColour;
            _cardCategory = cardCategory;
            _type = type;
            _attribute = attribute;
            _lv = lv;
            _playCost = playCost;
            _digimonPower = digimonPower;
            _digievolutionCondition = digievolutionCondition;
            _form = form;
            _mainEffect = mainEffect;
            _secondaryEffect = secondaryEffect;
        }

        public string CardNumber { get { return _cardNumber; }
            set 
            {
                    _cardNumber = value; 
            }
        }
        public string CardName { get { return _cardName; } set { _cardName = value; } }
        public CardRarity CardRarity { get { return _cardRarity; } set { _cardRarity = value; } }
        public CardColor CardColour { get { return _cardColour; } set { _cardColour = value; } }
        public CardCategory CardCategory { get { return _cardCategory; } set { _cardCategory = value; } }
        public string? Type { get { return _type; } set { _type = value; } }
        public string? Attribute { get { return _attribute; } set { _attribute = value; } }
        public int? Lv { get { return _lv; } set { _lv = value; } }
        public int? PlayCost { get { return _playCost; } set { _playCost = value; } }
        public int? DigimonPower { get { return _digimonPower; } set { _digimonPower = value; } }
        public string? DigievolutionCondition { get { return _digievolutionCondition; } set { _digievolutionCondition = value; } }
        public string? Form { get { return _form; } set { _form = value; } }
        public string? MainEffect { get { return _mainEffect; } set { _mainEffect = value; } }
        public string? SecondaryEffect { get { return _secondaryEffect; } set { _secondaryEffect= value; } }

    }
}
