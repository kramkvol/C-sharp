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
    public partial class Услуги : Form
    {
        int userID = 0;
        public Услуги(int userID_)
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

        private void Услуги_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Направление". При необходимости она может быть перемещена или удалена.
            this.направлениеTableAdapter.Fill(this.салон_красотыDataSet.Направление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Услуга_представление". При необходимости она может быть перемещена или удалена.
            this.услуга_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Услуга_представление);

        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            if (radioButton_услуга.Checked) { услугапредставлениеBindingSource.Filter = "Услуга = '" + comboBox_услуга_filter.Text + "'"; }
            if (radioButton_направление.Checked) { услугапредставлениеBindingSource.Filter = "Направление = '" + comboBox_направление_filter.Text + "'"; }
            if (radioButton_длительность.Checked) { услугапредставлениеBindingSource.Filter = " Длительность >= " + textBox_длительностьОТ_filter.Text + " and Длительность <= " + textBox_длительностьДО_filter.Text; }
            if (radioButton_стоимость.Checked) { услугапредставлениеBindingSource.Filter = " Стоимость >= " + textBox_стоимостьОТ_filter.Text + " and Стоимость <= " + textBox_стоимостьДО_filter.Text; }
        }
        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            услугапредставлениеBindingSource.Filter = "";
        }


        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression1 = "SELECT * FROM [Салон красоты].[dbo].[Услуга] WHERE Название = '" + comboBox_услуга_del.Text + "'";
                string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Услуга] SET [Статус] = 'не актуально' WHERE Название = '" + comboBox_услуга_del.Text + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (!reader1.HasRows)
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    connection.Open();
                    SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    connection.Close();
                    Hide();
                    Услуги услуги = new Услуги(userID);
                    услуги.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
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
                    if (radioButton_newдлительность.Checked == true && String.IsNullOrEmpty(textBox_newдлительность_edit.Text) == false)
                    {
                        string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Услуга] SET [Длительность] =" + textBox_newдлительность_edit.Text + " WHERE Название = '" + comboBox_услуга_edit.Text + "'";
                        SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        reader2.Close();
                    }
                    else if (radioButton_newназвание.Checked == true && String.IsNullOrEmpty(textBox_newназвание_edit.Text) == false)
                    {
                        string sqlExpression3 = "UPDATE [Салон красоты].[dbo].[Услуга] SET [Название] = '" + textBox_newназвание_edit.Text + "' WHERE Название = '" + comboBox_услуга_edit.Text + "'";
                        SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                        SqlDataReader reader3 = command3.ExecuteReader();
                        reader3.Close();
                    }
                    else if (radioButton_newстоимость.Checked == true && String.IsNullOrEmpty(textBox_newстоимость_edit.Text) == false)
                    {
                        string sqlExpression4 = "UPDATE [Салон красоты].[dbo].[Услуга] SET [Стоимость] = " + textBox_newстоимость_edit.Text + " WHERE Название = '" + comboBox_услуга_edit.Text + "'";
                        SqlCommand command4 = new SqlCommand(sqlExpression4, connection);
                        SqlDataReader reader4 = command4.ExecuteReader();
                        reader4.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    Hide();
                    Услуги услуги = new Услуги(userID);
                    услуги.ShowDialog();
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
            string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
            string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Услуга]([ID_Направление],[Название],[Стоимость],[Длительность],[Статус])VALUES (" + comboBox_направление_add.SelectedValue.ToString() + ", '" + textBox_название_add.Text + "' ," + textBox_длительность_add.Text + "," + textBox_стоимость_add.Text + ", 'актуально')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    Hide();
                    Услуги услуги = new Услуги(userID);
                    услуги.ShowDialog();
                    connection.Close();
                }
                catch (Exception)
                {

                    label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                    label_ADD.Text = "Ошибка";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Olya\!4 курс !\БД\Салон\Салон\Help.chm");
        }

        private void Услуги_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
