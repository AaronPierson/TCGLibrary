using PKSetQuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TCGLibrary.ViewModels.Pokemon
{
    class SetsViewModel
    {
        static HttpClient htp = new HttpClient();
        public static List<Set> _cardsetslst = new List<Set>();
        public static List<Set> AllSets = new List<Set>();

        public static async Task<List<Set>> GetAllCardSetsAsync()
        {

            string response = await htp.GetStringAsync("https://api.pokemontcg.io/v1/sets");
            var cardSets = PokeSetsModel.FromJson(response);
            _cardsetslst = cardSets.Sets.ToList<Set>();
            AllSets = cardSets.Sets.ToList<Set>();
            return _cardsetslst;
        }
    }
}
