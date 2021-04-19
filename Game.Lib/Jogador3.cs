using Game.Interface;

namespace Game.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chutar()
        {
           return "teste chuta\n";
        }

        public string Correr()
        {
            return "teste corre\n";
        }

        public string Passar()
        {
            return "teste passa\n";
        }
    }
}