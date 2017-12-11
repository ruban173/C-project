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
    public partial class SeeSale : Form
    {
        ConnectContext db;
        User_access user;
       IEnumerable< Employees> employees;
        public SeeSale()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            db.Sale.Local.CollectionChanged += Local_CollectionChanged;
        }
        public SeeSale(User_access user)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            db.Sale.Local.CollectionChanged += Local_CollectionChanged;
            this.user = user;
            this.employees = db.Employees.Where(em=>em.id_user_access==user.id).ToList();

        }
        void Local_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshModels();

        }
        private void RefreshModels()
        {
            if (gridSale.CurrentRow != null)
            {

                Sale currentSale = gridSale.CurrentRow.DataBoundItem as Sale;
               



    var curentBasketGoods = db.Sale_basket.Join(db.Goods, 
                            b =>b.id_goods , 
                            g => g.id,
                            (b, g) => new 
                                {
                                    id =b.id ,
                                    title = g.title,
                                    price = g.price,
                                    discont = g.discont,
                                    code = g.code,
                                    id_sale = b.id_sale

                                }).Where(s=>s.id_sale==currentSale.id).ToList();


                if (currentSale != null) gridSaleBasket.DataSource = curentBasketGoods;

             gridSaleBasket.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                gridSaleBasket.Columns["title"].HeaderText = "Название";
                gridSaleBasket.Columns["price"].HeaderText = "Цена без скидки";
                gridSaleBasket.Columns["discont"].HeaderText = "Скидка";
                gridSaleBasket.Columns["code"].HeaderText = "Штрих код";

                gridSaleBasket.Columns["id_Sale"].Visible = false;

                
            }
            gridSaleBasket.Refresh();
 
        }



        private void SeeSale_Load(object sender, EventArgs e)
        {
            var sale = db.Sale.Where(s=>s.id_employess==this.user.id).ToList();
            gridSale.DataSource = sale;
            gridSale.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gridSale.Columns["date_up"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            gridSale.Columns["price"].HeaderText = "Цена без скидки";
            gridSale.Columns["discont"].HeaderText = "Скидка";
            gridSale.Columns["payment"].HeaderText = "Оплачено";
            gridSale.Columns["price"].HeaderText = "Цена всего";
            gridSale.Columns["date_up"].HeaderText = "Дата продажи";
            gridSale.Columns["id_employess"].Visible = false;
            gridSale.Columns["id_subsidiary_companies_region"].Visible = false;
            gridSale.Columns["Sale_basket"].Visible = false; 
            gridSale.Columns["Subsidiary_companies_region"].Visible = false;
            gridSale.Columns["date_up"].DisplayIndex = 0;
            gridSale.Columns["date_up"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm: ss";



            RefreshModels();
        }

       


        private void delete_Click(object sender, EventArgs e)
        {
            if (gridSaleBasket.CurrentRow != null)
            {
                var goodsRow = gridSaleBasket.CurrentRow.DataBoundItem as Goods;
                db.Goods.Remove(goodsRow);
            }
            db.SaveChanges();
            RefreshModels();
        }



        private void gridGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridSaleBasket.ClearSelection();
            gridSaleBasket.Rows[gridSaleBasket.CurrentRow.Index].Selected = true;
            gridSaleBasket.CurrentCell = gridSaleBasket.SelectedRows[0].Cells[0];

        }

        private void gridSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSale.CurrentRow != null)
            {
                gridSale.ClearSelection();
                gridSale.Rows[gridSale.CurrentRow.Index].Selected = true;
                gridSale.CurrentCell = gridSale.SelectedRows[0].Cells[0];


            }
            RefreshModels();
        }

       
    }
}
