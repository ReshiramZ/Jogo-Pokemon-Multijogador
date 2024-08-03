namespace Pokemon_Console_Version_2.Pokemon.Tipos
{
    internal class Tabela_de_Fraquezas
    {
        public Dictionary<Tipo, Dictionary<Tipo, Efetividade>> Fraquezas = new()
        {
                {Tipo.Grama, new Dictionary<Tipo, Efetividade>      // Fraquezas do tipo grama
                {
                    {Tipo.Grama, Efetividade.Resistente },
                    {Tipo.Fogo, Efetividade.Fraco },
                    {Tipo.Agua, Efetividade.Resistente },
                    {Tipo.Psiquico, Efetividade.Neutro },
                    {Tipo.Eletrico, Efetividade.Resistente },
                    {Tipo.Veneno, Efetividade.Fraco },
                    {Tipo.Terra, Efetividade.Resistente },
                    {Tipo.Pedra, Efetividade.Neutro },
                    {Tipo.Normal, Efetividade.Neutro},
                    {Tipo.Lutador, Efetividade.Neutro }
                }
                },

                {Tipo.Fogo, new Dictionary<Tipo, Efetividade>       // Fraquezas do tipo fogo
                {
                    {Tipo.Grama, Efetividade.Resistente },
                    {Tipo.Fogo, Efetividade.Resistente },
                    {Tipo.Agua, Efetividade.Fraco },
                    {Tipo.Psiquico, Efetividade.Neutro },
                    {Tipo.Eletrico, Efetividade.Neutro },
                    {Tipo.Veneno, Efetividade.Neutro },
                    {Tipo.Terra, Efetividade.Fraco },
                    {Tipo.Pedra, Efetividade.Fraco },
                    {Tipo.Normal, Efetividade.Neutro},
                    {Tipo.Lutador, Efetividade.Neutro }
                }
                },

                {Tipo.Agua, new Dictionary<Tipo, Efetividade>       //fraquezas do tipo água
                {
                    {Tipo.Grama, Efetividade.Fraco },
                    {Tipo.Fogo, Efetividade.Resistente },
                    {Tipo.Agua, Efetividade.Resistente },
                    {Tipo.Psiquico, Efetividade.Neutro },
                    {Tipo.Eletrico, Efetividade.Fraco },
                    {Tipo.Veneno, Efetividade.Neutro },
                    {Tipo.Terra, Efetividade.Neutro },
                    {Tipo.Pedra, Efetividade.Neutro },
                    {Tipo.Lutador, Efetividade.Neutro },
                    {Tipo.Normal, Efetividade.Neutro},
                }
                },

                {Tipo.Psiquico, new Dictionary<Tipo, Efetividade>   //fraquezas do tipo psíquico
                {
                    {Tipo.Grama, Efetividade.Neutro },
                    {Tipo.Fogo, Efetividade.Neutro },
                    {Tipo.Agua, Efetividade.Neutro },
                    {Tipo.Psiquico, Efetividade.Resistente },
                    {Tipo.Eletrico, Efetividade.Neutro },
                    {Tipo.Veneno, Efetividade.Neutro },
                    {Tipo.Pedra, Efetividade.Neutro },
                    {Tipo.Terra, Efetividade.Neutro },
                    {Tipo.Normal, Efetividade.Neutro},
                    {Tipo.Lutador, Efetividade.Resistente },
                }
                },

                {Tipo.Eletrico, new Dictionary<Tipo, Efetividade>   //fraquezas do tipo elétrico
                {
                    {Tipo.Grama, Efetividade.Neutro },
                    {Tipo.Fogo, Efetividade.Neutro },
                    {Tipo.Agua, Efetividade.Neutro },
                    {Tipo.Psiquico, Efetividade.Neutro },
                    {Tipo.Eletrico, Efetividade.Neutro },
                    {Tipo.Veneno, Efetividade.Neutro },
                    {Tipo.Pedra, Efetividade.Neutro },
                    {Tipo.Normal, Efetividade.Neutro},
                    {Tipo.Terra, Efetividade.Fraco },
                    {Tipo.Lutador, Efetividade.Neutro },
                }
                },

                {Tipo.Veneno, new Dictionary<Tipo, Efetividade> //fraquezas do tipo veneno
                {
                    {Tipo.Grama, Efetividade.Resistente },
                    {Tipo.Fogo, Efetividade.Neutro },
                    {Tipo.Agua, Efetividade.Neutro },
                    {Tipo.Psiquico, Efetividade.Fraco },
                    {Tipo.Eletrico, Efetividade.Neutro },
                    {Tipo.Veneno, Efetividade.Resistente },
                    {Tipo.Pedra, Efetividade.Neutro },
                    {Tipo.Normal, Efetividade.Neutro},
                    {Tipo.Terra, Efetividade.Fraco },
                    {Tipo.Lutador, Efetividade.Resistente },
                }
                },

                {Tipo.Terra, new Dictionary<Tipo, Efetividade>
                {
                    {Tipo.Grama, Efetividade.Fraco },
                    {Tipo.Fogo, Efetividade.Neutro },
                    {Tipo.Agua, Efetividade.Fraco },
                    {Tipo.Psiquico, Efetividade.Neutro },
                    {Tipo.Eletrico, Efetividade.Imune },
                    {Tipo.Veneno, Efetividade.Resistente },
                    {Tipo.Pedra, Efetividade.Resistente },
                    {Tipo.Normal, Efetividade.Neutro},
                    {Tipo.Terra, Efetividade.Neutro },
                    {Tipo.Lutador, Efetividade.Neutro }
                }
                },

                {Tipo.Pedra, new Dictionary<Tipo, Efetividade>
                {
                    {Tipo.Grama, Efetividade.Fraco },
                    {Tipo.Fogo, Efetividade.Resistente },
                    {Tipo.Agua, Efetividade.Fraco },
                    {Tipo.Psiquico, Efetividade.Neutro },
                    {Tipo.Eletrico, Efetividade.Neutro },
                    {Tipo.Veneno, Efetividade.Resistente },
                    {Tipo.Terra, Efetividade.Fraco },
                    {Tipo.Normal, Efetividade.Resistente},
                    {Tipo.Lutador, Efetividade.Fraco },
                    {Tipo.Pedra, Efetividade.Neutro },
                }
                },

                {Tipo.Normal, new Dictionary<Tipo, Efetividade>
                {
                    {Tipo.Grama, Efetividade.Neutro },
                    {Tipo.Fogo, Efetividade.Neutro },
                    {Tipo.Agua, Efetividade.Neutro },
                    {Tipo.Psiquico, Efetividade.Neutro },
                    {Tipo.Eletrico, Efetividade.Neutro },
                    {Tipo.Veneno, Efetividade.Neutro },
                    {Tipo.Pedra, Efetividade.Neutro },
                    {Tipo.Normal, Efetividade.Neutro},
                    {Tipo.Terra, Efetividade.Neutro },
                    {Tipo.Lutador, Efetividade.Fraco }
                }
                },
            
                {Tipo.Lutador, new Dictionary<Tipo, Efetividade>
                {
                    {Tipo.Grama, Efetividade.Neutro },
                    {Tipo.Fogo, Efetividade.Neutro },
                    {Tipo.Agua, Efetividade.Neutro },
                    {Tipo.Psiquico, Efetividade.Fraco },
                    {Tipo.Eletrico, Efetividade.Neutro },
                    {Tipo.Veneno, Efetividade.Neutro },
                    {Tipo.Pedra, Efetividade.Resistente },
                    {Tipo.Normal, Efetividade.Neutro},
                    {Tipo.Terra, Efetividade.Neutro },
                    {Tipo.Lutador, Efetividade.Neutro },
                }
                },
        };
    }
}
