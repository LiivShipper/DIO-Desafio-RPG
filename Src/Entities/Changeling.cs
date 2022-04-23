namespace DesafioRPG.Src.Entities
{
    public class Changeling : Ponies
    {
        public Changeling(string nome, int level, string tipoPonei)
        {
            this.nome = nome;
            this.level = level;
            this.tipoPonei = tipoPonei;
        }
        
        public override string Ataque()
        {
            return this.nome + " Usou de sua magia";
        }

        public string Ataque(int Bonus)
        {
            return this.nome + " Usou de sua magia com bonus de ataque" + Bonus;
        }
    }
}