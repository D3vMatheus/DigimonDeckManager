using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.UseCases
{
    public class DuplicatedCards
    {
        public bool MaxCopyCard(string number, Deck cards)
        {
            int count = 0;
            foreach (Card n in cards.CardDeck)
            {
                if (n != null && n.ToString().StartsWith(number))
                    count++;

            }
            if (count > 5)
                return true;
            return false;

        }
    }
}
