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
        public static List<Nomea��oLotacaoCafe> nomeDoLotacaoCafe = new List<Nomea��oLotacaoCafe>();//
        public static List<Lota��oDoCaf�> lotacaoDoLotacaoCafe = new List<Lota��oDoCaf�>();
        public static List<Lota��oDaSala> lotacaoDaSala = new List<Lota��oDaSala>();//
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
