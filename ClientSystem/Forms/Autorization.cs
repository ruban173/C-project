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
    public partial class Autorization : Form
    {
        ConnectContext db;
        IEnumerable<User_access> user;
        public Autorization()
        {
            InitializeComponent();
             db = new ConnectContext((new ConfigJson()).StringConnecting());
            user = db.User_access.Where(u => (u.login == login.Text && u.password == password.Text));
            user.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                if (user.Count() == 1)
                {
                    foreach (User_access u in user)
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

        private void Autorization_Load(object sender, EventArgs e)
        {

        }
    }
}
