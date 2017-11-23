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
    public partial class Autorization : Form
    {
        ConnectContext db;
        IEnumerable<User_access> user;
        public Autorization()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                if (user.Count() == 1)
                {
                    foreach (User_access u in user)
                    {
                       switch (u.type)
                        {
                            case "склад": new Storage(u).Show(); break;
                            case "продавец": new Seller(u).Show(); break;
                            case "администратор": break;

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с такими данными не зарегистрирован!");
                }

        }
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Configuration()).Show();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            try
            {
                db = new ConnectContext((new ConfigJson()).StringConnecting());
                user = db.User_access.Where(u => (u.login == login.Text && u.password == password.Text));
                user.ToList();
            }
            catch
            {

                MessageBox.Show("Проверьте настройки подключения к серверу БД");
                (new Configuration()).Show();

            }
        }
    }
}
