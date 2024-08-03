namespace Pokemon_Console_Version_2.Pokemon.Ataques.Normal
{
    internal class Slash : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Slash";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Normal;
        public int PP { get; set; } = 3;
    }
}
