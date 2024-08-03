using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Veneno
{
    internal class Poison_Jab : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Poison Jab";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Veneno;
        public int PP { get; set; } = 3;

        public void PoderEspecial(IPokemon Alvo)
        {
            Random Dado = new();
            if (Alvo.Status == Status.Condicao_de_Status.Status.Nenhum && Alvo.TipoDoPokemon != Tipo.Veneno)
            {
                if (Dado.Next(1, 21) == 1)
                {
                    Alvo.Status = Status.Condicao_de_Status.Status.Envenenado;
                    Console.WriteLine($"{Alvo.Nome} foi envenenado!");
                }
            }
        }
    }
}
