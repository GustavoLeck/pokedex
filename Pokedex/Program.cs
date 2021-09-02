
using System;
using System.Threading.Tasks;
using Pokedex.Properties;
using Refit;

namespace Pokedex
{  class MainClass
    {
        static async Task Main(string[] args) 
        {
            try
            {
                for (int Id = 1; Id < 121; Id++)
                {
                    var PokeClient = RestService.For<PokeAPIService>("https://pokeapi.co");
                    //Console.WriteLine("Qual o ID do pokemon gostaria de ter informações? ");
                    //int PokemonId = Console.Read();
                    //Console.WriteLine(PokemonName);
                    Console.WriteLine("Consultando central global de informações pokemom...");
                    var Address = await PokeClient.GetAddressAsync(Id);

                    Console.WriteLine($"Nome: {Address.Name}, {Address.Id}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro na consulta do pokemon" + e.Message);
            }  
        
        }
    }
}
