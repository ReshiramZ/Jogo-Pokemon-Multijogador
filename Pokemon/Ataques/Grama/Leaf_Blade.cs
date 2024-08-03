namespace Pokemon_Console_Version_2.Pokemon.Ataques.Grama
{
    internal class Leaf_Blade : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Leaf Blade";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Grama;
        public int PP { get; set; } = 3;

    }
}
