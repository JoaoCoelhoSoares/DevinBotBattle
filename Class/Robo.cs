namespace DevinBotBattle.Class
{
    public abstract class Robo
    {

        public Robo(string nome)
        {
            Nome = nome;
            Status = Enum.EStatus.Desligado;
            PontosDeVida = 100;
        }
        public string Nome { get; private set; }
        public int PontosDeVida { get; protected set; }
        public Enum.EStatus Status { get; protected set; }

        public void Iniciar()
        {
            Status = Enum.EStatus.Ligado;
        }

        public void Parar()
        {
            Status = Enum.EStatus.Desligado;
        }

        public abstract int CausarDano();

        public void ReduzirPontosVida(int dano)
        {
            PontosDeVida = PontosDeVida - dano;
            if (PontosDeVida <= 0)
            {
                PontosDeVida = 0;
                Status = Enum.EStatus.Destruido;
            }
        }
    }
}