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
        int userID = 1;
        ConnectContext db;
        List<Goods> goods;

        public Seller()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
        }



        private void Seller_Load(object sender, EventArgs e)
        {
            gridSeller.Columns.Add("id", "id");
            gridSeller.Columns.Add("title", "Название");
            gridSeller.Columns.Add("price", "Цена");
            gridSeller.Columns.Add("discont", "Скидка");
            goods = db.Goods.ToList();
        }
        private void sellerPrice()
        {
            decimal sum = 0;
            decimal sumPrice = 0;
            decimal sumDiscont = 0;


            foreach (DataGridViewRow row in gridSeller.Rows)
            {
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                decimal discont = price * Convert.ToDecimal(row.Cells["discont"].Value) / 100;
                sum += price;
                sumDiscont += discont;
                sumPrice += price - discont;
            }
            price_all.Text = sum.ToString();
            payment.Text = sumPrice.ToString();
            discont_all.Text = sumDiscont.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearDescriptionGoods();


            IEnumerable<Goods> result = goods.Where(g => (g.code == searchCode.Text && g.basket != "продано" && g.count != 0)).ToList();

            if (result.Count() != 0)
            {
                var item = result.First();
                gridSeller.Rows.Add(item.id, item.title, item.price, item.discont);

                sellerPrice();
            }
            else MessageBox.Show("Товар по данному штрих коду не найден");

        }

        private void button_cash_Click(object sender, EventArgs e)
        {
            if (gridSeller.CurrentRow != null)
            {
                ClearDescriptionGoods();

                gridSeller.Rows.Remove(gridSeller.CurrentRow);

            }

        }

        private void gridSeller_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            sellerPrice();
        }

        private void button_payment_card_Click(object sender, EventArgs e)
        {
            ClearDescriptionGoods();

            gridSeller.Rows.Clear();
        }

        private void ClearDescriptionGoods()
        {
            labelTitle.Text = "";
            labelPrice.Text = "";

        }
        private void gridSeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSeller.CurrentRow != null)
            {
                ClearDescriptionGoods();
                gridSeller.ClearSelection();
                gridSeller.Rows[gridSeller.CurrentRow.Index].Selected = true;
                gridSeller.CurrentCell = gridSeller.SelectedRows[0].Cells[0];

                var id = Convert.ToInt32(gridSeller.CurrentRow.Cells["id"].Value);

                IEnumerable<Goods> goods = db.Goods.Where(g => g.id == id).ToList();
                foreach (var item in goods)
                {
                    labelTitle.Text = string.Format("Название товара: {0} => подробное описание: {1}", item.title, item.description);
                    decimal price = Convert.ToDecimal(item.price);
                    decimal discont = price * Convert.ToDecimal(item.discont) / 100;
                    decimal sum = price - discont;
                    labelPrice.Text = (item.discont == 0) ?
                        string.Format("{0}р.", item.price.ToString()) :
                        string.Format("{0}р. - {1}% = {2}р.", item.price.ToString(), item.discont.ToString(), sum.ToString());

                }




            }
        }
        private void saleBasket()
        {

            Sale sale = new Sale()
            {
                id_employess = userID,
                discont = Convert.ToDecimal(discont_all.Text),
                price = Convert.ToDecimal(price_all.Text),
                payment = Convert.ToDecimal(payment.Text),
                id_subsidiary_companies_region = (int)(new ConfigJson()).SubsidiaryCompaniesRegion(),
                date_up = DateTime.Now

            };
            db.Sale.Add(sale);
            foreach (DataGridViewRow row in gridSeller.Rows)
            {
                int? id = Convert.ToInt32(row.Cells["id"].Value);

                var goodsBasket = db.Goods.FirstOrDefault(g => g.id == id);
                if (goodsBasket.count-- == 0)
                {
                    goodsBasket.basket = "продано";
                    
                }
               
                Sale_basket sale_basket = new Sale_basket()
                {
                    id_goods = goodsBasket.id,
                    id_sale = sale.id

                };

                db.Sale_basket.Add(sale_basket);

            }

            db.SaveChanges();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (gridSeller.Rows.Count != 0)
            {
                saleBasket();
                ClearDescriptionGoods();
                gridSeller.Rows.Clear();
            }

        }

        private void button_sales_Click(object sender, EventArgs e)
        {
            (new SeeSale()).Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            (new SearchGoods(ref gridSeller)).Show();
        }

        private void gridSeller_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            sellerPrice();
        }

        private void gridSeller_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            sellerPrice();

        }
    }
}

