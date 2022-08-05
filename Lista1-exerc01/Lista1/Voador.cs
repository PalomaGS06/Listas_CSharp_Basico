using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    public class Voador : Inimigo
    {
        public int Asas;
        public float AlturaMax;

        public string Subir()
        {
            return "O inimigo está subindo! ";
        }

        public string Descer()
        {
            return "O inimigo está descendo! ";
        }

        public override string Atacar()
        {
            // EXERC 3
            AlturaMax += 15; 
            return "O inimigo aéreo atacou com sucesso, agora ele pode voar mais alto! ";
        }
    }
}
