using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonAPI.Models
{
    public class Stat
    {
        public StatInfo stat { get; set; }
        public string Effort { get; set; }
        public string Base_Stat { get; set; }
    }
}