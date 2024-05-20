using DigimonDeckManager.UseCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager
{
    public class Deck
    {
        private string _deckName;
        public string DeckName { get { return _deckName; } set { _deckName = value; } }
        
        private List<Card> _cards;
        public List<Card> Cards { get { return _cards; } set { _cards = value; } }


        public Deck(string DeckName, List<Card> Cards)
        {
            _deckName = DeckName;
            _cards = Cards;
        }


    }
}
