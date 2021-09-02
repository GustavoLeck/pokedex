
using System;
using System.Threading.Tasks;
using Pokedex.Properties; //Deve ser adicionado para puxar as classes e interfaces 
using Refit;

namespace Pokedex
{  class MainClass
    {
        static async Task Main(string[] args) // Como não tem o tempo para conectar, deve estar de forma assincrona (async)
        {
            try    //Tenta a conexão, caso falhe retona erro no catch
            {
                Console.WriteLine("Consultando central global de informações pokemom...");  //Mensagem enquanto aguarda conexão

                for (int Id = 1; Id < 898; Id++)    //For para estibular quais IDs de pokemons serão pegas na API 
                {
                    var PokeClient = RestService.For<PokeAPIService>("https://pokeapi.co"); //declara variavel recebendo host URL da API e passa a interface qual quer mapear 
                    /*Console.WriteLine("Qual o ID do pokemon gostaria de ter informações? ");
                    int PokemonId = Console.Read();
                    Console.WriteLine(PokemonName);*/
                    var Address = await PokeClient.GetAddressAsync(Id); //Declara variavel linkando metodo de task de classo mapeada

                    Console.WriteLine($"ID: {Address.Id}");   //Printa as informões da classe mapeada usando variavel linkada com classe mapeada / chamada ao refit 
                    Console.WriteLine($"Nome: {Address.Name}");
                    Console.WriteLine("------------------------------------------------------------");
                }
            }
            catch(Exception e)  //Retorna erro caso o try falhe
            {
                Console.WriteLine("Erro na consulta do pokemon" + e.Message); //Mensagem de errro
            }  
        }
    }
}
