using Pokemon_Console_Version_2.Pokemon.Ataques;
using Pokemon_Console_Version_2.Pokemon.Ataques.Normal;
using Pokemon_Console_Version_2.Pokemon.Ataques.Psiquico;
using Pokemon_Console_Version_2.Pokemon.Ataques.Veneno;
using Pokemon_Console_Version_2.Pokemon.Status;
using Pokemon_Console_Version_2.Pokemon.Tipos;

namespace Pokemon_Console_Version_2.Pokemon.Especies
{
    internal class Ekans : IPokemon
    {
        public int PV { get; set; } = 50;
        public string Nome { get; set; } = "Ekans";
        public Condicao_de_Status.Status Status { get; set; } = Condicao_de_Status.Status.Nenhum;
        public bool FoiQueimado { get; set; } = false;
        public bool EstaDesmaiado { get; set; } = false;
        public bool PodeSeMover { get; set; } = true;
        public Tipo TipoDoPokemon { get; set; } = Tipo.Veneno;
        public Tabela_de_Fraquezas Fraquezas { get; set; }
        public List<IAtaques> ListaDeAtaques { get; set; }
        public Ekans()
        {
            Fraquezas = new Tabela_de_Fraquezas();
            ListaDeAtaques = new()
            {
                new Tackle(),
                new Poison_Sting(),
                new Poison_Jab(),
                new Hypnoses(),
            };
        }
    }
}
