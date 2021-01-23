using System;
using GameTop.Interface;

namespace GameTop
{
    public     class  JogoFoda {
        private readonly iJogador _jogador;
        private readonly iJogador _jogador2;

        public JogoFoda(iJogador jogador, iJogador jogador2  )
        {
            _jogador = jogador;
            _jogador2 = jogador2;
        }
            public void IniciarJogo()
            {

                Console.WriteLine(_jogador.Chuta());
                Console.WriteLine(_jogador.Corre());
                Console.WriteLine(_jogador.Passe());


                Console.WriteLine(_jogador2.Chuta());
                Console.WriteLine(_jogador2.Corre());
                Console.WriteLine(_jogador2.Passe());
            }
            
    }
}
            
