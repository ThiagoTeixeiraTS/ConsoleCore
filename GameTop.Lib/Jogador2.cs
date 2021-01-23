using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona está chutando 1";
        }

        public string Corre()
        {
            return "Maradona está Correndo";
        }

        public string Passe()
        {
            return "Maradona está Passando ";
        }
    }
}