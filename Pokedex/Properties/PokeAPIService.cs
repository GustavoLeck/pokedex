using Refit;

namespace Pokedex.Properties
{
    public interface PokeAPIService
    {
        [Get("/api/v2/pokemon/{pokemon}")]
        Task<PokemonResponse> GetAddressAsync(int pokemon);

    }
}
