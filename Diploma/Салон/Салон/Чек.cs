using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Салон
{
    public partial class Чек : Form
    {
        int userID = 0;
        public Чек(int userID_)
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

        private void Чек_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Мастер_представление". При необходимости она может быть перемещена или удалена.
            this.мастер_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Мастер_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.салон_красотыDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Мастер". При необходимости она может быть перемещена или удалена.
            this.мастерTableAdapter.Fill(this.салон_красотыDataSet.Мастер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Услуга_представление". При необходимости она может быть перемещена или удалена.
            this.услуга_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Услуга_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Запись_представление". При необходимости она может быть перемещена или удалена.
            this.запись_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Запись_представление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "салон_красотыDataSet.Чек_представление". При необходимости она может быть перемещена или удалена.
            this.чек_представлениеTableAdapter.Fill(this.салон_красотыDataSet.Чек_представление);

        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "INSERT INTO [Салон красоты].[dbo].[Чек] VALUES (GETDATE(), 0, 0, " + textBox_наличными_Add.Text + ", 0, " + comboBox_ID_Записи_add.Text + ", 1, 1, 1, 2)";
                string sqlExpression1 = "INSERT INTO [Салон красоты].[dbo].[Чек] VALUES (GETDATE(), 0, 0, " + textBox_наличными_Add.Text + ", 0, null, " + comboBox_МастерФИО_add.SelectedValue.ToString() + ", " + сomboBox_услуга_add.SelectedValue.ToString() + ", " + comboBox_КлиентФИО_add.SelectedValue.ToString() + ", " + userID +")";
                string sqlExpression2 = "UPDATE[Салон красоты].[dbo].[Запись] SET[Статус] = 'готово' WHERE ID = " + comboBox_ID_Записи_add.Text.ToString();
                string sqlExpression3 = "UPDATE[Салон красоты].[dbo].[Мастер] SET[Процедур] = Процедур+1 WHERE ID = " + comboBox_МастерФИО_add.SelectedValue.ToString();
                string sqlExpression4 = "UPDATE[Салон красоты].[dbo].[Клиент] SET[Процедур] = Процедур+1 WHERE ID = " + comboBox_КлиентФИО_add.SelectedValue.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (radioButton_add1.Checked == true)
                    {
                        SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        reader1.Close();
                        connection.Close();
                    }
                    else if (radioButton_add2.Checked == true)
                    {
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();

                        SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        reader2.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    connection.Close();
                    connection.Open();
                    SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                    SqlDataReader reader3 = command3.ExecuteReader();
                    reader3.Close();
                    connection.Close();
                    connection.Open();
                    SqlCommand command4 = new SqlCommand(sqlExpression4, connection);
                    SqlDataReader reader4 = command4.ExecuteReader();
                    reader4.Close();
                    connection.Close();
                    Hide();
                    Чек чек = new Чек(userID);
                    чек.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Салон красоты;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression1 = "UPDATE[Салон красоты].[dbo].[Запись] SET [Статус]  = 'не готово' FROM dbo.Чек INNER JOIN dbo.Запись ON dbo.Чек.ID_Запись = dbo.Запись.ID WHERE Чек.ID = " + comboBox_ID_Чека_del.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    reader1.Close();
                    connection.Close();
                    connection.Open();
                    string sqlExpression3 = "UPDATE Мастер SET Процедур = Процедур-1 FROM   Чек INNER JOIN Мастер ON Чек.ID_Мастер = dbo.Мастер.ID WHERE Мастер.ID = (SELECT Чек.ID_Мастер WHERE Чек.ID =" + comboBox_ID_Чека_del.Text  + " )";
                    SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                    SqlDataReader reader3 = command3.ExecuteReader();
                    reader3.Close();
                    connection.Close();
                    connection.Open();
                    string sqlExpression4 = "UPDATE Клиент SET Процедур = Процедур-1 FROM Чек INNER JOIN Клиент ON Чек.ID_Клиент = dbo.Клиент.ID WHERE Клиент.ID = (SELECT Чек.ID_Клиент WHERE Чек.ID =" + comboBox_ID_Чека_del.Text  + " )";
                    SqlCommand command4 = new SqlCommand(sqlExpression4, connection);
                    SqlDataReader reader4 = command4.ExecuteReader();
                    reader4.Close();
                    connection.Close();
                    connection.Open();
                    string sqlExpression2 = "DELETE FROM [Салон красоты].[dbo].[Чек] WHERE ID = " + comboBox_ID_Чека_del.SelectedValue.ToString();
                    SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    reader2.Close();
                    connection.Close();
                    Hide();
                    Чек чек = new Чек(userID);
                    чек.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
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
                    if (String.IsNullOrEmpty(textBox_наличными_edit.Text) == true | String.IsNullOrEmpty(comboBox_Id_чека_edit.Text) == true)
                    {
                        throw new Exception();
                    }
                    string sqlExpression = "UPDATE [Салон красоты].[dbo].[Чек] SET [Наличными] = " + textBox_наличными_edit.Text + " WHERE ID = " + comboBox_Id_чека_edit.SelectedValue.ToString();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    Hide();
                    Чек чек = new Чек(userID);
                    чек.ShowDialog();
                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
            }
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            if (radioButton_наличными_filter.Checked) { чекпредставлениеBindingSource.Filter = "Наличными = '" + textBox_наличными_filer.Text + "'"; }
            if (radioButton_мастер_filter.Checked) { чекпредставлениеBindingSource.Filter = "[Мастер]= '" + comboBox_мастер_fiter.Text + "'"; }
        }

        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            чекпредставлениеBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Печать_чека печать_Чека = new Печать_чека(userID);
            печать_Чека.ShowDialog();
        }

        private void Чек_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

                