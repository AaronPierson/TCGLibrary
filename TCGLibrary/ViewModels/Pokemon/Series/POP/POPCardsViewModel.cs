using POPCQuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TCGLibrary.ViewModels.Pokemon.Series.POP
{
    class POPCardsViewModel
    {
        static HttpClient htp = new HttpClient();
        public static List<Card> _allcardslst = new List<Card>();
        public static List<Card> AllCards = new List<Card>();

        public static async Task<List<Card>> GetAllCardInSetAsync(string code)
        {


            string response = await htp.GetStringAsync(string.Format("https://api.pokemontcg.io/v1/cards?setCode={0}", code));
            var cards = PokePopCards.FromJson(response);
            _allcardslst = cards.Cards.ToList<Card>();
            AllCards = cards.Cards.ToList<Card>();
            return _allcardslst;
        }
    }
}
