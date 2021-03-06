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
    public partial class Storage : Form
    {
        User_access user;
        public Storage()
        {
            InitializeComponent();
        }
        public Storage(User_access user)
        {
            InitializeComponent();
            this.user = user;

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
            ColorRows("sum");
        }
        private void ColorRows(string nameRow) {
            try
            {
                gridStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridStorage.ClearSelection();


                foreach (DataGridViewRow row in gridStorage.Rows)
                {

                    int cursor = (int)row.Cells[nameRow].Value;


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
        }
        private void ColorRowsDate()
        {
            try
            {
                gridStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridStorage.ClearSelection();


                foreach (DataGridViewRow row in gridStorage.Rows)
                {

                    DateTime date_end = (DateTime) row.Cells["date_end"].Value;
                    DateTime now =DateTime.Now;
                    TimeSpan res = date_end-now;

                    int day = Convert.ToInt32(res.Days);


                    int? valRed = (redBox.Text != "") ? Convert.ToInt32(redBox.Text) : -1;
                    int? valBlue = (blueBox.Text != "") ? Convert.ToInt32(blueBox.Text) : -1;
                    int? valGreen = (greenBox.Text != "") ? Convert.ToInt32(greenBox.Text) : -1;

                    if (day <= valGreen && valGreen != -1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (day <= valBlue && valBlue != -1)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                    if (day <=valRed && valRed != -1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    } 
                }


            }
            catch
            {
                MessageBox.Show("Введены некорректные параметры ");
            }
        }
        private string dayAdd(DateTime d)
        {
            return d.ToString();
        }
        private void button_payment_card_Click(object sender, EventArgs e)
        {
            using (ConnectContext db = new ConnectContext((new ConfigJson()).StringConnecting()))
            {
               var countGoods = from g in db.Goods
                                 join cat in db.Goods_category on g.id_goods_category equals cat.id
                                 select new
                                 {   category=g.Goods_category.title,
                                     title =g.title,
                                     manufacturer = g.manufacturer,
                                     date_create = g.date_create,
                                     date_end=g.date_end,
                                     shelf_life = g.shelf_life,
                                     count =g.count,
                                    
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
            ColorRowsDate();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
           IEnumerable<Employees> emp=   this.user.Employees.ToList();
            this.Text += "  ( "+emp.First().first_name.ToString()+" "+emp.First().middle_name.ToString()+" "+emp.First().last_name.ToString()+" )";
        }

       
    }
}
