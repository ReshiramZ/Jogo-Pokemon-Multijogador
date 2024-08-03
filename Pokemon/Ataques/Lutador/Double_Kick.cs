using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Lutador
{
    internal class Double_Kick : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Double Kick";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Lutador;
        public int PP { get; set; } = 10;
    }
}
