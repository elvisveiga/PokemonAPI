using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonAPI.Models
{
    public class PokemonDetail
    {
        public string Name { get; set; }
        public IEnumerable<Stat> Stats { get; set; }
    }
}