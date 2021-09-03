
using System;
using System.Threading.Tasks;
using Pokedex.Properties; //Deve ser adicionado para puxar as classes e interfaces 
using Refit;


namespace Pokedex
{
    class MainClass
    {
        static async Task Main(string[] args) // Como não tem o tempo para conectar, deve estar de forma assincrona (async)
        {

            Console.WriteLine("Digite o numero de qual operação deseja fazer:");
            Console.WriteLine("1 - Selecionar Pokemons de uma geração");

            int esc = int.Parse(Console.ReadLine());

            switch (esc)
            {

                case 1:

                    Console.WriteLine("Qual geração de Pokemons gostaria de seleciona?");
                    int gen = int.Parse(Console.ReadLine());

                    switch (gen)
                    {
                        case 1:

                            int Aux = 151;

                            try    //Tenta a conexão, caso falhe retona erro no catch
                            {
                                Console.WriteLine("Consultando central global de informações pokemom...");  //Mensagem enquanto aguarda conexão

                                for (int Id = 1; Id < Aux; Id++) //For para puxar os pokemons do range selecionado
                                {
                                    var PokeClient = RestService.For<PokeAPIService>("https://pokeapi.co"); //declara variavel recebendo host URL da API e passa a interface qual quer mapear 
                                    var Address = await PokeClient.GetAddressAsync(Id); //Declara variavel linkando metodo de task de classo mapeada

                                    Console.WriteLine($"ID: {Address.Id}");   //Printa as informões da classe mapeada usando variavel linkada com classe mapeada / chamada ao refit 
                                    Console.WriteLine($"Nome: {Address.Name}");
                                    Console.WriteLine("------------------------------------------------------------");
                                    Thread.Sleep(500); // Comando para dar delay de 0.5 segundos apra printar
                                }
                            }
                            catch (Exception e)  //Retorna erro caso o try falhe
                            {
                                Console.WriteLine("Erro na consulta do pokemon" + e.Message); //Mensagem de errro
                            }
                            break;

                        default:
                            break;
                    }

                    break;

                   
                default:
                    break;

            }
        }
    }
}
