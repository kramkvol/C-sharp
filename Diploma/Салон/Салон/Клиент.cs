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
    public partial class Клиент : Form
    {
        int userID = 0;

        public Клиент(int userID_)
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

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Клиент]([ФИО],[Номер телефона],[Процедур]) VALUES('" + textBox_ФИО_add.Text + "', '" + textBox_тел_add.Text + "', 0)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (String.IsNullOrEmpty(textBox_ФИО_add.Text) == true || String.IsNullOrEmpty(textBox_тел_add.Text) == true)
                    {
                        throw new Exception();
                    }
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    this.Close();
                    Hide();
                    Клиент клиент = new Клиент(userID);
                    клиент.ShowDialog();
                }
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
                string sqlExpression1 = "SELECT * FROM [Салон красоты].[dbo].[Клиент] WHERE ФИО = '" + comboBox_ФИО.Text + "'";
                string sqlExpression2 = "DELETE FROM [Салон красоты].[dbo].[Клиент] WHERE ФИО = '" + comboBox_ФИО.Text + "'";
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
                    reader2.Close();
                    connection.Close();
                    this.Close();
                    Hide();
                    Клиент клиент = new Клиент(userID);
                    клиент.ShowDialog();
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
                    if (radioButton_ФИО.Checked == true && String.IsNullOrEmpty(textBox_newФИО.Text) == false)
                    {
                        string sqlExpression2 = "UPDATE [Салон красоты].[dbo].[Клиент] SET [ФИО] = '" + textBox_newФИО.Text + "' WHERE ФИО = '" + comboBox_ФИО.Text + "'";
                        SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        reader2.Close();
                    }
                    else if (radioButton_тел.Checked == true && String.IsNullOrEmpty(textBox_newтел.Text) == false)
                    {
                        string sqlExpression3 = "UPDATE [Салон красоты].[dbo].[Клиент] SET [Номер телефона] = '" + textBox_newтел.Text + "' WHERE ФИО = '" + comboBox_ФИО.Text + "'";
                        SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                        SqlDataReader reader3 = command3.ExecuteReader();
                        reader3.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    this.Close();
                    Hide();
                    Клиент клиент = new Клиент(userID);
                    клиент.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }

        private void Клиент_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.салон_красотыDataSet.Клиент);

        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            клиентBindingSource.Filter = "ФИО = '" + comboBox_ФИО_filter.Text + "'";
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            клиентBindingSource.Filter = "";
        }

        private void Клиент_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Olya\!4 курс !\БД\Салон\Салон\Help.chm");
        }
    }
}
