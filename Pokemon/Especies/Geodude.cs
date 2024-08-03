using Pokemon_Console_Version_2.Pokemon.Ataques;
using Pokemon_Console_Version_2.Pokemon.Status;
using Pokemon_Console_Version_2.Pokemon.Tipos;
using Pokemon_Console_Version_2.Pokemon.Ataques.Pedra;
using Pokemon_Console_Version_2.Pokemon.Ataques.Terra;
using Pokemon_Console_Version_2.Pokemon.Ataques.Normal;

namespace Pokemon_Console_Version_2.Pokemon.Especies
{
    internal class Geodude : IPokemon
    {
        public int PV { get; set; } = 50;
        public string Nome { get; set; } = "Geodude";
        public Condicao_de_Status.Status Status { get; set; } = Condicao_de_Status.Status.Nenhum;
        public bool FoiQueimado { get; set; } = false;
        public bool EstaDesmaiado { get; set; } = false;
        public bool PodeSeMover { get; set; } = true;
        public Tipo TipoDoPokemon { get; set; } = Tipo.Pedra;
        public Tabela_de_Fraquezas Fraquezas { get; set; }
        public List<IAtaques> ListaDeAtaques { get; set; }
        public Geodude()
        {
            Fraquezas = new Tabela_de_Fraquezas();
            ListaDeAtaques = new()
            {
                new Tackle(),
                new Rock_Throw(),
                new Rock_Slide(),
                new Earthquake(),
            };
        }
    }
}
