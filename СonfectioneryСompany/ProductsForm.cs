using System;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                productsTableAdapter.Update(confectioneryCompanyDataSet.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не удалось обновить Продукты!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            MessageBox.Show("Продукты обновлены!!");
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryCompanyDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.confectioneryCompanyDataSet.Products);

        }
    }
}
