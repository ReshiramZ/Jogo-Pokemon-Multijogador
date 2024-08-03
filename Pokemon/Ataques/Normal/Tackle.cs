using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Normal
{
    internal class Tackle : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Tackle";
        public int ForcaDoAtaque { get; set; } = 5;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Normal;
        public int PP { get; set; } = 10;
    }
}
