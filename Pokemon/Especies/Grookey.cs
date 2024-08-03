using Pokemon_Console_Version_2.Pokemon.Ataques;
using Pokemon_Console_Version_2.Pokemon.Ataques.Grama;
using Pokemon_Console_Version_2.Pokemon.Ataques.Lutador;
using Pokemon_Console_Version_2.Pokemon.Ataques.Normal;
using Pokemon_Console_Version_2.Pokemon.Status;
using Pokemon_Console_Version_2.Pokemon.Tipos;

namespace Pokemon_Console_Version_2.Pokemon.Especies
{
    internal class Grookey : IPokemon
    {
        public int PV { get; set; } = 50;
        public string Nome { get; set; } = "Grookey";
        public Condicao_de_Status.Status Status { get; set; } = Condicao_de_Status.Status.Nenhum;
        public bool FoiQueimado { get; set; } = false;
        public bool EstaDesmaiado { get; set; } = false;
        public bool PodeSeMover { get; set; } = true;
        public Tipo TipoDoPokemon { get; set; } = Tipo.Grama;
        public Tabela_de_Fraquezas Fraquezas { get; set; }
        public List<IAtaques> ListaDeAtaques { get; set; }
        public Grookey()
        {
            Fraquezas = new Tabela_de_Fraquezas();
            ListaDeAtaques = new()
            {
                new Tackle(),
                new Vine_Whip(),
                new Leaf_Blade(),
                new Double_Kick(),
            };
        }
    }
}
