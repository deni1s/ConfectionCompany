using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public partial class MoneyForm : Form
    {
        const string Day = "День";
        const string Week = "Неделю";
        const string Month = "Месяц";

        public MoneyForm()
        {
            InitializeComponent();
            periodComboBox.Items.Add(Day);
            periodComboBox.Items.Add(Week);
            periodComboBox.Items.Add(Month);
            periodComboBox.SelectedIndex = 1;
        }

        private void GetMoneyByDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("CountMoneyByPeriod", conn)
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

                    command.Parameters.Add(userIdParameter);
                    command.Parameters.Add(enteredDateParameter);

                    using (SqlDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var money = rdr.GetSqlDecimal(0);
                            moneyLabel.Text = string.Format("{0} рублей", money.IsNull ? 0 : money);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
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
            GetMoneyByDates(startDate,endDate);

        }

        private void MoneyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
