using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Psiquico
{
    internal class Hypnoses : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Hypnoses";
        public int ForcaDoAtaque { get; set; } = 0;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Psiquico;
        public int PP { get; set; } = 3;

        public void PoderEspecial(IPokemon Alvo)
        {
            Random Dado = new();
            if (Alvo.Status == Status.Condicao_de_Status.Status.Nenhum)
            {
                if (Dado.Next(1, 11) == 1)
                {
                    Alvo.Status = Status.Condicao_de_Status.Status.Dormindo;
                    Console.WriteLine($"{Alvo.Nome} está com sono!");
                }
                else
                {
                    Console.WriteLine($"{Alvo.Nome} desviou do ataque!");
                }
            }
            else
            {
                Console.WriteLine($"O ataque falhou!");
            }
        }
    }
}
