namespace Pokemon_Console_Version_2.Pokemon.Ataques.Psiquico
{
    internal class Confusion : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Confusion";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Psiquico;
        public int PP { get; set; } = 10;

    }
}
