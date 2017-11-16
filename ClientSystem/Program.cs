using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSystem.Forms;


namespace ClientSystem
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Autorization());
            //Application.Run(new Storage());
           // Application.Run(new AddGoods());
           Application.Run(new Seller());
          //  Application.Run(new SeeSale());
            //Application.Run(new Configuration());

        }
    }
}
