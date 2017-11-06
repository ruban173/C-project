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
using ClientSystem.Models;


namespace ClientSystem.Forms
{
    public partial class Autorization : Form
    {

        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (ConnectContext db = new ConnectContext((new ConfigJson()).StringConnecting()))
            {
                List<Employees> y = db.UserAccess.SelectMany(c => c.Employees).ToList();
                foreach (Employees item in y)
                {
                    MessageBox.Show(item.first_name);
                }

                IEnumerable<UserAccess> user = db.UserAccess.Where(u => (u.login == login.Text && u.password == password.Text));
                user.ToList();

                if (user.Count() == 1)
                {
                    foreach (UserAccess u in user)
                    {
                        MessageBox.Show(u.type);
                        switch (u.type)
                        {
                            case "склад": new Storage().Show(); break;
                            case "продавец": new Seller().Show(); break;
                            case "администратор": break;

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с такими данными не зарегистрирован!");
                }

            }
        }

    }
}
