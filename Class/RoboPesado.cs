namespace DevinBotBattle.Class
{
    public class RoboPesado : Robo
    {
        public RoboPesado(string nome) : base(nome)
        {
        }

        public override int CausarDano()
        {
            switch (Status)
            {
                case Enum.EStatus.Ligado:
                    Status = Enum.EStatus.Aguardando;

                    Random numeroRandom = new Random();
                    var numero = numeroRandom.Next(1, 20);
                    return numero;
                case Enum.EStatus.Aguardando:
                    Status = Enum.EStatus.Ligado;
                    return 0;
                default:
                    return 0;
            }

        }
    }
}