using RoutesTourists.Classes;
using RoutesTourists.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RoutesTourists
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text.Equals("Введите логин"))
            {
                loginField.Text = string.Empty;
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text.Equals(string.Empty))
            {
                loginField.ForeColor = Color.Gray;
                loginField.Text = "Введите логин";
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals("Введите пароль"))
            {
                passwordField.Text = string.Empty;
                passwordField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals(string.Empty))
            {
                passwordField.ForeColor = Color.Gray;
                passwordField.Text = "Введите пароль";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                if (loginField.Text == string.Empty || loginField.Text.Equals("Введите логин"))
                {
                    MessageBox.Show("Поле для логина обязательно для заполнения");
                    return;
                }
                if (passwordField.Text == string.Empty || passwordField.Text.Equals("Введите пароль"))
                {
                    MessageBox.Show("Поле для пароля обязательно для заполнения");
                    return;
                }
                string password = Hash.CalculateMD5Hash(passwordField.Text);
                var account = context.Accounts.FirstOrDefault(r => r.Login.Equals(loginField.Text) && r.Password.Equals(password));
                if (account == null)
                {
                    MessageBox.Show("Вы ввели неверно логин или пароль");
                    return;
                }
                var user = context.Users.FirstOrDefault(r => r.IdAccount.Equals(account.Id));
                if (user == null)
                {
                    MessageBox.Show("Ошибка в подключении к базе данных");
                    return;
                }
                CurrentUser.currentUser = user;
                this.Hide();
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InitialForm initialForm = new InitialForm();
            initialForm.Show();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            loginLabel.Top = (int)((MainPanel.Height + 103) * 0.07);
            loginLabel.Left = (int)(MainPanel.Width * 0.3);
            loginField.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + 15;
            loginField.Left = (int)(MainPanel.Width * 0.3);
            loginField.Width = (int)(MainPanel.Width * 0.4);
            passwordLabel.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + loginField.Height + 30;
            passwordLabel.Left = (int)(MainPanel.Width * 0.3);
            passwordField.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + loginField.Height + passwordLabel.Height + 45;
            passwordField.Left = (int)(MainPanel.Width * 0.3);
            passwordField.Width = (int)(MainPanel.Width * 0.4);
            showCheckBox.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + loginField.Height + passwordLabel.Height + passwordField.Height  + 45;
            showCheckBox.Left = (int)(MainPanel.Width * 0.3);

            LoginButton.Width = (int)((MainPanel.Width - 20) * 0.39);
            LoginButton.Height = (int)((MainPanel.Height + 103) * 0.115);
            LoginButton.Top = (int)((MainPanel.Height + 103) * 0.4) + loginField.Height + passwordField.Height - 7;
            LoginButton.Left = (int)(MainPanel.Width * 0.3);
            BackButton.Width = (int)((MainPanel.Width - 20) * 0.3);
            BackButton.Height = (int)((MainPanel.Height + 103) * 0.075);
            BackButton.Top = (int)((MainPanel.Height + 103) * 0.4) + LoginButton.Height + loginField.Height + passwordField.Height - 2;
            BackButton.Left = (int)(MainPanel.Width * 0.35);
            LoginViaVKButton.Width = (int)((MainPanel.Width - 20) * 0.3);
            LoginViaVKButton.Height = (int)((MainPanel.Height + 103) * 0.075);
            LoginViaVKButton.Top = (int)((MainPanel.Height + 103) * 0.4) + LoginButton.Height + loginField.Height + passwordField.Height + BackButton.Height + 3;
            LoginViaVKButton.Left = (int)(MainPanel.Width * 0.35);


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 575);
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckBox.Checked)
            {
                passwordField.UseSystemPasswordChar = false;
            }
            else
            {
                passwordField.UseSystemPasswordChar = true;
            }
        }

        private void LoginViaVKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginVKForm loginVKForm = new LoginVKForm();
            loginVKForm.Show();
        }
    }
}
