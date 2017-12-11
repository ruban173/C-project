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
using System.Windows.Forms.DataVisualization.Charting;

namespace ClientSystem.Forms
{
    public partial class AdminSaleOrder : Form
    {
        ConnectContext db;
        DataGridView grid;
        Label labRes;
        Chart Chart;

        public AdminSaleOrder()
        {
            InitializeComponent();
        }
        public AdminSaleOrder(ref DataGridView grid ,ref Label labRes, ref Chart Chart)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            this.grid = grid;
            this.labRes = labRes;
            this.Chart = Chart;
        }

        private void AdminSaleOrder_Load(object sender, EventArgs e)
        {
            

            listEmp.DataSource = db.Employees.Select(s=>new {id=s.id,fio=s.first_name+" "+s.middle_name+" "+s.last_name }).ToList();
            listEmp.DisplayMember = "fio";
            listEmp.ValueMember = "id";

            listGoods.DataSource = db.Goods.ToList();
            listGoods.DisplayMember = "title";
            listGoods.ValueMember = "id";


            if (interval.Checked) end.Enabled = true;
            if (allEmp.Checked) listEmp.Enabled = false;
            if (allGoods.Checked) listGoods.Enabled = false;
        }

        private void interval_CheckedChanged(object sender, EventArgs e)
        {
            if (interval.Checked) end.Enabled = true;
            else end.Enabled = false;

        }

        private void allEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (!allEmp.Checked) listEmp.Enabled = true;
            else listEmp.Enabled = false;
        }

        private void allGoods_CheckedChanged(object sender, EventArgs e)
        {
            if (!allGoods.Checked) listGoods.Enabled = true;
            else listGoods.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
             if (!allEmp.Checked)
            {
              

                for (int i = 0; i < listEmp.CheckedItems.Count; i++)
                {
                    listEmp.CheckedItems[i].GetType() c = listEmp.CheckedItems[i];
                   MessageBox.Show( listEmp.CheckedItems[i].GetType().ToString());
                }
              

            }
          

            var Order = from s in db.Sale
                                    select new { 
                                        s.id,
                                        s.date_up,
                                        s.payment,
                                        s.price,
                                        count= s.Sale_basket.Count(),

                                    };
            if (interval.Checked && begin.Value!= end.Value)
            {
                 Order = from s in db.Sale
                           where s.date_up > begin.Value && s.date_up < end.Value
                           select new
                           {
                               s.id,
                               s.date_up,
                               s.payment,
                               s.price,
                               count = s.Sale_basket.Count(),

                           };
            }
           

            var res = Order.ToList();
            if (res.Count() != 0)
            {
                this.Chart.DataSource = res;
                this.Chart.Series[0].XValueMember = "date_up";
                this.Chart.Series[0].XValueType = ChartValueType.DateTime;
                this.Chart.Series[0].YValueType = ChartValueType.Double;
                this.Chart.Series[0].YValueMembers = "payment";
                this.grid.DataSource = res;
                this.labRes.Text = "-> Выручка= " + res.Sum(d => d.payment).ToString() +
                                  "\n -> Количество товаров=" + res.Sum(d => d.count).ToString() +
                                  "\n ->  Период продаж с " + res.Min(d => d.date_up).ToString() +
                                  "\n по " + res.Max(d => d.date_up).ToString() +
                                  "\n ->  Максимальная стоимость сделки " + res.Max(d => d.payment).ToString() +
                                  "\n ->  Минимальная стоимость сделки " + res.Min(d => d.payment).ToString()
                                  ;
            }
            else MessageBox.Show("По запросу ничего не найдено");
          
            
        }
    }
}
class ListEmps
{
    public int id;
    public string fio;
}