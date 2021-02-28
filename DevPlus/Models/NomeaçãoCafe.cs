using System;
using System.Collections.Generic;
using System.Text;
using DevPlus.Models;
using DevPlus.Views;

namespace DevPlus.Models
{
    class NomeaçãoLotacaoCafe
    {

        private string nomeLotacaoCafe;
        public string NomeLotacaoCafe
        {
            get { return nomeLotacaoCafe; }
            set
            {
                if (value.Length >= 3 && value.Length<=15)
                {
                    nomeLotacaoCafe = value;
                }
                else
                {
                    throw new Exception("O nome da área de café deve ter ao menos 3 caracteres e o máximo 15 caracteres.");
                }
            }
        }
        public override string ToString()
        {
            return ($"{nomeLotacaoCafe}");
        }
    }
}
