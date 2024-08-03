using Pokemon_Console_Version_2.Pokemon.Ataques.Eletrico;
using Pokemon_Console_Version_2.Pokemon.Ataques.Normal;
using Pokemon_Console_Version_2.Pokemon.Ataques.Psiquico;
using Pokemon_Console_Version_2.Pokemon.Ataques;
using Pokemon_Console_Version_2.Pokemon.Status;
using Pokemon_Console_Version_2.Pokemon.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_Console_Version_2.Pokemon.Ataques.Lutador;
using Pokemon_Console_Version_2.Pokemon.Ataques.Pedra;

namespace Pokemon_Console_Version_2.Pokemon.Especies
{
    internal class Machop : IPokemon
    {
        public int PV { get; set; } = 50;
        public string Nome { get; set; } = "Machop";
        public Condicao_de_Status.Status Status { get; set; } = Condicao_de_Status.Status.Nenhum;
        public bool FoiQueimado { get; set; } = false;
        public bool EstaDesmaiado { get; set; } = false;
        public bool PodeSeMover { get; set; } = true;
        public Tipo TipoDoPokemon { get; set; } = Tipo.Lutador;
        public Tabela_de_Fraquezas Fraquezas { get; set; }
        public List<IAtaques> ListaDeAtaques { get; set; }
        public Machop()
        {
            Fraquezas = new Tabela_de_Fraquezas();
            ListaDeAtaques = new()
            {
                new Tackle(),
                new Double_Kick(),
                new Brick_Break(),
                new Rock_Throw(),
            };
        }
    }
}
