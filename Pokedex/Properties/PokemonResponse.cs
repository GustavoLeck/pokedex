
/*Essa classe destaca os dados que serão extraidos da API através das propriedades*/


using Newtonsoft.Json; // Biblioteca necessária para mapear a propriedade

namespace Pokedex.Properties
{
    public class PokemonResponse
    {
        [JsonProperty("name")]  //Comando para mapear a propriedade, o nome () deve ser igual ao entregue pela APÌ
        public string Name { get; set; }    //Declaração de propriedade

        [JsonProperty("id")]
        public int Id { get; set; }


    }
}
