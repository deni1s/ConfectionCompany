using System;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public partial class CompositionForm : Form
    {
        public CompositionForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectConfectionProductsTableAdapter.Update(confectioneryCompanyDataSet.SelectConfectionProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не удалось обновить Составы Продуктов!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            MessageBox.Show("Составы Продуктов обновлены!!");
        }

        private void CompositionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryCompanyDataSet.SelectConfectionProducts". При необходимости она может быть перемещена или удалена.
            this.selectConfectionProductsTableAdapter.Fill(this.confectioneryCompanyDataSet.SelectConfectionProducts);
        }

        private void compositionDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
