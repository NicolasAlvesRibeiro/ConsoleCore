using Game.Interface;

namespace Game.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Nícolas" )
        {
            _Nome = nome;
        }

        public string Chutar()
        {
            return $"{_Nome} esta chutando\n";
        }
        public string Correr()
        {
            return $"{_Nome} esta correndo\n";
        }
        public string Passar()
        {
            return $"{_Nome} esta passando\n";
        }
    }
}