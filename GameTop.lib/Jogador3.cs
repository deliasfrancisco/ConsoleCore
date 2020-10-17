using GameTop.Inteface;

namespace GameTop.lib
{
    public class Jogador3 : iJogador
    {
        public string Chute()
        {
            return "Teste chuta\n";
        }

        public string Corre()
        {
            return "Teste corre\n";
        }

        public string Passe()
        {
            return "Teste passe\n";
        }
    }
}