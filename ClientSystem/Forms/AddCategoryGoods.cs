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
    public partial class AddCategoryGoods : Form
    {
        ConnectContext db;

        public AddCategoryGoods()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            db.Goods_category.Local.CollectionChanged += Local_CollectionChanged;

        }

        void Local_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshModels();
            gridCategoryGoods.Refresh();
        }
        private void RefreshModels()
        {
                               
            gridCategoryGoods.DataSource = db.Goods_category.ToList();

        }
        private void AddCategoryGoods_Load(object sender, EventArgs e)
        {
            RefreshModels();

            gridCategoryGoods.Columns["title"].HeaderText = "Название";
            gridCategoryGoods.Columns["date_up"].HeaderText = "Дата обновления";
            gridCategoryGoods.Columns["Goods"].Visible = false;

        }

        private void gridCategoryGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCategoryGoods.CurrentRow != null)
            {
                gridCategoryGoods.ClearSelection();
                gridCategoryGoods.Rows[gridCategoryGoods.CurrentRow.Index].Selected = true;
                gridCategoryGoods.CurrentCell = gridCategoryGoods.SelectedRows[0].Cells[0];
                var currentCategory = gridCategoryGoods.CurrentRow.DataBoundItem as Goods_category;
                titleCategory.Text = currentCategory.title;


            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            titleCategory.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int? id_region = db.Subsidiary_companies_region.Find((int)new ConfigJson().SubsidiaryCompaniesRegion()).id_subsidiary_companies.Value;

            Goods_category newCat = new Goods_category
            {
                title = titleCategory.Text,
                date_up = DateTime.Now,
                subsidiary_companies_id =db.Subsidiary_companies.Where(s=>s.id== id_region).First().id

            };
            db.Goods_category.Add(newCat);
            db.SaveChanges();
            RefreshModels();
            titleCategory.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            var currentCategory = gridCategoryGoods.CurrentRow.DataBoundItem as Goods_category;
            currentCategory.title = titleCategory.Text;
            currentCategory.date_up = DateTime.Now;
            db.SaveChanges();
            RefreshModels();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (gridCategoryGoods.CurrentRow != null)
            {
                var catRow = gridCategoryGoods.CurrentRow.DataBoundItem as Goods_category;
                db.Goods_category.Remove(catRow);
            }
            db.SaveChanges();
            RefreshModels();
        }
    }
}
