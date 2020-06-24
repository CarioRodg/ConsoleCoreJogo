using System;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly IJogador _jogador;

        private readonly IJogador _jogador2;

        public JogoFODA(IJogador jogador, IJogador jogador2)
        {
            _jogador = jogador;
            _jogador2 = jogador2;

        }

        public void IniciarJogo()
        {
            Console.Write(_jogador.Corre());
            Console.Write(_jogador.Chuta());
            Console.Write(_jogador.Passe());

            Console.Write("\n Próximo jogador \n");

            Console.Write(_jogador2.Corre());
            Console.Write(_jogador2.Chuta());
            Console.Write(_jogador2.Passe());
        }
    }
}