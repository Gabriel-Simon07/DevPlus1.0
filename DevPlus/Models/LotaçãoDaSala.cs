using System;
using System.Collections.Generic;
using System.Text;

namespace DevPlus.Models
{
    class LotaçãoDaSala
    {        
        private double lotacaoDaSala;
        public double LotacaoDaSala
        {
            get { return lotacaoDaSala; }
            set
            {
                if (value != 0)
                {
                    lotacaoDaSala = value;
                    Console.WriteLine($"Restam ainda {value} vagas nesta sala.");
                }
                else if (value <= 0)
                {
                    throw new Exception("A lotação da sala deve ter ao menos uma pessoa.");
                }
            }
        }
        public override string ToString()
        {
            return ($"{lotacaoDaSala}");
        }
    }
}
