using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectOrdersTableAdapter.Update(confectioneryCompanyDataSet.SelectOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не удалось обновить Заказ!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            MessageBox.Show("Заказы обновлены!!");
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryCompanyDataSet.SelectOrders". При необходимости она может быть перемещена или удалена.
            this.selectOrdersTableAdapter.Fill(this.confectioneryCompanyDataSet.SelectOrders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryCompanyDataSet.SelectOrders". При необходимости она может быть перемещена или удалена.
            this.selectOrdersTableAdapter.Fill(this.confectioneryCompanyDataSet.SelectOrders);
        }
    }
}
