using PKCDQuickType;
using PKSDQuickType;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TCGLibrary.ViewModels.Pokemon
{
    class PKCardDetailViewModel
    {
        static HttpClient htp = new HttpClient();
        public static Set setDetails;

        public static Card Details;

        public static async Task<Card> GetAllCardInSetAsync(string Id)
        {
            string response = await htp.GetStringAsync(string.Format("https://api.pokemontcg.io/v1/cards/{0}", Id));
            var cards = PokeDetailCardModel.FromJson(response);
            Details = cards.Card;
            //AllCards = cards.Cards.ToList<Card>();
            return Details;
        }

        public static async Task<Set> GetCardSetAsync(string setcode)
        {
            string response = await htp.GetStringAsync(string.Format("https://api.pokemontcg.io/v1/sets/{0}", setcode) );
            var cardSets = PokeSetDetailModel.FromJson(response);
            setDetails = cardSets.Set;        
            return setDetails;
        }
    }
}
