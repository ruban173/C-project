using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSystem.Lib;


namespace ClientSystem.Forms
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new AddCategoryGoods()).Show();
        }

        private void button_goods_Click(object sender, EventArgs e)
        {
            (new AddGoods()).Show();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (ConnectContext db = new ConnectContext((new ConfigJson()).StringConnecting())){
                var countGoods = from g in db.Goods
                                 join cat in db.Goods_category on g.id_goods_category equals cat.id
                               
                                 group g by new {
                                     g.Goods_category,
                                     g.title,g.manufacturer} into s
                                // where s.Count()<5
                                
                                 select new { //cat=s.Key.Goods_category.title,
                                            title =s.Key.title,
                                            manufacturer =s.Key.manufacturer,
                                            count = string.IsNullOrEmpty(s.Count().ToString())?0: s.Count()
                                 };
                
                    gridStorage.DataSource = countGoods.ToList();




            }
            
        }
    }
}
