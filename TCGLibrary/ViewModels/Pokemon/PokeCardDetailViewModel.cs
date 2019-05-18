using PKCDQuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TCGLibrary.ViewModels.Pokemon
{
    class PokeCardDetailViewModel
    {
        static HttpClient htp = new HttpClient();
        //public static List<Card> _allcardslst = new List<Card>();
        //public static List<Card> AllCards = new List<Card>();
        public static Card Details;

        public static async Task<Card> GetAllCardInSetAsync(string Id)
        {


            string response = await htp.GetStringAsync(string.Format("https://api.pokemontcg.io/v1/cards/{0}", Id));
            var cards = PokeDetailCardModel.FromJson(response);
            Details = cards.Card;
            //AllCards = cards.Cards.ToList<Card>();
            return Details;
        }
    }
}
