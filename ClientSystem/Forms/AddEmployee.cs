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
    public partial class AddEmployee : Form
    {
        ConnectContext db;
        int id_employees;

        public AddEmployee()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            db.Employees.Local.CollectionChanged += Local_CollectionChanged;
            

        }
        void Local_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            refreshModel();

        }
        private void refreshModel()
        {
            gridEmployees.DataSource = db.Employees.ToList();

            gridEmployees.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gridEmployees.Columns["first_name"].HeaderText = "Имя";
            gridEmployees.Columns["middle_name"].HeaderText = "Отчество";
            gridEmployees.Columns["last_name"].HeaderText = "Фамилия";
            gridEmployees.Columns["date_begin"].HeaderText = "Дата принятия";
            gridEmployees.Columns["date_end"].HeaderText = "Дата увольнения";
            gridEmployees.Columns["date_up"].HeaderText = "Дата обновления";
            gridEmployees.Columns["birthday"].HeaderText = "Дата рождения";
            gridEmployees.Columns["expiriens"].HeaderText = "Опыт";
            gridEmployees.Columns["position"].HeaderText = "Должность";
            gridEmployees.Columns["birthday"].HeaderText = "Дата рождения";

            gridEmployees.Columns["id_user_access"].Visible = false;
            gridEmployees.Columns["id_subsidiary_companies_region"].Visible = false;
            gridEmployees.Columns["id_education"].Visible = false;
            gridEmployees.Columns["User_access"].Visible = false;
            gridEmployees.Columns["Employees_education"].Visible = false;
           // gridEmployees.Refresh();
            GridColorRows();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            new Education(id_employees,ref education).Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            refreshModel();
            
                userAccess.DataSource = db.User_access.ToList();
                userAccess.DisplayMember = "login";
                userAccess.ValueMember = "id";
                userAccess.SelectedIndex = -1;
           



            subsidiary_companies_region.DataSource = db.Subsidiary_companies_region.Select(
                x=>new
                {
                    x.id,
                    title = x.Subsidiary_companies.title + " " + x.adress
                }
                ).ToList() ;
            subsidiary_companies_region.DisplayMember = "title";
            subsidiary_companies_region.ValueMember = "id";
            subsidiary_companies_region.SelectedIndex = -1;
            
            validationNot();
           
            
                

        }

        private void gridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (gridEmployees.CurrentRow != null)
            {
                gridEmployees.ClearSelection();
                gridEmployees.Rows[gridEmployees.CurrentRow.Index].Selected = true;
                gridEmployees.CurrentCell = gridEmployees.SelectedRows[0].Cells[0];

                var currentEmp = gridEmployees.CurrentRow.DataBoundItem as Employees;
                id_employees = currentEmp.id;
                first_name.Text = currentEmp.first_name;
                middle_name.Text = currentEmp.middle_name;
                last_name.Text = currentEmp.last_name;
                birthday.Value = currentEmp.birthday.Value;
                userAccess.SelectedValue = (currentEmp.id_user_access == null)?-1: currentEmp.id_user_access;

                position.Text = currentEmp.position;
                education.DataSource = db.Employees_education.Where(x => x.id_employees == currentEmp.id).ToList();
                education.DisplayMember = "type";
                education.ValueMember = "id";
                expiriens.Text = currentEmp.expiriens;
                date_begin.Value = currentEmp.date_begin.Value;
                subsidiary_companies_region.SelectedValue = (currentEmp.id_subsidiary_companies_region==null)?-1: currentEmp.id_subsidiary_companies_region;
             
                if (currentEmp.date_end.Equals(null))
                {
                    not.Checked = true;
                   
                }
                else {
                   
                    date_end.Value = currentEmp.date_end.Value;
                    not.Checked = false;
                }
                if (not.Checked) date_end.Visible = false;

                

            }
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new UserAccess().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? _date_end = null;
                int? id_user_access = null;

                if (!not.Checked) _date_end = date_end.Value;
                if(userAccess.Text != "") id_user_access=(int)userAccess.SelectedValue;
                Employees addEmp = new Employees
                {
                    first_name = first_name.Text,
                    middle_name = middle_name.Text,
                    last_name = last_name.Text,
                    birthday = birthday.Value,
                    id_user_access = id_user_access,
                    position = position.Text,
                    expiriens = expiriens.Text,
                    date_begin = date_begin.Value,
                    date_end = _date_end,
                    id_subsidiary_companies_region= (int)subsidiary_companies_region.SelectedValue,
                    date_up = DateTime.Now
                };
                db.Employees.Add(addEmp);
                db.SaveChanges();
                refreshModel();

            }

            catch 
            {

                MessageBox.Show("Заполните поля");
            }


        }
        private void not_CheckedChanged(object sender, EventArgs e)
        {
            validationNot();

        }
        private void validationNot()
        {
            if (not.Checked)
            {
                date_end.Visible = false;
            }
            else
            {
                date_end.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridEmployees.CurrentRow != null)
            {
                var EmployeesRow = gridEmployees.CurrentRow.DataBoundItem as Employees;
                db.Employees.Remove(EmployeesRow);
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
                    var currentEmp = gridEmployees.CurrentRow.DataBoundItem as Employees;
                    DateTime? _date_end = null;
                    if (!not.Checked) _date_end = date_end.Value;
                    currentEmp.first_name = first_name.Text;
                    currentEmp.middle_name = middle_name.Text;
                    currentEmp.last_name = last_name.Text;
                    currentEmp.birthday = birthday.Value;
                    if (userAccess.Text != "")
                    {
                        currentEmp.id_user_access = (int)userAccess.SelectedValue;
                    }
                    else
                    {
                        currentEmp.id_user_access = null;
                    }
                        
                    currentEmp.position = position.Text;
                    currentEmp.expiriens = expiriens.Text;
                    currentEmp.date_begin = date_begin.Value;
                    currentEmp.date_end = _date_end;
                    currentEmp.id_subsidiary_companies_region = (int)subsidiary_companies_region.SelectedValue;
                    currentEmp.date_up = DateTime.Now;
                    db.SaveChanges();
                    refreshModel();

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
                if (comboBox.Name == "userAccess")
                {
                    comboBox.SelectedIndex = -1;
                }
                else
                {
                    comboBox.Text = "";
                }


            }
            foreach (var DateTimePickerBox in group.Controls.OfType<DateTimePicker>())
                DateTimePickerBox.Value=DateTime.Now;

            foreach (var listBox in group.Controls.OfType<ListBox>())
                          listBox.DataSource = null;

            gridEmployees.ClearSelection();

        }

        private void education_DoubleClick(object sender, EventArgs e)
        {
            if (education.SelectedIndex != -1)
            {
                Employees_education educationItem = education.SelectedItem as Employees_education;
                new Education(educationItem).Show();
             
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (education.SelectedIndex != -1)
            {
                Employees_education educationItem = education.SelectedItem as Employees_education;
                db.Employees_education.Remove(educationItem);
                db.SaveChanges();
                education.DataSource = db.Employees_education.Where(x => x.id_employees == id_employees).ToList();
                

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void GridColorRows()
        {
            gridEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEmployees.ClearSelection();
            var access = db.User_access.ToList();
            Employees emp =null;
            foreach (DataGridViewRow row in gridEmployees.Rows)
            {
                 emp = row.DataBoundItem as Employees;
               
                if (emp.id_user_access == null) row.DefaultCellStyle.BackColor =  Color.PaleGoldenrod;
                else row.DefaultCellStyle.BackColor = Color.Cyan;
                if (emp.id_user_access!=null && access.Find(s => s.id == emp.id_user_access).status == "Приостановлен")
                {
                    row.DefaultCellStyle.BackColor = Color.Coral;
                }



            }
        }
    }


}
