namespace Pokemon_Console_Version_2.Pokemon.Ataques.Psiquico
{
    internal class Psychic : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Psychic";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Psiquico;
        public int PP { get; set; } = 3;

    }
}
