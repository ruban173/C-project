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
            }

        }

        private void button_save(object sender, EventArgs e)
        {

            (new ConfigJson(server.Text, user.Text, password.Text, db.Text)).jsonWrite();
        }

        private void button_test_connection_Click(object sender, EventArgs e)
        {
           // string strConnect = "Data Source=" + server.Text + ";Initial Catalog='" + db.Text + "';User ID=" + user.Text + ";Password=" + password.Text;
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
