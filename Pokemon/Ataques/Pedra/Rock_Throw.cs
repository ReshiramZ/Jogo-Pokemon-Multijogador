namespace Pokemon_Console_Version_2.Pokemon.Ataques.Pedra
{
    internal class Rock_Throw : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Rock Throw";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Pedra;
        public int PP { get; set; } = 10;
    }
}
