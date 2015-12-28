using System;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void confectionsButton_Click(object sender, EventArgs e)
        {
            new ConfectionsForm().Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            new OrdersForm().Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            new ProductsForm().Show();
        }

        private void ConfectionsProductsButton_Click(object sender, EventArgs e)
        {
            new CompositionForm().Show();
        }

        private void moneyButton_Click(object sender, EventArgs e)
        {
            new MoneyForm().Show();
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            new WarehouseForm().Show();
        }

        private void OrdersByPeriodBut_Click(object sender, EventArgs e)
        {
            new OrdersByPeriod().Show();
        }
    }
}
