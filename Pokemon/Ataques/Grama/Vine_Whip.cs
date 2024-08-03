namespace Pokemon_Console_Version_2.Pokemon.Ataques.Grama
{
    internal class Vine_Whip : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Vine Whip";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Grama;
        public int PP { get; set; } = 10;

    }
}
