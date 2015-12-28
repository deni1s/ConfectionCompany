using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public class UserSqlHandler
    {
        public static User GetUserByLogin(string login)//получение информации о пользователе с данными логином
        {
            User result = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.GetConnectionString()))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("select top 1 * from Users where [Login] = @login", conn))
                    {
                        SqlParameter loginParameter = new SqlParameter("@login", SqlDbType.NVarChar)
                        {
                            Value = login
                        };
                        command.Parameters.Add(loginParameter);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result = new User
                                {
                                    Id = reader.GetInt32(0),
                                    Login = reader.GetString(1),
                                    Password = reader.GetString(2)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return result;
        }

        public static void InsertNewUser(User user)//выполнение запроса на добавление пользователя из базы
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.GetConnectionString()))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("insert into [Users]([Login],[Password]) values(@login,@password)", conn))
                    {
                        SqlParameter loginParameter = new SqlParameter("@login", SqlDbType.NVarChar)
                        {
                            Value = user.Login
                        };

                        SqlParameter passwordParameter = new SqlParameter("@password", SqlDbType.NVarChar)
                        {
                            Value = user.Password
                        };

                        command.Parameters.Add(loginParameter);
                        command.Parameters.Add(passwordParameter);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void InsertUser(string login,string password)//добавить пользователя в базу
        {
            InsertNewUser(new User
            {
                Login = login,
                Password = Sha1Util.Sha1HashStringForUtf8String(password)
            });
        }
    }
}