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
    public partial class Education : Form
    {
        ConnectContext db;
        int id_employees;
        ListBox education;
        Employees_education educationItem;
        public Education()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());

        }
        public Education(int id_employees, ref ListBox education)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            this.id_employees = id_employees;
            this.education = education;

        }
        public Education(Employees_education educationItem)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            this.educationItem = educationItem;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.educationItem != null)
                {

                    this.educationItem.type = type.Text;
                    this.educationItem.organization = organization.Text;
                    this.educationItem.date_create = date_create.Value;
                    this.educationItem.number = Convert.ToInt32(number.Text);
                    this.educationItem.qualification = qualification.Text;
                    this.educationItem.specialty = specialty.Text;
                    this.educationItem.date_up = DateTime.Now;
                    db.SaveChanges();
                }
                else
                {
                    Employees_education education = new Employees_education
                    {

                        id_employees = this.id_employees,
                        type = type.Text,
                        organization = organization.Text,
                        date_create = date_create.Value,
                        number = Convert.ToInt32(number.Text),
                        qualification = qualification.Text,
                        specialty = specialty.Text,
                        date_up = DateTime.Now
                    };
                    db.Employees_education.Add(education);
                    db.SaveChanges();
                    this.education.DataSource = db.Employees_education.Where(x => x.id_employees == id_employees).ToList();

                    this.education.Refresh();



                }
            }
            catch
            {
                MessageBox.Show("Заполните поля");
            }
            finally
            {
                this.Close();

            }
        }

        private void Education_Load(object sender, EventArgs e)
        {
           
            if (this.educationItem != null)
            {

                type.Text= this.educationItem.type;
                organization.Text= this.educationItem.organization ;
                date_create.Value = this.educationItem.date_create.Value;
                number.Text = this.educationItem.number.ToString();
                qualification.Text= this.educationItem.qualification;
                specialty.Text = this.educationItem.specialty;
               
                
            }

        }
    }
}
