using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSystem.Forms;
using ClientSystem.Lib;
using System.IO;


namespace ClientSystem
{
    static class Program
    {
      static  private void addEmp(string _login, string _type,int _reg,string[]fio)
        {
            ConnectContext db = new ConnectContext((new ConfigJson()).StringConnecting());
            int _day = new Random().Next(0, 4000);
         
            db.SaveChanges();
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

         /* string[] c=  File.ReadAllLines("category.txt");
          string[] g=  File.ReadAllLines("goods.txt");

            ConnectContext db = new ConnectContext((new ConfigJson()).StringConnecting());
           Goods_category cat = new Goods_category
            {
                title = c[0],
                date_up = DateTime.Now,
            };

            db.Goods_category.Add(cat);

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 6; j < g.Length; j++)
                {
                    string[] prod = g[j].Split('$');
                    int _shelf_life = new Random().Next(3, 14);
                    DateTime _date_create = DateTime.Now.AddDays(-new Random().Next(0, 3));
                    DateTime _date_end = _date_create.AddDays(_shelf_life);
                    string _title = prod[0] ;
                    _title = (_title.Length > 50) ? _title.Substring(0, 50) : _title;
                    Goods goods = new Goods
                    {

                        title = _title,
                        basket = "продается",
                        id_goods_category = 7,
                        price = Convert.ToDecimal(new Random().Next(30, 300)),
                        manufacturer = prod[1],
                        count = new Random().Next(30, 100),
                        shelf_life = _shelf_life,
                        date_create = Convert.ToDateTime(_date_create),
                        date_end = Convert.ToDateTime(_date_end),
                        description = g[j].Replace('$', ' '),
                        //discont = Convert.ToDouble(new Random().Next(0, 10)),
                        discont = 0,
                        measurement = "упаковка",
                        status = "Без деформации",
                        code = "001" + new Random().Next(0, 99999999),
                        id_subsidiary_companies_region = i
                    };
                    db.Goods.Add(goods); db.SaveChanges();
                };
               
            }
           
    */





            Application.Run(new Autorization());
        // Application.Run(new Admin());
        //    Application.Run(new AddGoods());
      // Application.Run(new Seller());
          //  Application.Run(new SearchGoods());

            //  Application.Run(new SeeSale());
            //Application.Run(new Configuration());

        }
    }
}
