using GameTop.Inteface;

namespace GameTop.lib
{
    public class Jogador2 : iJogador
    {
        public string Chute()
        {
            return "Nicolas está Chutando\n";
        }

        public string Corre()
        {
            return "Nicolas está Correndo\n";
        }

        public string Passe()
        {
            return "Nicolas está Passando\n";
        }
    }
}