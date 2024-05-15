using RoutesTourists.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutesTourists
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text.Equals("Введите логин"))
            {
                LoginField.Text = string.Empty;
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text.Equals(string.Empty))
            {
                LoginField.ForeColor = Color.Gray;
                LoginField.Text = "Введите логин";
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

        private void password2Field_Enter(object sender, EventArgs e)
        {
            if (password2Field.Text.Equals("Повторите пароль"))
            {
                password2Field.Text = string.Empty;
                password2Field.ForeColor = Color.Black;
            }
        }

        private void password2Field_Leave(object sender, EventArgs e)
        {
            if (password2Field.Text.Equals(string.Empty))
            {
                password2Field.ForeColor = Color.Gray;
                password2Field.Text = "Повторите пароль";
            }
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text.Equals("Введите имя"))
            {
                NameField.Text = string.Empty;
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text.Equals(string.Empty))
            {
                NameField.ForeColor = Color.Gray;
                NameField.Text = "Введите имя";
            }
        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text.Equals("Введите фамилию"))
            {
                SurnameField.Text = string.Empty;
                SurnameField.ForeColor = Color.Black;
            }
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (SurnameField.Text.Equals(string.Empty))
            {
                SurnameField.ForeColor = Color.Gray;
                SurnameField.Text = "Введите фамилию";
            }
        }

        private void MailField_Enter(object sender, EventArgs e)
        {
            if (MailField.Text.Equals("Введите почту"))
            {
                MailField.Text = string.Empty;
                MailField.ForeColor = Color.Black;
            }
        }

        private void MailField_Leave(object sender, EventArgs e)
        {
            if (MailField.Text.Equals(string.Empty))
            {
                MailField.ForeColor = Color.Gray;
                MailField.Text = "Введите почту";
            }
        }

        private void NumberField_Enter(object sender, EventArgs e)
        {
            if (NumberField.Text.Equals("Введите номер телефона"))
            {
                NumberField.Text = string.Empty;
                NumberField.ForeColor = Color.Black;
            }
        }

        private void NumberField_Leave(object sender, EventArgs e)
        {
            if (NumberField.Text.Equals(string.Empty))
            {
                NumberField.ForeColor = Color.Gray;
                NumberField.Text = "Введите номер телефона";
            }
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == string.Empty || LoginField.Text.Equals("Введите логин"))
            {
                MessageBox.Show("Поле для логина обязательно для заполнения");
                return;
            }
            if (passwordField.Text == string.Empty || passwordField.Text.Equals("Введите пароль"))
            {
                MessageBox.Show("Поле для пароль обязательно для заполнения");
                return;
            }
            if (password2Field.Text == string.Empty || passwordField.Text.Equals("Повторите пароль"))
            {
                MessageBox.Show("Поле для повторного пароля обязательно для заполения");
                return;
            }
            if (NameField.Text == string.Empty || NameField.Text.Equals("Введите имя"))
            {
                MessageBox.Show("Поле для имени обязательно для заполнения");
                return;
            }
            if (SurnameField.Text == string.Empty || SurnameField.Text.Equals("Введите фамилию"))
            {
                MessageBox.Show("Поле для пароля обязательно для заполнения");
                return;
            }
            if (MailField.Text == string.Empty || MailField.Text.Equals("Введите почту"))
            {
                MessageBox.Show("Поле для почты обязательно для заполнения");
                return;
            }
            if(NumberField.Text == string.Empty || NumberField.Text.Equals("Введите номер телефона"))
            {
                MessageBox.Show("Поле для телефона обязательно для заполнения");
                return;
            }
            if (!passwordField.Text.Equals(password2Field.Text))
            {
                MessageBox.Show("Пароли должны совпадать");
                return;
            }
            if (!Examination.CheckLetter(NameField.Text))
            {
                MessageBox.Show("Имя должно содержать только буквы");
                return;
            }
            if (!Examination.CheckLetter(SurnameField.Text))
            {
                MessageBox.Show("Фамилия должно содержать только буквы");
                return;
            }
            if (!Examination.CheckFormatMail(MailField.Text))
            {
                MessageBox.Show("Некорректный формат почты");
                return;
            }
            if (!Examination.CheckPhoneNumber(NumberField.Text))
            {
                MessageBox.Show("Некорректный номер телефона");
                return;
            }
            using (var context = new RoutesForTouristsContext())
            {
                string id = Guid.NewGuid().ToString();
                string idUser = Guid.NewGuid().ToString();
                string password = Hash.CalculateMD5Hash(passwordField.Text);

                Account account = new Account();
                account.Id = id;
                account.Login = LoginField.Text;
                account.Password = password;

                User user = new User();
                user.IdUser = idUser;
                user.Name = NameField.Text;
                user.Surname = SurnameField.Text;
                user.Mail = MailField.Text;
                user.IdAccount = id;
                user.Number = NumberField.Text;
                context.Accounts.Add(account);
                context.Users.Add(user);
                context.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно");
                this.Hide();
                InitialForm initialForm = new InitialForm();
                initialForm.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InitialForm initialForm = new InitialForm();
            initialForm.Show();
        }

        private void RegistrForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 575);
        }

        private void RegistrForm_Resize(object sender, EventArgs e)
        {

            loginLabel.Top = (int)((MainPanel.Height + 103) * 0.07);
            loginLabel.Left = (int)(MainPanel.Width * 0.06);
            LoginField.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + 3;
            LoginField.Left = (int)(MainPanel.Width * 0.06);
            LoginField.Width = (int)(MainPanel.Width * 0.4);
            passwordLabel.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + LoginField.Height + 30;
            passwordLabel.Left = (int)(MainPanel.Width * 0.06);
            passwordField.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + LoginField.Height + passwordLabel.Height + 31;
            passwordField.Left = (int)(MainPanel.Width * 0.06);
            passwordField.Width = (int)(MainPanel.Width * 0.4);
            passwordLabel2.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + LoginField.Height + passwordLabel.Height + passwordField.Height + 55;
            passwordLabel2.Left = (int)(MainPanel.Width * 0.06);
            password2Field.Top = (int)((MainPanel.Height + 103) * 0.07) + loginLabel.Height + LoginField.Height + passwordLabel.Height + passwordLabel2.Height + 95;
            password2Field.Left = (int)(MainPanel.Width * 0.06);
            password2Field.Width = (int)(MainPanel.Width * 0.4);

            nameLabel.Top = (int)((MainPanel.Height + 103) * 0.01);
            nameLabel.Left = (int)(MainPanel.Width * 0.535);
            NameField.Top = (int)((MainPanel.Height + 103) * 0.01) + nameLabel.Height + 3;
            NameField.Left = (int)(MainPanel.Width * 0.535);
            NameField.Width = (int)(MainPanel.Width * 0.4);
            surnameLabel.Top = (int)((MainPanel.Height + 103) * 0.01) + nameLabel.Height + NameField.Height + 15;
            surnameLabel.Left = (int)(MainPanel.Width * 0.535);
            SurnameField.Top = (int)((MainPanel.Height + 103) * 0.01) + nameLabel.Height + NameField.Height + surnameLabel.Height + 16;
            SurnameField.Left = (int)(MainPanel.Width * 0.535);
            SurnameField.Width = (int)(MainPanel.Width * 0.4);
            MailLabel.Top = (int)((MainPanel.Height + 103) * 0.01) + nameLabel.Height + NameField.Height + surnameLabel.Height + SurnameField.Height + 30;
            MailLabel.Left = (int)(MainPanel.Width * 0.535);
            MailField.Top = (int)((MainPanel.Height + 103) * 0.01) + nameLabel.Height + NameField.Height + surnameLabel.Height + MailLabel.Height + 70;
            MailField.Left = (int)(MainPanel.Width * 0.535);
            MailField.Width = (int)(MainPanel.Width * 0.4);
            NumberLabel.Top = (int)((MainPanel.Height + 103) * 0.01) + nameLabel.Height + NameField.Height + surnameLabel.Height + SurnameField.Height + MailLabel.Height + MailField.Height + 40;
            NumberLabel.Left = (int)(MainPanel.Width * 0.535);
            NumberField.Top = (int)((MainPanel.Height + 103) * 0.01) + nameLabel.Height + NameField.Height + surnameLabel.Height + MailLabel.Height + MailLabel.Height + MailField.Height + 80;
            NumberField.Left = (int)(MainPanel.Width * 0.535);
            NumberField.Width = (int)(MainPanel.Width * 0.4);


            RegistrButton.Width = (int)((MainPanel.Width - 20) * 0.39);
            RegistrButton.Height = (int)((MainPanel.Height + 103) * 0.115);
            RegistrButton.Top = (int)((MainPanel.Height + 103) * 0.6) + 10;
            RegistrButton.Left = (int)(MainPanel.Width * 0.3);
            BackButton.Width = (int)((MainPanel.Width - 20) * 0.3);
            BackButton.Height = (int)((MainPanel.Height + 103) * 0.075);
            BackButton.Top = (int)((MainPanel.Height + 103) * 0.6) + RegistrButton.Height + 15;
            BackButton.Left = (int)(MainPanel.Width * 0.35);
        }
    }
}