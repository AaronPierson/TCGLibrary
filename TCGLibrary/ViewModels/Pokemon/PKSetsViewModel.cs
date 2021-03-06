﻿using PKSetQuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TCGLibrary.ViewModels.Pokemon
{
    class PKSetsViewModel
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

        public static  List<Set> FilterExpandedLegal(bool Legal)
        {

            List<Set> Filter = new List<Set>();
            foreach (var I in AllSets)
            {
                if (Legal == I.ExpandedLegal)
                {
                    Filter.Add(I);
                }
            }
            _cardsetslst = Filter;
            return _cardsetslst;
        }

        public static List<Set> FilterStandardLegal(bool Legal)
        {

            List<Set> Filter = new List<Set>();
            foreach (var I in AllSets)
            {
                if (Legal == I.StandardLegal)
                {
                    Filter.Add(I);
                }
            }
            _cardsetslst = Filter;
            return _cardsetslst;
        }

    }
}
