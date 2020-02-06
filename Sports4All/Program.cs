using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Sports4All
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> nomes = new List<string>();
            nomes.Add("Manel");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            nomes.Clear();
            if(nomes.Any())
            {
                foreach (var nome in nomes)
                {
                    Console.WriteLine(nome);
                }
            }
            else
            {
                Console.WriteLine("Não há nomes");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Form1.Instance);
        }
    }
}
