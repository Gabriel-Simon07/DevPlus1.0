using System;
using System.Collections.Generic;
using System.Text;
using DevPlus.Models;
using DevPlus.Views;

namespace DevPlus.Models
{
    class LotaçãoDoCafé
    {
        private double lotacaoLotacaoCafe;
        public double LotacaoCafe
        {
            get { return lotacaoLotacaoCafe; }
            set
            {
                if (value >= 1)
                {
                    lotacaoLotacaoCafe = value;
                }
                else
                {
                    throw new Exception("A lotação da área de café deve ter ao menos uma pessoa.");
                }
            }            
        }
        public override string ToString()
        {
            return ($"{lotacaoLotacaoCafe}");
        }
    }
}
