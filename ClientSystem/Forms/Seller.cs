using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSystem.Lib;

using System.Windows.Forms;

namespace ClientSystem.Forms
{
    public partial class Seller : Form
    {
        ConnectContext db;
       List<Goods> goods;

        public Seller()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
        }

      

        private void Seller_Load(object sender, EventArgs e)
        {
             goods = db.Goods.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridSeller.Columns.Add("id", "id");
            gridSeller.Columns.Add("title", "Название");
            gridSeller.Columns.Add("price", "Цена");
            gridSeller.Columns.Add("discont", "Скидка");
        
          IEnumerable<Goods> result= goods.Where(g => g.code == "18671631687111").ToList();
            var item=result.First();
          gridSeller.Rows.Add(item.id,item.title,item.price,item.discont);
            /*  var result= goods;
            if (result != null)
            {              gridSeller.DataSource=result;
                gridSeller.Refresh();
            }
            else {
                MessageBox.Show("Продукт с таким кодом отсутствует");
            }*/
        }
    }
}
