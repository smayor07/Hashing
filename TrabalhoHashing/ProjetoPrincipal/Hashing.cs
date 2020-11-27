using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPrincipal
{
    class Hashing
    {
        private string chave;

        public string Chave { get => chave; set => chave = value; }

        public Hashing(string C)
        {
            C = Chave;
        }

        public int HashingStandard()
        {
            byte aux = 0;
            int SOMA = 0;
            Convert.ToString(Chave);
            int I = 0;
            int D = 0;
   
            foreach (char item in Chave)
            {
                if (I >= 8)
                {
                    D = 0;
                }
                aux = (byte)(Chave[I] << D);
                I++;
                D++;
                SOMA = SOMA + aux;
            }
            return SOMA;
        }

        public int HashingPI()
        {
            byte aux = 0;
            int SOMA = 0;
            Convert.ToString(Chave);
            int I = 0;
            int D = 0;

            foreach (char item in Chave)
            {
                if (I % 2 == 0)
                {
                    D = 2;
                }
                else if (I % 2 != 0)
                {
                    D = 1;
                }
                aux = (byte)(Chave[I] << D);
                I++;
                SOMA = SOMA + aux;
            }

            return SOMA;
        }
    }
}
