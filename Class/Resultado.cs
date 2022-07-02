namespace DevinBotBattle.Class
{
    public class Resultado<TEntity>
    {
        public bool Empate { get; set; }
        public TEntity Vencedor { get; set; }
    }
}