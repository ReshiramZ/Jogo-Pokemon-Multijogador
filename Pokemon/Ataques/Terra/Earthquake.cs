using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Terra
{
    internal class Earthquake : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Earthquake";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Terra;
        public int PP { get; set; } = 3;
    }
}
