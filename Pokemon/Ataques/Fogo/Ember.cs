using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Fogo
{
    internal class Ember : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Ember";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Fogo;
        public int PP { get; set; } = 10;


        public void PoderEspecial(IPokemon Alvo)
        {
            Random Dado = new();
            if (Alvo.Status == Status.Condicao_de_Status.Status.Nenhum && Alvo.TipoDoPokemon != Tipo.Fogo)
            {
                if (Dado.Next(1, 11) == 1)
                {
                    Alvo.Status = Status.Condicao_de_Status.Status.Queimado;
                    Console.WriteLine($"{Alvo.Nome} foi queimado!");
                }
            }
        }
    }
}
