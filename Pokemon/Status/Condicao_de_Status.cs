using Pokemon_Console_Version_2.Pokemon.Especies;

namespace Pokemon_Console_Version_2.Pokemon.Status
{
    internal class Condicao_de_Status
    {
        public enum Status
        { 
            Nenhum,
            Envenenado,
            Queimado,
            Paralizado,
            Dormindo,
        }

        public static void VerificarStatus(IPokemon Alvo)
        {
            switch (Alvo.Status)
            {
                case
                    Status.Envenenado:
                    Alvo.PV -= 3;
                    Console.WriteLine($"O veneno de {Alvo.Nome} está piorando! {Alvo.PV}");
                    break;
               
                case Status.Queimado:
                    Alvo.PV -= 2;
                    if (Alvo.FoiQueimado == false) 
                    {
                        foreach (var ataque in Alvo.ListaDeAtaques)
                        {
                            ataque.ForcaDoAtaque /= 2;
                            Alvo.FoiQueimado = true;
                        }
                    }
                    Console.WriteLine($"A queimadura de {Alvo.Nome} está o machucando e está mais fraco!");
                    break;

                case Status.Paralizado:
                    Alvo.PodeSeMover = true;
                    Random DadoParalizado = new();
                    if (DadoParalizado.Next(1, 4) == 1) 
                    {
                        Alvo.PodeSeMover = false;
                    }
                    break;

                case Status.Dormindo:
                    Alvo.PodeSeMover = false;
                    Random DadoSonolento = new();
                    if (DadoSonolento.Next(1, 6) == 1)
                    {
                        Alvo.PodeSeMover = true;
                        Alvo.Status = Status.Nenhum;
                        Console.WriteLine($"{Alvo.Nome} acordou!");
                    }
                    break;
            }
        }
    }
}
