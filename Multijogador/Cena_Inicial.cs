using Pokemon_Console_Version_2.Pokemon;
using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Multijogador
{
    internal static class Cena_Inicial
    {
        private static void Cena_Pokemon_Inicial(IJogadores jogador)
        {
            List<IPokemon> ListaDePokemon = new()
            {
                new Grookey(),
                new Chimchar(),
                new Froakie(),
                new Drowzee(),
                new Pikachu(),
                new Ekans(),
                new Drilbur(),
                new Geodude(),
                new Jigglypuff(),
                new Machop(),
            };

            EscolherNome(jogador);

            while (true)
            {
                int Contador = 0;
                Console.WriteLine($"{jogador.NomeDoJogador}, Escolha um pokémon inicial: \n");

                foreach (var pokemon in ListaDePokemon)
                {
                    Console.WriteLine($"{Contador}. {pokemon.Nome} ({pokemon.TipoDoPokemon})");
                    Contador++;
                }

                bool ConversaoDeuCerto = int.TryParse(Console.ReadLine(), out int EscolherPokemon);
                if (ConversaoDeuCerto == true)
                {
                    if (EscolherPokemon >= 0 && EscolherPokemon < ListaDePokemon.Count)
                    {
                        jogador.EquipeDoJogador.Add(ListaDePokemon[EscolherPokemon]);
                        Console.WriteLine($"{jogador.NomeDoJogador} selecionou {jogador.EquipeDoJogador[0].Nome}\n" +
                                          $"Pressione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O numero fornecido não está na lista...\n" +
                                          "Pressione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Escolha inválida, tente novamente.\n" +
                                      "Pressione ENTER para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        private static void EscolherNome(IJogadores jogador)
        {
            string NomeSelecionado;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Jogador, digite o seu nome...");
                NomeSelecionado = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(NomeSelecionado))
                {
                    jogador.NomeDoJogador = NomeSelecionado;
                    break;
                }
                else
                {
                    Console.WriteLine("Nome inválido, digite novamente.");
                    Console.ReadKey();
                }
            }
        }
        public static void TelaPrincipal()
        {
            IJogadores jogador1 = new Jogador1();
            IJogadores jogador2 = new Jogador2();
            Batalha_Multijogador batalha = new();

            Console.WriteLine("*** Escolha de nome do Jogador 1 ***\n" +
                              "Pressione ENTER para continuar...");
            Console.ReadKey();
            Cena_Pokemon_Inicial(jogador1);

            Console.WriteLine("*** Escolha de nome do Jogador 2 ***\n" +
                              "Pressione ENTER para continuar...");
            Console.ReadKey();
            Cena_Pokemon_Inicial(jogador2);

            Console.WriteLine($"*** {jogador1.NomeDoJogador} VS {jogador2.NomeDoJogador} ***\n" +
                              $"Pressione ENTER para continuar...");
            Console.ReadKey();

            batalha.Batalhar(jogador1.EquipeDoJogador[0], jogador2.EquipeDoJogador[0], jogador1, jogador2);
        }
    }
}
