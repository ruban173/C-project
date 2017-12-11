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
    public partial class UserAccess : Form
    {
        ConnectContext db;
       
        public UserAccess()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            db.User_access.Local.CollectionChanged += Local_CollectionChanged;


        }
        void Local_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            refreshModel();

        }
        private void refreshModel()
        {
      gridEmployees.DataSource = db.User_access.ToList();
            //gridEmployees.Refresh();
            GridColorRows();
        }
       

        private void UserAccess_Load(object sender, EventArgs e)
        {
            refreshModel();
            subsidiary_companies_region.DataSource = db.Subsidiary_companies_region.Select(
                x=>new
                {
                    x.id,
                    title = x.region + " " + x.settlement + " " + x.street + " " + x.number
                }
                ).ToList() ;
            subsidiary_companies_region.DisplayMember = "title";
            subsidiary_companies_region.ValueMember = "id";
            subsidiary_companies_region.SelectedIndex = -1;

            type.Items.AddRange(new string[] {
            "администратор",
            "склад",
            "продавец"});
            status.Items.AddRange(new string[] {
            "Активен",
            "Приостановлен"});

            gridEmployees.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gridEmployees.Columns["login"].HeaderText = "Логин";
            gridEmployees.Columns["password"].HeaderText = "Пароль";
            gridEmployees.Columns["type"].HeaderText = "Права доступа";
            gridEmployees.Columns["date_up"].HeaderText = "Дата создания";
            gridEmployees.Columns["status"].HeaderText = "Статус";
            gridEmployees.Columns["Employees"].Visible = false;
            gridEmployees.Columns["id_subsidiary_companies_region"].Visible = false;
        }

        private void gridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (gridEmployees.CurrentRow != null)
            {
                ClearTextBoxes();
                gridEmployees.ClearSelection();
                gridEmployees.Rows[gridEmployees.CurrentRow.Index].Selected = true;
                gridEmployees.CurrentCell = gridEmployees.SelectedRows[0].Cells[0];
                var currentEmp = gridEmployees.CurrentRow.DataBoundItem as User_access;
                login.Text = currentEmp.login;
                password.Text = currentEmp.password;
                type.SelectedText = currentEmp.type;
                status.SelectedText = currentEmp.status;
                subsidiary_companies_region.SelectedValue = (currentEmp.id_subsidiary_companies_region==null)?-1: currentEmp.id_subsidiary_companies_region;
                labelEmployee.Text = (db.Employees.Where(x => x.id_user_access == currentEmp.id).Count() != 0) ?
                   "Сотрудник: "+ db.Employees.Where(x => x.id_user_access == currentEmp.id).Select(c => new
                    {
                        name = c.first_name + " " + c.middle_name + " " + c.last_name
                    }
                    ).First().name : "Пользователь не назначен";
          }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                User_access addAccess = new User_access
                {
                    login = login.Text,
                    password = password.Text,
                    type = type.Text,
                    status = status.Text,
                    id_subsidiary_companies_region= (int)subsidiary_companies_region.SelectedValue,
                    date_up = DateTime.Now
                };
                db.User_access.Add(addAccess);
                db.SaveChanges();
                refreshModel();

            }

            catch 
            {

                MessageBox.Show("Заполните поля");
            }


        }
       
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridEmployees.CurrentRow != null)
            {
                 var AccessRow = gridEmployees.CurrentRow.DataBoundItem as User_access;
                 db.User_access.Remove(AccessRow);
            }
            db.SaveChanges();
            refreshModel();
            ClearTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridEmployees.CurrentRow != null)
                {
                   var currentEmp = gridEmployees.CurrentRow.DataBoundItem as User_access;
                   
                    currentEmp.login = login.Text;
                    currentEmp.password = password.Text;
                    currentEmp.type = type.Text;
                    currentEmp.status = status.Text;
                    currentEmp.id_subsidiary_companies_region = (int)subsidiary_companies_region.SelectedValue;
                    currentEmp.date_up = DateTime.Now;
                    db.SaveChanges();
                    int index = gridEmployees.CurrentRow.Index;
                    refreshModel();
                    gridEmployees.ClearSelection();
                    gridEmployees.Rows[index].Selected = true;
                    gridEmployees.CurrentCell = gridEmployees.SelectedRows[0].Cells[0];
                   

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
       
        private void ClearTextBoxes()
        {
            
            foreach (var textBox in group.Controls.OfType<TextBox>())
                             textBox.Clear();
           foreach (var comboBox in group.Controls.OfType<ComboBox>())
            {
                comboBox.Text =null;
                comboBox.SelectedIndex = -1;
            }
            gridEmployees.ClearSelection();
            labelEmployee.Text = null;

        }

       
        private void button7_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void UserAccess_Paint(object sender, PaintEventArgs e)
        {
            GridColorRows();
        }
        private void GridColorRows()
        {
            gridEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEmployees.ClearSelection();
            var emp = db.Employees.ToList();
            foreach (DataGridViewRow row in gridEmployees.Rows)
            {
                int cursor = (int)row.Cells["id"].Value;
                row.DefaultCellStyle.BackColor = (emp.Find(s => s.id_user_access == cursor) == null) ? Color.PaleGoldenrod : Color.Cyan;


            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }


}
