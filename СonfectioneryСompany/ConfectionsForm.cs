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
    public partial class ConfectionsForm : Form
    {
        public ConfectionsForm()
        {
            InitializeComponent();
        }

        private void ConfectionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryCompanyDataSet.Confections". При необходимости она может быть перемещена или удалена.
            this.confectionsTableAdapter.Fill(this.confectioneryCompanyDataSet.Confections);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                confectionsTableAdapter.Update(confectioneryCompanyDataSet.Confections);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не удалось обновить Изделия!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            MessageBox.Show("Изделия обновлены!!");
        }
    }
}
