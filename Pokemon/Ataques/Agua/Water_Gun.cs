namespace Pokemon_Console_Version_2.Pokemon.Ataques.Agua
{
    internal class Water_Gun : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Water Gun";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Agua;
        public int PP { get; set; } = 10;

    }
}
