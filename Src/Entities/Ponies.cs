using static System.Console;

namespace DesafioRPG.Src.Entities
{
    public class Ponies
    {
        public Ponies(string nome, int level, string tipoPonei)
        {
            this.nome = nome;
            this.level = level;
            this.tipoPonei = tipoPonei;
        }

        public string nome;
        public int level;
        public string tipoPonei;

        public override string ToString()
        {
            return this.nome + " " + this.level + " " + this.tipoPonei;
        }

        public virtual string Ataque()
        {
            return this.nome + " Atacou com o vento de suas enorme asas";
        }
    }
}