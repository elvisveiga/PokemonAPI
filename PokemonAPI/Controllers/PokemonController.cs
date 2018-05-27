using PokemonAPI.Services;
using System.Web.Http;

namespace PokemonAPI.Controllers
{
    public class PokemonController : ApiController
    {
        PokemonService pokemonService;
        PokemonController()
        {
            pokemonService = new PokemonService();
        }

        public IHttpActionResult Get()
        {
            return Ok();
        }

        public IHttpActionResult Get(string id)
        {
            return Ok(pokemonService.GetByIdOrName(id));
        }
    }
}
