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
    public partial class Запись : Form
    {
        int userID = 0;

        public Запись(int userID_)
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


        private void Запись_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Представление_для_добавления_записи". При необходимости она может быть перемещена или удалена.
            this.представление_для_добавления_записиTableAdapter.Fill(this.салон_красотыDataSet.Представление_для_добавления_записи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Мастер_представление". При необходимости она может быть перемещена или удалена.
            this.мастер_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Мастер_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.салон_красотыDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Услуга_представление". При необходимости она может быть перемещена или удалена.
            this.услуга_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Услуга_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Запись_представление". При необходимости она может быть перемещена или удалена.
            this.запись_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Запись_представление);

        }
        private void Запись_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            if (radioButton_дата.Checked) { записьпредставлениеBindingSource.Filter = "Дата = '" + dateTimePicker_дата.Value.Year.ToString() + "-" + dateTimePicker_дата.Value.Month.ToString() + "-" + dateTimePicker_дата.Value.Day.ToString() + "'"; }
            if (radioButton_клиент_ФИО.Checked) { записьпредставлениеBindingSource.Filter = "[Клиент ФИО] = '" + comboBox_клиент_ФИО.Text + "'"; }
            if (radioButton_мастер_ФИО.Checked) { записьпредставлениеBindingSource.Filter = "[Мастер ФИО] = '" + comboBox_мастер_ФИО.Text + "'"; }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            записьпредставлениеBindingSource.Filter = "";
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "UPDATE [Салон красоты].[dbo].[Запись] SET [ID_Услуга] =" + comboBox_услуга_edit.SelectedValue.ToString() + " WHERE  ID_Клиент = " + combobox_ФИО_fill.SelectedValue.ToString() + " and " +
                    "Дата = '" + dateTimePicker_дата_fill.Value.Year.ToString() + "-" + dateTimePicker_дата_fill.Value.Month.ToString() + "-" + dateTimePicker_дата_fill.Value.Day.ToString() + "' and Начало = '" + textBox_начало_fill.Text + "'";
                string sqlExpression1 = "UPDATE [Салон красоты].[dbo].[Запись] SET [ID_Услуга] = " + comboBox_услуга_edit.SelectedValue.ToString() + " WHERE ID = " + comboBox_ID_записи_edit.Text;
                string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Запись] SET [Начало] = '" + textBox_начало_edit.Text + "' WHERE ID_Клиент = " + combobox_ФИО_fill.SelectedValue.ToString() + " and " +
                    "Дата = '" + dateTimePicker_дата_fill.Value.Year.ToString() + "-" + dateTimePicker_дата_fill.Value.Month.ToString() + "-" + dateTimePicker_дата_fill.Value.Day.ToString() + "' and Начало = '" + textBox_начало_fill.Text + "'";
                string sqlExpression3 = "UPDATE [Салон красоты].[dbo].[Запись] SET [Начало] = '" + textBox_начало_edit.Text + "' WHERE ID = " + comboBox_ID_записи_edit.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (radioButton_edit1.Checked == true && radioButton_услуга_edit.Checked == true && String.IsNullOrEmpty(comboBox_услуга_edit.Text) == false)
                    {
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    else if (radioButton_edit2.Checked == true && radioButton_услуга_edit.Checked == true && String.IsNullOrEmpty(comboBox_услуга_edit.Text) == false)
                    {
                        SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        reader1.Close();
                    }
                    else if (radioButton_edit1.Checked == true && radioButton_начало_edit.Checked == true && String.IsNullOrEmpty(textBox_начало_edit.Text) == false)
                    {
                        SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        reader2.Close();
                    }
                    else if (radioButton_edit2.Checked == true && radioButton_начало_edit.Checked == true && String.IsNullOrEmpty(textBox_начало_edit.Text) == false)
                    {
                        SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                        SqlDataReader reader3 = command3.ExecuteReader();
                        reader3.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    Hide();
                    Запись запись = new Запись(userID);
                    запись.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (String.IsNullOrEmpty(textBox_начало_add.Text))
                    {
                        throw new Exception();
                    }
                    else
                    {
                        connection.Open();
                    string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Запись]([ID_Расписание] ,[ID_Услуга],[ID_Клиент],[Дата],[Начало],[Статус])VALUES(" + comboBox_расписание_add.SelectedValue.ToString() + ", " + comboBox_услуга_add.SelectedValue.ToString() + ", " + comboBox_клиент_ФИО.SelectedValue.ToString() + ", '" + dateTimePicker_дата_add.Value.Year.ToString() + "-" + dateTimePicker_дата_add.Value.Month.ToString() + "-" + dateTimePicker_дата_add.Value.Day.ToString() + "', '" + textBox_начало_add.Text + "', 'не готово')";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    }
                }
                Hide();
                Запись запись = new Запись(userID);
                запись.ShowDialog();

            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
        }


        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "DELETE FROM [Салон красоты].[dbo].[Запись] WHERE ID = " + comboBox_ID_записи_edit.Text;
                string sqlExpression1 = "DELETE FROM [Салон красоты].[dbo].[Запись] WHERE ID_Клиент = " + combobox_ФИО_fill.SelectedValue.ToString() + " and " +
                    "Дата = '" + dateTimePicker_дата_fill.Value.Year.ToString() + "-" + dateTimePicker_дата_fill.Value.Month.ToString() + "-" + dateTimePicker_дата_fill.Value.Day.ToString() + "' and Начало = '" + textBox_начало_fill.Text + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (radioButton_edit1.Checked == true)
                    {
                        SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        reader1.Close();
                    }
                    else if (radioButton_edit2.Checked == true)
                    {
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    Hide();
                    Запись запись = new Запись(userID);
                    запись.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Olya\!4 курс !\БД\Салон\Салон\Help.chm");
        }
    }
}

