﻿using System;

using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda( 
                new Jogador("Thiago"), 
                new Jogador2());

            jogo.IniciarJogo();
        }
    }


}
