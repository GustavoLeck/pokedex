/*Interface reponsável em linkar com a API e com a classe mapeada*/

using Refit;    //Biblioteca para usar os comandos para linkar com a API

namespace Pokedex.Properties
{
    public interface PokeAPIService
    {
        [Get("/api/v2/pokemon/{pokemon}")]  // Comando para o Refit identificar a rota / passa a parte entre {} dinamicamente
        Task<PokemonResponse> GetAddressAsync(int pokemon); // Metodo Reponsavel em linkar com a classe de mapeamento e pegar por parametro a variavel para fazer a busca pela rota

    }
}
