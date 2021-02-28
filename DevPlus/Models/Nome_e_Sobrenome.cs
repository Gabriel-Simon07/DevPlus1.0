using System;
using System.Collections.Generic;
using System.Text;

namespace DevPlus.Models
{
    class Nome_e_Sobrenome
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length >= 3)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ter ao menos 3 caracteres.");
                }
            }
        }
        private string sobrenome;
        public string Sobrenome
        {
            get { return sobrenome; }
            set
            {
                if (value.Length >= 3)
                {
                    sobrenome = value;
                }
                else
                {
                    throw new Exception("O sobrenome deve ter ao menos 3 caracteres.");
                }
            }
        }
        private string nomeSala;
        public string NomeSala
        {
            get { return nomeSala; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    nomeSala = value;
                }
                else
                {
                    throw new Exception("O nome da sala deve ter ao menos 3 caracteres e o máximo 15 caracteres.");
                }

            }
        }
        public override string ToString()
        {
            return $"{nomeSala}";
        }
    }
}
