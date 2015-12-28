using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public class SessionSqlHandler
    {
        public static void InsertNewSession(int userId)//выполнение запроса на добавление сессии пользователя
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.GetConnectionString()))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("insert into [Sessions]([UserId],[EnterDate]) values(@userId,@enteredDate);", conn))
                    {
                        SqlParameter userIdParameter = new SqlParameter("@userId", SqlDbType.Int)
                        {
                            Value = userId
                        };

                        SqlParameter enteredDateParameter = new SqlParameter("@enteredDate", SqlDbType.DateTime)
                        {
                            Value = DateTime.Now
                        };

                        command.Parameters.Add(userIdParameter);
                        command.Parameters.Add(enteredDateParameter);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 
    }
}