using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___POO
{
    public class Patrulheiro : Inimigo
    {
        public bool Perseguindo;
        public float Velocidade;

        //public string Patrulhar()
        //{
        //    return "Inimigo em modo de patrulha!";
        //}


                //EXERC 4 
        public Patrulheiro(float _velocidade)
        {
            Velocidade = _velocidade;
        }
    }
}
