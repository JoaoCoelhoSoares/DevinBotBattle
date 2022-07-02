
using DevinBotBattle.Class;

internal class Program
{
    private static void Main(string[] args)
    {
        Robo robo1 = new RoboLeve("RoboLeve");
        Robo robo2 = new RoboPesado("RoboPesado");
        robo1.Iniciar();
        robo2.Iniciar();

        var resultado = PartidaBatalha.Batalhar(robo1, robo2);

        if (resultado.Empate)
        {
            Console.WriteLine($"Partida entre {robo1.Nome} e {robo2.Nome} terminou empatada.");
        }
        else
        {
            Console.WriteLine($"Partida vencida por {resultado.Vencedor.Nome}.");

        }

    }
}