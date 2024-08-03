using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Eletrico
{
    internal class Thunderbolt : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Thunderbolt";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Eletrico;
        public int PP { get; set; } = 3;

        public void PoderEspecial(IPokemon Alvo)
        {
            Random Dado = new();
            if (Alvo.Status == Status.Condicao_de_Status.Status.Nenhum && Alvo.TipoDoPokemon != Tipo.Eletrico)
            {
                if (Dado.Next(1, 21) == 1)
                {
                    Alvo.Status = Status.Condicao_de_Status.Status.Paralizado;
                    Console.WriteLine($"{Alvo.Nome} foi paralizado!");
                }
            }
        }
    }
}
