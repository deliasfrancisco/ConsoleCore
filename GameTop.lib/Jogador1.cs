using GameTop.Inteface;

namespace GameTop.lib
{
   
    public class Jogador1: iJogador
    {
        public readonly string _Nome; // instacia string do nome

        public Jogador1(string nome = "")
        {
            _Nome = nome; // contrutor onde a variavel declarada vai receber o valor que será passado pelo contrutor na instancia da classe
        }

        public string Chute()
        {
            return $"{_Nome} está Chutando \n"; // imprimindo o valor da variavel com interpolação
        }
        public string Passe()
        {
            return $"{_Nome} está Passando \n";
        }

        public string Corre()
        {
            return $"{_Nome} está Correndo \n";
        }
    }
}