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
            using (ConnectContext db = new ConnectContext((new ConfigJson()).StringConnecting()))
            {
                var countGoods = from g in db.Goods
                                 join cat in db.Goods_category on g.id_goods_category equals cat.id

                                 group g by new
                                 {
                                     g.Goods_category,
                                     g.title,
                                     g.manufacturer
                                 } into s


                                 select new
                                 {
                                     title = s.Key.title,
                                     manufacturer = s.Key.manufacturer,
                                     count = s.Count(),
                                     sum = s.Sum(x => x.count)
                                 };

                gridStorage.DataSource = countGoods.ToList();
                gridStorage.Columns["title"].HeaderText = "Название товара";
                gridStorage.Columns["manufacturer"].HeaderText = "Производитель";
                gridStorage.Columns["count"].HeaderText = "Количество партий";
                gridStorage.Columns["sum"].HeaderText = "Общее количество товара";

            }
        }

        private void gridStorage_Paint(object sender, PaintEventArgs e)
        {
        /*    try
            {
                gridStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridStorage.ClearSelection();

                foreach (DataGridViewRow row in gridStorage.Rows)
                {
                    int cursor = (int)row.Cells["sum"].Value;

                    int? valRed = (redBox.Text != "") ? Convert.ToInt32(redBox.Text) : -1;
                    int? valBlue = (blueBox.Text != "") ? Convert.ToInt32(blueBox.Text) : -1;
                    int? valGreen = (greenBox.Text != "") ? Convert.ToInt32(greenBox.Text) : -1;

                    if (cursor <= valGreen && valGreen != -1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (cursor <= valBlue && valBlue != -1)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                    if (cursor <= valRed && valRed != -1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены некорректные параметры ");
            }
            */
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private string dayAdd(DateTime d)
        {
            return d.ToString();
        }
        private void button_payment_card_Click(object sender, EventArgs e)
        {
            using (ConnectContext db = new ConnectContext((new ConfigJson()).StringConnecting()))
            {
                DateTime today = DateTime.Now;
                DateTime answer = today.AddDays(36);
                var countGoods = from g in db.Goods
                                 join cat in db.Goods_category on g.id_goods_category equals cat.id
                              
                           
                                 select new
                                 {   category=g.Goods_category.title,
                                     title =g.title,
                                     manufacturer = g.manufacturer,
                                     date_create = g.date_create,
                                     date_end=g.date_end,
                                     shelf_life = g.shelf_life,
                                     count =g.count
                                    
                                 };

                 gridStorage.DataSource = countGoods.ToList();
               
                gridStorage.Columns["category"].HeaderText = "Категория";
                gridStorage.Columns["title"].HeaderText = "Название товара";
                gridStorage.Columns["manufacturer"].HeaderText = "Производитель";
                gridStorage.Columns["count"].HeaderText = "Количество ";
                gridStorage.Columns["date_end"].HeaderText = "Дата просрочки";
                gridStorage.Columns["shelf_life"].HeaderText = "Срок годности";
                gridStorage.Columns["date_create"].HeaderText = "Дата производства";

            }
        }
    }
}
