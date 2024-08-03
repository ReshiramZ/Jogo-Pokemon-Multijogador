using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Fogo
{
    internal class Flamethrower : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Flamethrower";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Fogo;
        public int PP { get; set; } = 3;

        public void PoderEspecial(IPokemon Alvo)
        {
            Random Dado = new();
            if (Alvo.Status == Status.Condicao_de_Status.Status.Nenhum && Alvo.TipoDoPokemon != Tipo.Fogo)
            {
                if (Dado.Next(1, 21) == 1)
                {
                    Alvo.Status = Status.Condicao_de_Status.Status.Queimado;
                    Console.WriteLine($"{Alvo.Nome} foi queimado!");
                }
            }
        }
    }
}
