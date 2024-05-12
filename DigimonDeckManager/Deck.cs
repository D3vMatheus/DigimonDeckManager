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
        private int _deckId;
        public int DeckId { get { return _deckId; } set { _deckId = value; } }


        public Deck(string DeckName, int DeckId)
        {
            _deckName = DeckName;
            _deckId = DeckId;
        }


    }
}
