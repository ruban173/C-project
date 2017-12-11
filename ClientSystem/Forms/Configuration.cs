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
using ClientSystem;

namespace ClientSystem.Forms
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {

            ConfigJson res = (new ConfigJson()).jsonRead();
            if (res != null)
            {
                server.Text = res.server;
                user.Text = res.user;
                password.Text = res.password;
                db.Text = res.db;

                LoadOrganization();
                organization_id.SelectedValue = res.SubsidiaryCompaniesRegion();
            }
         }
        private void LoadOrganization()
        {
            ConnectContext connect = new ConnectContext((new ConfigJson()).StringConnecting());
            try
            {
                organization_id.DataSource = connect.Subsidiary_companies_region.Select(s => new {
                    title = s.Subsidiary_companies.title + " " + s.adress,
                    id = s.id
                }).ToList();
                organization_id.DisplayMember = "title";
                organization_id.ValueMember = "id";
                organization_id.Refresh();
            }
            catch
            {
                MessageBox.Show("Нет подключения!");
            }
           
        }
        private void button_save(object sender, EventArgs e)
        {
            (new ConfigJson(server.Text,
                    user.Text,
                    password.Text, 
                    db.Text,
                    (organization_id.SelectedValue==null)?-1:(int)organization_id.SelectedValue)
                ).jsonWrite();

           /* if (organization_id.SelectedIndex != -1)
            {
                (new ConfigJson(server.Text, user.Text, password.Text, db.Text, (int)organization_id.SelectedValue)).jsonWrite();

            }
            else
            {
                MessageBox.Show("Выберите организацию");
            }*/
        }

        private void button_test_connection_Click(object sender, EventArgs e)
        {
           
            try
            {

                ConnectContext connect = new ConnectContext((new ConfigJson()).StringConnecting());
                connect.Database.Connection.Open();
                MessageBox.Show("Подключение установлено");
                connect.Database.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }
    }
}
