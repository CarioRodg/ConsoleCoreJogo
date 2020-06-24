using GameTop;

namespace GameTOP.Lib
{
    
    public class Jogador : IJogador
    {
        public readonly string _Nome ;
        public Jogador(string Nome = "Caio")
        {
            _Nome = Nome;
        }

        //Chuta
        public string Chuta()
        {
          return  $"{_Nome} está chutando \n";
        }
        //Corre
        public string Corre()
        {
          return  $"{_Nome} está correndo \n";
        }
        public string Passe ()
        {
          return  $"{_Nome} está passando \n";  
        }
    }
}
