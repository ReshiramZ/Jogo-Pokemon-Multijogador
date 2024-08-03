namespace Pokemon_Console_Version_2.Pokemon.Ataques.Agua
{
    internal class Surf : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Surf";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Agua;
        public int PP { get; set; } = 3;

    }
}
