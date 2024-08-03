using Pokemon_Console_Version_2.Multijogador;
using Pokemon_Console_Version_2.Pokemon.Ataques;
using Pokemon_Console_Version_2.Pokemon.Especies;
using Pokemon_Console_Version_2.Pokemon.Status;

namespace Pokemon_Console_Version_2
{
    internal class Batalha_Multijogador
    {
        public void Batalhar(IPokemon pokemonJ1, IPokemon pokemonJ2, IJogadores jogador1, IJogadores jogador2)
        {
            while (pokemonJ1.EstaDesmaiado == false && pokemonJ2.EstaDesmaiado == false)
            {
                if (pokemonJ1.PodeSeMover == true)
                {
                    Turno(pokemonJ1, pokemonJ2, jogador1);
                }
                else
                {
                    Console.WriteLine($"{pokemonJ1.Nome} não está se movendo, pois está {pokemonJ1.Status}");
                    Console.ReadKey();
                }

                if (pokemonJ1.EstaDesmaiado == false && pokemonJ2.EstaDesmaiado == false)
                {
                    if (pokemonJ2.PodeSeMover == true)
                    {
                        Turno(pokemonJ2, pokemonJ1, jogador2);
                    }
                    else
                    {
                        Console.WriteLine($"{pokemonJ2.Nome} não está se movendo, pois está {pokemonJ2.Status}");
                        Console.ReadKey();
                    }
                }
                else
                {
                    break;
                }
            }
            if (pokemonJ2.EstaDesmaiado == true)
            {
                Console.Clear();
                Console.WriteLine($"*** {jogador1.NomeDoJogador} venceu usando seu {pokemonJ1.Nome}! ***\n" +
                                  $"Pressione ENTER para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($" *** {jogador2.NomeDoJogador} venceu usando seu {pokemonJ2.Nome}! ***\n" +
                                  $"Pressione ENTER para continuar...");
                Console.ReadKey();
            }
        }
        private void Turno(IPokemon atacante, IPokemon defensor, IJogadores jogadorAtacante)
        {
            while (true)
            {
                int AtaqueID = 0;
                Console.Clear();
                Console.WriteLine($"*** É a vez de {jogadorAtacante.NomeDoJogador}! ***");
                Console.WriteLine($"O que {atacante.Nome} de {jogadorAtacante.NomeDoJogador} vai fazer?");
                foreach (var ataque in atacante.ListaDeAtaques)
                {
                    Console.WriteLine($"{AtaqueID}. {ataque.NomeDoAtaque} ({ataque.TipoDoAtaque}) (PP: {ataque.PP})");
                    AtaqueID++;
                }

                bool ConversaoDeuCerto = int.TryParse(Console.ReadLine(), out int EscolherAtaque);

                if (ConversaoDeuCerto == true)
                {
                    if (EscolherAtaque >= 0 && EscolherAtaque < atacante.ListaDeAtaques.Count)
                    {
                        if (atacante.ListaDeAtaques[EscolherAtaque].PP > 0) 
                        {
                            if (atacante.ListaDeAtaques[EscolherAtaque].ForcaDoAtaque > 0)
                            {
                                ReceberDano(defensor, atacante.ListaDeAtaques[EscolherAtaque]);
                            }
                            atacante.ListaDeAtaques[EscolherAtaque].PoderEspecial(defensor);
                            atacante.ListaDeAtaques[EscolherAtaque].PP--;
                        }
                        else
                        {
                            Console.WriteLine("O ataque não tem PP o suficiente, escolhe outro ataque.");
                        }
                        Condicao_de_Status.VerificarStatus(atacante);
                        Condicao_de_Status.VerificarStatus(defensor);

                        Console.WriteLine($"Pressione ENTER para continuar...");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O ataque fornecido não é valido.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("O ataque fornecido não é valido.");
                    Console.ReadKey();
                }
            }
        }
        private void ReceberDano(IPokemon Alvo, IAtaques AtaqueRecebido)
        {
            if (Alvo.Fraquezas.Fraquezas.ContainsKey(AtaqueRecebido.TipoDoAtaque) &&
                Alvo.Fraquezas.Fraquezas[Alvo.TipoDoPokemon][AtaqueRecebido.TipoDoAtaque] == Efetividade.Fraco)
            {
                Random Dado = new();
                int Dano = Dado.Next(1, 6) + AtaqueRecebido.ForcaDoAtaque * 2;
                Alvo.PV -= Dano;
                if (Alvo.PV < 0)
                {
                    Alvo.PV = 0;
                    Alvo.EstaDesmaiado = true;
                }
                Console.WriteLine($"Foi super efetivo! (Contra {Alvo.Nome} {Alvo.TipoDoPokemon}) - PV do alvo: {Alvo.PV}");
            }
            else if (Alvo.Fraquezas.Fraquezas.ContainsKey(AtaqueRecebido.TipoDoAtaque) &&
                    Alvo.Fraquezas.Fraquezas[Alvo.TipoDoPokemon][AtaqueRecebido.TipoDoAtaque] == Efetividade.Resistente)
            {
                Random Dado = new();
                int Dano = Dado.Next(1, 6) + AtaqueRecebido.ForcaDoAtaque / 2;
                Alvo.PV -= Dano;
                if (Alvo.PV < 0)
                {
                    Alvo.PV = 0;
                    Alvo.EstaDesmaiado = true;
                }
                Console.WriteLine($"Nao foi muito efetivo... (Contra {Alvo.Nome} {Alvo.TipoDoPokemon}) - PV do alvo: {Alvo.PV}");
            }
            else if (Alvo.Fraquezas.Fraquezas.ContainsKey(AtaqueRecebido.TipoDoAtaque) &&
                    Alvo.Fraquezas.Fraquezas[Alvo.TipoDoPokemon][AtaqueRecebido.TipoDoAtaque] == Efetividade.Imune)
            {
                Console.WriteLine($"Isso não afetou {Alvo.Nome}...");
            }
            else
            {
                Random Dado = new();
                int Dano = Dado.Next(1, 6) + AtaqueRecebido.ForcaDoAtaque;
                Alvo.PV -= Dano;
                if (Alvo.PV < 0)
                {
                    Alvo.PV = 0;
                    Alvo.EstaDesmaiado = true;
                }
                Console.WriteLine($"Foi um ataque neutro. (Contra {Alvo.Nome} {Alvo.TipoDoPokemon}) - PV do alvo: {Alvo.PV}");
            }
        }
    }
}
