using PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace PokemonAPI.Services
{
    public class PokemonService
    {
        private const string URL = "https://pokeapi.co/api/v2/pokemon/";

        public PokemonDetail GetByIdOrName(string idOrName)
        {
            var pokemonDetails = default(PokemonDetail);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
           
            HttpResponseMessage response = client.GetAsync(idOrName).Result;
            if (response.IsSuccessStatusCode)
                pokemonDetails = response.Content.ReadAsAsync<PokemonDetail>().Result;
             
            return pokemonDetails;
        }
    }
}
