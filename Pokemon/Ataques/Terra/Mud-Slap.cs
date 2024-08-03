namespace Pokemon_Console_Version_2.Pokemon.Ataques.Terra
{
    internal class Mud_Slap : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Mud-Slap";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Terra;
        public int PP { get; set; } = 10;
    }
}
