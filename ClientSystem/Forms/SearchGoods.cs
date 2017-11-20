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
    public partial class SearchGoods : Form
    {
        ConnectContext db;
        DataGridView gridBasket;
        public SearchGoods()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            db.Goods_category.Local.CollectionChanged += Local_CollectionChanged;
        }

        public SearchGoods(ref DataGridView gridBasket)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            db.Goods_category.Local.CollectionChanged += Local_CollectionChanged;
            this.gridBasket = gridBasket;
        }

        void Local_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshModels();

        }
        private void RefreshModels()
        {
            if (gridCategoryGoods.CurrentRow != null)
            {

                var currentCategory = gridCategoryGoods.CurrentRow.DataBoundItem as Goods_category;
                if (currentCategory != null) gridGoods.DataSource = currentCategory.Goods.Where(g=>g.basket!="продано").ToList();

                gridGoods.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                gridGoods.Columns["title"].HeaderText = "Название";
                gridGoods.Columns["shelf_life"].HeaderText = "Срок годности";
                gridGoods.Columns["date_create"].HeaderText = "Дата производства";
                gridGoods.Columns["code"].HeaderText = "Штрих код";

                gridGoods.Columns["id_goods_category"].Visible = false;
                gridGoods.Columns["id_subsidiary_companies_region"].Visible = false;
                gridGoods.Columns["status"].Visible = false;
                gridGoods.Columns["Subsidiary_companies_region"].Visible = false;
                gridGoods.Columns["price"].Visible = false;
                gridGoods.Columns["discont"].Visible = false;
                gridGoods.Columns["measurement"].Visible = false;
                gridGoods.Columns["Goods_category"].Visible = false;
                gridGoods.Columns["description"].Visible = false;
                gridGoods.Columns["basket"].Visible = false;
                gridGoods.Columns["Sale_basket"].Visible = false;
            }
            gridGoods.Refresh();
           // FillGoodsTextBoxes();

            
        }
        private void ClearTextBoxes(Control groupGoods)
        {
           

        }
        private void FillGoodsTextBoxes()
        {
            ClearTextBoxes(groupGoods);
            if (gridCategoryGoods.CurrentRow == null || gridGoods.CurrentRow == null) return;

            
            
            gridCategoryGoods.ClearSelection();
            gridCategoryGoods.Rows[gridCategoryGoods.CurrentRow.Index].Selected = true;
            gridCategoryGoods.CurrentCell = gridCategoryGoods.SelectedRows[0].Cells[0];

            var currentGoods = gridGoods.CurrentRow.DataBoundItem as Goods;

          



        }

        private void SearchGoods_Load(object sender, EventArgs e)
        {
            var catBox = db.Goods_category.ToList();
            gridCategoryGoods.DataSource = catBox;
            

            gridCategoryGoods.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gridCategoryGoods.Columns["title"].HeaderText = "Название";
            gridCategoryGoods.Columns["date_up"].Visible = false;
            gridCategoryGoods.Columns["Goods"].Visible = false;
          
          

            
            RefreshModels();
            FillGoodsTextBoxes();

        }

        private void gridCategoryGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearTextBoxes(groupGoods);

            if (gridCategoryGoods.CurrentRow != null)
            {
                gridCategoryGoods.ClearSelection();
                gridCategoryGoods.Rows[gridCategoryGoods.CurrentRow.Index].Selected = true;
                gridCategoryGoods.CurrentCell = gridCategoryGoods.SelectedRows[0].Cells[0];
                var currentCat = gridCategoryGoods.CurrentRow.DataBoundItem as Goods_category;
                
               
            }
            RefreshModels();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            basket.Items.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            foreach (Goods item in basket.Items)
            {
                this.gridBasket.Rows.Add(item.id, item.title, item.price, item.discont);
            }
            this.Close();



        }

      

        private void delete_Click(object sender, EventArgs e)
        {
            if (basket.SelectedIndex != -1)
            {
                basket.Items.RemoveAt(basket.SelectedIndex);
            }
          
        }

       

        private void gridGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridGoods.ClearSelection();
            gridGoods.Rows[gridGoods.CurrentRow.Index].Selected = true;
            gridGoods.CurrentCell = gridGoods.SelectedRows[0].Cells[0];
            FillGoodsTextBoxes();
        }

        private void gridGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gridGoods.ClearSelection();
            gridGoods.Rows[gridGoods.CurrentRow.Index].Selected = true;
            gridGoods.CurrentCell = gridGoods.SelectedRows[0].Cells[0];

            var goodsRow = gridGoods.CurrentRow.DataBoundItem as Goods;

            basket.Items.Add(goodsRow);
            basket.DisplayMember = "title";
            basket.ValueMember = "id";

        }

        
    }
}
