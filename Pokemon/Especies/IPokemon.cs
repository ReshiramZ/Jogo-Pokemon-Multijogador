using Pokemon_Console_Version_2.Pokemon.Ataques;
using Pokemon_Console_Version_2.Pokemon.Status;
using Pokemon_Console_Version_2.Pokemon.Tipos;

namespace Pokemon_Console_Version_2.Pokemon.Especies
{
    internal interface IPokemon
    {
        public int PV { get; set; }
        public string Nome { get; set; }
        public bool PodeSeMover { get; set; }
        public Tipo TipoDoPokemon { get; set; }
        public bool FoiQueimado { get; set; }
        public bool EstaDesmaiado { get; set; }
        public Condicao_de_Status.Status Status { get; set; }
        public Tabela_de_Fraquezas Fraquezas { get; set; }
        public List<IAtaques> ListaDeAtaques { get; set; }
    }
}
