using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Controller;
using Sports4All.CreateEvent;

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

            Session.Instance.LoggedUser = "paulo";

            //ImagesController.InsertPathImagesToDB();


            IPriceEntity priceEntity = new Ground();
            Console.WriteLine(priceEntity.getCost());

            //priceEntity = new Bola(priceEntity,);
            //Console.WriteLine(priceEntity.getCost());
            //priceEntity = new Bola(priceEntity);
            //Console.WriteLine(priceEntity.getCost());
            //priceEntity = new Raquete(priceEntity);
            //Console.WriteLine(priceEntity.getCost());

            //MaterialDecorator material



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Form1.Instance);
        }
    }
}
