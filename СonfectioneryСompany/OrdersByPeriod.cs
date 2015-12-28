using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public partial class OrdersByPeriod : Form
    {
        const string Day = "День";
        const string Week = "Неделю";
        const string Month = "Месяц";

        public OrdersByPeriod()
        {
            InitializeComponent();
            periodComboBox.Items.Add(Day);
            periodComboBox.Items.Add(Week);
            periodComboBox.Items.Add(Month);
            periodComboBox.SelectedIndex = 1;
        }

        private void GetOrdersByDates(DateTime startDate, DateTime endDate, string orderName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("GetOrdersByPeriod ", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlParameter userIdParameter = new SqlParameter("@startDate", SqlDbType.DateTime)
                    {
                        Value = startDate
                    };

                    SqlParameter enteredDateParameter = new SqlParameter("@endDate", SqlDbType.DateTime)
                    {
                        Value = endDate
                    };

                    SqlParameter confectionName = new SqlParameter("@confectionName", SqlDbType.NVarChar)
                    {
                        Value = orderName
                    };

                    command.Parameters.Add(userIdParameter);
                    command.Parameters.Add(enteredDateParameter);
                    command.Parameters.Add(confectionName);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                    DataTable dtRecord = new DataTable();
                    sqlDataAdapter.Fill(dtRecord);
                    ordersDataGrid.DataSource = dtRecord;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string orderName = OrderName.Text;
            if (string.IsNullOrEmpty(orderName))
            {
                MessageBox.Show("Пустое название изделия!");
                return;
            }

            DateTime startDate;
            DateTime endDate;
            switch (periodComboBox.SelectedIndex)
            {
                case 0:
                    {
                        var now = DateTime.Today;
                        startDate = now.AddDays(-1);
                        endDate = now;
                        break;
                    }
                case 1:
                    {
                        var now = DateTime.Today;
                        startDate = now.AddDays(-7);
                        endDate = now;
                        break;
                    }
                case 2:
                    {
                        var now = DateTime.Today;
                        startDate = now.AddMonths(-1);
                        endDate = now;
                        break;
                    }
                default:
                    return;
            }
            GetOrdersByDates(startDate, endDate, orderName);
        }
    }
}
