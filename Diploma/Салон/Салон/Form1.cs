using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Салон
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Салон_красотыDataSet.Отчет_по_оказанным_услугам". При необходимости она может быть перемещена или удалена.
            this.Отчет_по_оказанным_услугамTableAdapter.Fill(this.Салон_красотыDataSet.Отчет_по_оказанным_услугам);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Салон_красотыDataSet.Запись_представление". При необходимости она может быть перемещена или удалена.
            this.Запись_представлениеTableAdapter.Fill(this.Салон_красотыDataSet.Запись_представление);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
