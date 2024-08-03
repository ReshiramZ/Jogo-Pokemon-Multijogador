namespace Pokemon_Console_Version_2.Pokemon.Ataques.Pedra
{
    internal class Rock_Slide : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Rock Slide";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Pedra;
        public int PP { get; set; } = 3;
    }
}
