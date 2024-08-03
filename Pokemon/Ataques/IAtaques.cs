using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Pokemon.Ataques
{
    internal interface IAtaques
    {
        public string NomeDoAtaque { get; set; }
        public int ForcaDoAtaque { get; set; }
        public Tipo TipoDoAtaque { get; set; }
        public int PP { get; set; }

        public void PoderEspecial(IPokemon Alvo) { }
    }
}
