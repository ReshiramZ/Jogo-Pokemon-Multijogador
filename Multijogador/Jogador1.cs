﻿using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Multijogador
{
    internal class Jogador1 : IJogadores
    {
        public string NomeDoJogador { get; set; }
        public List<IPokemon> EquipeDoJogador { get; set; }
        public Jogador1()
        {
            EquipeDoJogador = new List<IPokemon>();
        }
    }
}
