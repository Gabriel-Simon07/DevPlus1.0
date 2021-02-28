using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevPlus.Models;

namespace DevPlus
{
    static class Program
    {
        public static List<Cadastro> nomeDaSala = new List<Cadastro>();//
        public static List<NomeaçãoLotacaoCafe> nomeDoLotacaoCafe = new List<NomeaçãoLotacaoCafe>();//
        public static List<LotaçãoDoCafé> lotacaoDoLotacaoCafe = new List<LotaçãoDoCafé>();
        public static List<LotaçãoDaSala> lotacaoDaSala = new List<LotaçãoDaSala>();//
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new telaMenu());
        }
    }
}
