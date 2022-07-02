namespace DevinBotBattle.Class
{
    public static class PartidaBatalha
    {
        public static Resultado<Robo> Batalhar(Robo robo1, Robo robo2, int qtdeRodadas = 10)
        {
            var resultado = new Resultado<Robo>();

            Console.WriteLine($"DevinBotBattle! {robo1.Nome} x Robot {robo2.Nome}");

            while (qtdeRodadas > 0 || robo1.Status == Enum.EStatus.Destruido || robo2.Status == Enum.EStatus.Destruido)
            {
                Console.WriteLine($"Robot {robo1.Nome} ({robo1.PontosDeVida} pontos de vida) x Robot {robo2.Nome} ({robo2.PontosDeVida} pontos de vida)");

                SorteiaRobo(robo1, robo2);

                if (robo1.Status == Enum.EStatus.Destruido) resultado.Vencedor = robo2; resultado.Empate = false;
                if (robo2.Status == Enum.EStatus.Destruido) resultado.Vencedor = robo1; resultado.Empate = false;

                qtdeRodadas--;
            }

            if (robo1.PontosDeVida > robo2.PontosDeVida)
            {
                resultado.Vencedor = robo1; resultado.Empate = false;
            }
            else if (robo1.PontosDeVida < robo2.PontosDeVida)
            {
                resultado.Vencedor = robo2; resultado.Empate = false;
            }
            else
            {
                resultado.Empate = true;
            }

            return resultado;
        }

        private static void SorteiaRobo(params Robo[] robos)
        {
            Random numeroRandom = new Random();
            var numero = numeroRandom.Next(2);
            var primeiroRobo = robos[numero];
            var segundoRobo = robos[Math.Abs(numero - 1)];

            primeiroRobo.ReduzirPontosVida(segundoRobo.CausarDano());
        }
    }
}