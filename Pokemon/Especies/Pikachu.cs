using Pokemon_Console_Version_2.Pokemon.Ataques;
using Pokemon_Console_Version_2.Pokemon.Ataques.Eletrico;
using Pokemon_Console_Version_2.Pokemon.Ataques.Lutador;
using Pokemon_Console_Version_2.Pokemon.Ataques.Normal;
using Pokemon_Console_Version_2.Pokemon.Status;
using Pokemon_Console_Version_2.Pokemon.Tipos;

namespace Pokemon_Console_Version_2.Pokemon.Especies
{
    internal class Pikachu : IPokemon
    {
        public int PV { get; set; } = 50;
        public string Nome { get; set; } = "Pikachu";
        public Condicao_de_Status.Status Status { get; set; } = Condicao_de_Status.Status.Nenhum;
        public bool FoiQueimado { get; set; } = false;
        public bool EstaDesmaiado { get; set; } = false;
        public bool PodeSeMover { get; set; } = true;
        public Tipo TipoDoPokemon { get; set; } = Tipo.Eletrico;
        public Tabela_de_Fraquezas Fraquezas { get; set; }
        public List<IAtaques> ListaDeAtaques { get; set; }
        public Pikachu()
        {
            Fraquezas = new Tabela_de_Fraquezas();
            ListaDeAtaques = new()
            {
                new Tackle(),
                new Thunder_Shock(),
                new Thunderbolt(),
                new Double_Kick(),
            };
        }
    }
}
