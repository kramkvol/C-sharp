using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Салон
{
    public partial class Мастер : Form
    {
        int userID = 0;

        public Мастер(int userID_)
        {
            InitializeComponent();
            userID = userID_;
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(userID);
            Hide();
            menu.ShowDialog();
        }

        private void button_расписание_Click(object sender, EventArgs e)
        {
            Мастер_расписание мастер_Расписание = new Мастер_расписание(userID);
            мастер_Расписание.ShowDialog();
        }

        private void Мастер_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.салон_красотыDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Мастер_представление". При необходимости она может быть перемещена или удалена.
            this.мастер_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Мастер_представление);


        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Мастер] SET[Статус] = 'не работает' WHERE ФИО = '" + comboBox_ФИО.Text + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    connection.Close();
                    this.Close();
                    Мастер мастер = new Мастер(userID);
                    мастер.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Мастер]([ФИО],[ID_Должность],[Статус]) VALUES ('" + textBox_ФИО_add.Text + "', " + comboBox_должность_add.SelectedValue.ToString() +  ", 'работает')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    connection.Open();
                    if (String.IsNullOrEmpty(textBox_ФИО_add.Text) == true && String.IsNullOrEmpty(comboBox_должность_add.Text) == true)
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    this.Close();
                    Мастер мастер = new Мастер(userID);
                    мастер.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (radioButton_ФИО_edit.Checked == true && String.IsNullOrEmpty(textBox_newФИО.Text) == false)
                    {
                        string sqlExpression1 = "UPDATE [Салон красоты].[dbo].[Мастер] SET [ФИО] = '" + textBox_newФИО.Text + "' WHERE ФИО = '" + comboBox_ФИО.Text + "'";
                        SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        reader1.Close();
                    }
                    else if (radioButton_должность_edit.Checked == true && String.IsNullOrEmpty(comboBox_newдолжность.Text) == false)
                    {
                        string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Мастер] SET [ID_Должность] = " + comboBox_newдолжность.SelectedValue.ToString() + "WHERE ФИО = '" + comboBox_ФИО.Text + "'";

                        SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        reader2.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    this.Close();
                    Мастер мастер = new Мастер(userID);
                    мастер.ShowDialog();

                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }
        private void button_filter_Click(object sender, EventArgs e)
        {
            if (radioButton_ФИО.Checked) { мастерпредставлениеBindingSource.Filter = "ФИО = '" + comboBox_ФИО_filter.Text + "'"; }
            if (radioButton_должность.Checked) { мастерпредставлениеBindingSource.Filter = "Должность = '" + comboBox_должность_filter.Text + "'"; }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            мастерпредставлениеBindingSource.Filter = "";
        }

        private void Мастер_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Olya\!4 курс !\БД\Салон\Салон\Help.chm");
        }
    }
}
