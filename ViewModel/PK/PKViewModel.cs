using PokemonTcgSdk;
using PokemonTcgSdk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCGLibrary.ViewModel.PK
{
    public class PKViewModel
    {
        // Get a default list of Pokemon cards
        public List<PokemonCard> AllCards(Dictionary<string, string> query)
        {
            if(query == null)
            {
                var cards = Card.Get<Pokemon>();
                return cards.Cards;
            }
            else
            {
                var card = Card.Get(query);
                return card.Cards;
            }

        }

        // Get all sets
       public List<SetData> AllSets(Dictionary<string, string> query)
       {
            if(query == null)
            {
                var sets = Sets.All();
                return sets;
            }
            else
            {
                var sets = Sets.Find(query);
                return sets;
            }

        }

    }
}
