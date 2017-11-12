﻿using System;
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
    public partial class AddGoods : Form
    {
        ConnectContext db;

        public AddGoods()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            db.Goods_category.Local.CollectionChanged += Local_CollectionChanged;
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
                if (currentCategory != null) gridGoods.DataSource = currentCategory.Goods.ToList();

                gridGoods.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                gridGoods.Columns["title"].HeaderText = "Название";
                gridGoods.Columns["shelf_life"].HeaderText = "Срок годности";
                gridGoods.Columns["date_create"].HeaderText = "Дата производства";
                gridGoods.Columns["code"].HeaderText = "Штрих код";

                gridGoods.Columns["id_goods_category"].Visible = false;
                gridGoods.Columns["id_subsidiary_companies_region"].Visible = false;
                gridGoods.Columns["status"].Visible = false;
                gridGoods.Columns["Subsidiary_companies_region"].Visible = false;
                gridGoods.Columns["Goods_category"].Visible = false;
            }
            gridGoods.Refresh();
           // FillGoodsTextBoxes();

            
        }
        private void ClearTextBoxes(Control groupGoods)
        {
            foreach (var textBox in groupGoods.Controls.OfType<TextBox>())
                textBox.Clear();
            foreach (var comboBox in groupGoods.Controls.OfType<ComboBox>())
            {
                if (comboBox.Name == "categoryBox") {
                        comboBox.SelectedIndex = -1;
                    }
                    else
                    {
                        comboBox.Text = "";
                    }
              
               
            }
            date_create.Value = DateTime.Now;
            gridCategoryGoods.ClearSelection();
            gridGoods.ClearSelection();

        }
        private void FillGoodsTextBoxes()
        {
            ClearTextBoxes(groupGoods);
            if (gridCategoryGoods.CurrentRow == null || gridGoods.CurrentRow == null) return;

            var currentCat = gridCategoryGoods.CurrentRow.DataBoundItem as Goods_category;
            id.Text = currentCat.id.ToString();
            
            gridCategoryGoods.ClearSelection();
            gridCategoryGoods.Rows[gridCategoryGoods.CurrentRow.Index].Selected = true;
            gridCategoryGoods.CurrentCell = gridCategoryGoods.SelectedRows[0].Cells[0];

            var currentGoods = gridGoods.CurrentRow.DataBoundItem as Goods;

            title.Text = currentGoods.title;
            shelf_life.Text = currentGoods.shelf_life.ToString();
            date_create.Value = currentGoods.date_create.Value;
            code.Text = currentGoods.code;
            status.SelectedText  = currentGoods.status;

            gridGoods.ClearSelection();
            gridGoods.Rows[gridGoods.CurrentRow.Index].Selected = true;
            gridGoods.CurrentCell = gridGoods.SelectedRows[0].Cells[0];

            categoryBox.SelectedValue = currentCat.id;



        }

        private void AddGoods_Load(object sender, EventArgs e)
        {
            var catBox = db.Goods_category.ToList();
            gridCategoryGoods.DataSource = catBox;
            categoryBox.DataSource = catBox.ToList();
            categoryBox.DisplayMember = "title";
            categoryBox.ValueMember = "id";


            gridCategoryGoods.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gridCategoryGoods.Columns["title"].HeaderText = "Название";
            gridCategoryGoods.Columns["date_up"].Visible = false;
            gridCategoryGoods.Columns["Goods"].Visible = false;
            status.Items.AddRange(new string[] { "Без деформации", "Деформирован","" });

            
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
                id.Text = currentCat.id.ToString();
               
            }
            RefreshModels();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(groupGoods);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Goods newGoods = new Goods
            {

                title = title.Text,
                id_goods_category = (int)categoryBox.SelectedValue,
                id_subsidiary_companies_region = (int)(new ConfigJson()).SubsidiaryCompaniesRegion(),
                shelf_life = Convert.ToInt32(shelf_life.Text),
                date_create = DateTime.Now,
                code = code.Text,
                status = status.Text

            };
            db.Goods.Add(newGoods);
            db.SaveChanges();
            RefreshModels();

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (gridCategoryGoods.CurrentRow == null || gridGoods.CurrentRow == null) return;

            var currentGoods = gridGoods.CurrentRow.DataBoundItem as Goods;


            currentGoods.id_subsidiary_companies_region = (int)(new ConfigJson()).SubsidiaryCompaniesRegion();            
            currentGoods.id_goods_category = (int)categoryBox.SelectedValue;
            currentGoods.title = title.Text;
            currentGoods.shelf_life = Convert.ToInt32(shelf_life.Text);
            currentGoods.date_create = date_create.Value;
            currentGoods.code = code.Text;
            currentGoods.status = status.Text;

            db.SaveChanges();
            int index = gridGoods.CurrentRow.Index;
            RefreshModels();
            gridGoods.ClearSelection();
            gridGoods.Rows[index].Selected = true;
            gridGoods.CurrentCell = gridGoods.SelectedRows[0].Cells[0];
            FillGoodsTextBoxes();


        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (gridGoods.CurrentRow != null)
            {
                var goodsRow = gridGoods.CurrentRow.DataBoundItem as Goods;
                db.Goods.Remove(goodsRow);
            }
            db.SaveChanges();
            RefreshModels();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridGoods.ClearSelection();
            gridGoods.Rows[gridGoods.CurrentRow.Index].Selected = true;
            gridGoods.CurrentCell = gridGoods.SelectedRows[0].Cells[0];
            FillGoodsTextBoxes();
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(categoryBox.SelectedValue!=null)
            id.Text = categoryBox.SelectedValue.ToString();
        }
    }
}
