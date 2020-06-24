using GameTop;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Larissa está chutando ";
        }

        public string Corre()
        {
            return "Larissa está correndo ";
        }

        public string Passe()
        {
            return "Larissa está passando ";
        }
    }
}