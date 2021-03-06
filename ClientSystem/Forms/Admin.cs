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
using System.Windows.Forms.DataVisualization.Charting;


namespace ClientSystem.Forms
{
    public partial class Admin : Form
    {
        User_access user;
        ConnectContext db;
       

        public Admin()
        {
            InitializeComponent(); db = new ConnectContext((new ConfigJson()).StringConnecting());
        }
        public Admin(User_access user)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            this.user = user;

        }
        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddEmployee()).Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new UserAccess()).Show();

        }

        private void сменитьРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminSaleOrder(ref gridAdmin,ref  labRres,ref Chart).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var BestEmp = from s in db.Sale
                          join p in db.Employees on s.id_employess equals p.id_user_access

                          select new
                          {
                              s.id,
                              fio = p.first_name + " " + p.middle_name + " " + p.last_name,
                              // s.date_up, s.payment, s.price, count = s.Sale_basket.Count()
                          };
            gridAdmin.DataSource = BestEmp.ToList();

        }

        private void Chart_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             Chart.Series[0].ChartType = SeriesChartType.Line;

        }

        private void button_column_Click(object sender, EventArgs e)
        {
            Chart.Series[0].ChartType = SeriesChartType.RangeColumn;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chart.Series[0].ChartType = SeriesChartType.Point;

        }
    }
}
