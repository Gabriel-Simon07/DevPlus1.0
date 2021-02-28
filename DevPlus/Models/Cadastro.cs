using System;
using System.Collections.Generic;
using System.Text;
using DevPlus.Models;
using DevPlus.Views;

namespace DevPlus.Models
{
    class Cadastro
    {
        #region Construtores

        static List<Cadastro> listaDeNomes = new List<Cadastro>();
        static int MaxId = 0;
        protected int _Id;
        protected string _nome;
        protected string _sobrenome;
        protected string _nomeSala;
        protected string _nomeLotacaoCafe;
        protected double _lotacaoLotacaoCafe;
        protected double _lotacaoDaSala;

        public Cadastro()
        {
            _Id = 0;
            _nome = "";
            _sobrenome = "";
            _nomeSala = "";
            _nomeLotacaoCafe = "";
            _lotacaoLotacaoCafe = 0;
            _lotacaoDaSala = 0;
        }
        public Cadastro(string nome, string sobrenome, string nomeSala, string nomeLotacaoCafe, int lotacaoLotacaoCafe, double lotacaoDaSala)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _nomeSala = nomeSala;
            _nomeLotacaoCafe = nomeLotacaoCafe;
            _lotacaoLotacaoCafe = lotacaoLotacaoCafe;
            _lotacaoDaSala = lotacaoDaSala;
        }
        public Cadastro(int id, string nome, string sobrenome, string nomeSala, string nomeLotacaoCafe, int lotacaoLotacaoCafe, double lotacaoDaSala)
        {
            _Id = id;
            _nome = nome;
            _sobrenome = sobrenome;
            _nomeSala = nomeSala;
            _nomeLotacaoCafe = nomeLotacaoCafe;
            _lotacaoLotacaoCafe = lotacaoLotacaoCafe;
            _lotacaoDaSala = lotacaoDaSala;
        }
        #endregion

        #region Propriedades
        public int ID
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string NOME
        {
            set { _nome = value; }
            get { return _nome; }
        }
        public string SOBRENOME
        {
            set { _sobrenome = value; }
            get { return _sobrenome; }
        }
        public string NOME_SALA
        {
            set { _nomeSala = value; }
            get { return _nomeSala; }
        }
        public string NOME_CAFE
        {
            set { _nomeLotacaoCafe = value; }
            get { return _nomeLotacaoCafe; }
        }
        public double LOTACAO_CAFE
        {
            set { _lotacaoLotacaoCafe = value; }
            get { return _lotacaoLotacaoCafe; }
        }
        public double LOTACAO_SALA
        {
            set { _lotacaoDaSala = value; }
            get { return _lotacaoDaSala; }
        }
        #endregion

        #region Acessa Dados
        public void Inserir()
        {
            MaxId++;
            _Id = MaxId;
            listaDeNomes.Add(this);
        }
        public static List<Cadastro> Consultar()
        {
            return listaDeNomes;
        }
        public static List<Cadastro> Consultar(string consultar)
        {
            return listaDeNomes.FindAll(ldn => ldn.NOME.Contains(consultar));
        }       
        #endregion

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
