using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Multijogador
{
    internal interface IJogadores
    {
        public string NomeDoJogador { get; set; }
        public List<IPokemon> EquipeDoJogador { get; set; }
    }
}
