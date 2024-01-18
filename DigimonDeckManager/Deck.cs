using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager
{
    public class Deck
    {
        private string deckName
        {
            get
            {
                return deckName;
            }
            set
            {
                deckName = value;
            }
        }
        private int deckId { get; set; }

        public Deck(string DeckName, int DeckId)
        {
            deckName = DeckName;
            deckId = DeckId;
        }
    }
}
