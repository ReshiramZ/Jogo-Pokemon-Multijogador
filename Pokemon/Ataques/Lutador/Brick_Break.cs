using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console_Version_2.Pokemon.Ataques.Lutador
{
    internal class Brick_Break : IAtaques
    {
        public string NomeDoAtaque { get; set; } = "Brick Break";
        public int ForcaDoAtaque { get; set; } = 10;
        public Tipo TipoDoAtaque { get; set; } = Tipo.Lutador;
        public int PP { get; set; } = 3;
    }
}
