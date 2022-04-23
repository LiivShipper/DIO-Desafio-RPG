using static System.Console;
namespace DesafioRPG.Src.Entities;

    class Program
    {
        static void Main(string[] args)
        {
            Ponies ponei= new Ponies("RainbowDash", 15, "Pegasus");
            Ponies oponente= new Ponies("Chrysalys", 85, "Changeling");

            Write(ponei.Ataque());
            Write(oponente.Ataque());

        }
    }
