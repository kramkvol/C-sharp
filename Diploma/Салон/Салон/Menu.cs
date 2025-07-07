using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Салон
{
    public partial class Menu : Form
    {
        int userID = 0;
        public Menu(int userID_)
        {
            InitializeComponent();
            userID = userID_;
        }

        private void button_клиент_Click(object sender, EventArgs e)
        {
            Клиент клиент = new Клиент(userID);
            Hide();
            клиент.ShowDialog();
        }

        private void button_чек_Click(object sender, EventArgs e)
        {
            Чек чек  = new Чек(userID);
            Hide();
            чек.ShowDialog();
        }

        private void button_услуги_Click(object sender, EventArgs e)
        {
            Услуги услуги = new Услуги(userID);
            Hide();
            услуги.ShowDialog();
        }
        private void button_мастер_Click(object sender, EventArgs e)
        {
            Мастер мастер = new Мастер(userID);
            Hide();
            мастер.ShowDialog();
        }

        private void button_запись_Click(object sender, EventArgs e)
        {
            Запись запись = new Запись(userID);
            Hide();
            запись.ShowDialog();
        }

        private void button_расписание_Click(object sender, EventArgs e)
        {
            Мастер_расписание мастер_Расписание = new Мастер_расписание(userID);
            Hide();
            мастер_Расписание.ShowDialog();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_отчет_услуги_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"D:\Olya\!4 курс !\БД\Салон\Салон\Отчет по оказанным услугам.rdl");

        }

        private void linkLabel_отчет_прибыль_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"D:\Olya\!4 курс !\БД\Салон\Салон\Отчет по прибыли салона.rdl");
        }

        private void linkLabel_отчет_мастера_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"D:\Olya\!4 курс !\БД\Салон\Салон\Отчет по работе мастеров.rdl");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Olya\!4 курс !\БД\Салон\Салон\Help.chm");
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
