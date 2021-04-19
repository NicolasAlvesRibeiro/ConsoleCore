using Game.Interface;

namespace Game.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Maradona está chutando\n";
        }

        public string Correr()
        {
            return "Maradona está corriendo\n";
        }

        public string Passar()
        {
            return "Maradona está passiando\n";
        }
    }
}