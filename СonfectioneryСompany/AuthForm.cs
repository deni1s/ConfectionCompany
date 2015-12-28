using System;
using System.Windows.Forms;

namespace СonfectioneryСompany
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private bool ValidatePassword(string password, string value)
        {
            var valueHash = Sha1Util.Sha1HashStringForUtf8String(value);
            return valueHash == password;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //UserSqlHandler.InsertUser( "admin","admin" ); //чтобы вставить нового юзера

            var login = LoginTxtBox.Text;
            var password = PasswordTxtBox.Text;

            if(string.IsNullOrEmpty( login ) || string.IsNullOrEmpty( password ) )//если авторизационные данные пустые
            {
                MessageBox.Show("Авторизационные данные не могут быть пустыми!");
                return;
            }

            User user = UserSqlHandler.GetUserByLogin(login);
            if(user != null)
            {
                if(ValidatePassword( user.Password, password ))//если хэши паролей совпадают
                {
                    SessionSqlHandler.InsertNewSession( user.Id );
                    Hide();//скрываем форму логина
                    new MainForm().Show();//показываем основную форму
                }
                else
                {
                    MessageBox.Show("Не верный пароль!");
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден!!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
