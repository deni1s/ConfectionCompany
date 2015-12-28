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
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryCompanyDataSet.SelectWarehouse". При необходимости она может быть перемещена или удалена.
            this.selectWarehouseTableAdapter.Fill(this.confectioneryCompanyDataSet.SelectWarehouse);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectWarehouseTableAdapter.Update(confectioneryCompanyDataSet.SelectWarehouse);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не удалось обновить Склад!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            MessageBox.Show("Склад обновлен!!");
        }
    }
}
