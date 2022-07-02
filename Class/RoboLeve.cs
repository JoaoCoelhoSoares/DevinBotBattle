namespace DevinBotBattle.Class
{
    public class RoboLeve : Robo
    {

        public RoboLeve(string nome) : base(nome)
        {
        }
        public override int CausarDano()
        {
            if (Status == Enum.EStatus.Ligado)
            {
                Random numeroRandom = new Random();
                var numero = numeroRandom.Next(1, 10);
                return numero;
            }
            else
            {
                return 0;
            }

        }
    }
}