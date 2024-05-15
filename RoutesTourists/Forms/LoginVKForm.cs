using RoutesTourists.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace RoutesTourists.Forms
{
    public partial class LoginVKForm : Form
    {
        public LoginVKForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void phoneNumberField_Enter(object sender, EventArgs e)
        {
            if (phoneNumberField.Text.Equals("Введите номер телефона"))
            {
                phoneNumberField.Text = string.Empty;
                phoneNumberField.ForeColor = Color.Black;
            }
        }

        private void phoneNumberField_Leave(object sender, EventArgs e)
        {
            if (phoneNumberField.Text.Equals(string.Empty))
            {
                phoneNumberField.ForeColor = Color.Gray;
                phoneNumberField.Text = "Введите номер телефона";
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

        private void CodeConfirmationField_Enter(object sender, EventArgs e)
        {
            if (CodeConfirmationField.Text.Equals("Введите код"))
            {
                CodeConfirmationField.Text = string.Empty;
                CodeConfirmationField.ForeColor = Color.Black;
            }
        }

        private void CodeConfirmationField_Leave(object sender, EventArgs e)
        {
            if (CodeConfirmationField.Text.Equals(string.Empty))
            {
                CodeConfirmationField.ForeColor = Color.Gray;
                CodeConfirmationField.Text = "Введите код";
            }
        }

        private void LoginVKButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new RoutesForTouristsContext())
                {
                    try
                    {
                        if (phoneNumberField.Text == string.Empty || phoneNumberField.Text.Equals("Введите номер телефона"))
                        {
                            MessageBox.Show("Поле для телефона обязательно для заполнения");
                            return;
                        }
                        if (passwordField.Text == string.Empty || passwordField.Text.Equals("Введите пароль"))
                        {
                            MessageBox.Show("Поле для пароля обязательно для заполнения");
                            return;
                        }
                        if (!Examination.CheckPhoneNumber(phoneNumberField.Text))
                        {
                            MessageBox.Show("Некорректный номер телефона");
                            return;
                        }
                        ulong appId = 51923560;
                        var vkApi = new VkNet.VkApi();
                        vkApi.Authorize(new ApiAuthParams
                        {
                            ApplicationId = appId,
                            Login = phoneNumberField.Text,
                            Password = passwordField.Text,
                        });
                        string accessToken = vkApi.Token;
                        var user = vkApi.Users.Get(new long[] { vkApi.UserId.Value }, ProfileFields.PhotoMaxOrig).FirstOrDefault();
                        var currAccount = context.Accounts.FirstOrDefault(r => r.Login.Equals(phoneNumberField.Text) && r.Password.Equals(Hash.CalculateMD5Hash(passwordField.Text)));
                        if (currAccount == null)
                        {

                            string id = Guid.NewGuid().ToString();
                            string idUser = Guid.NewGuid().ToString();
                            string password = Hash.CalculateMD5Hash(passwordField.Text);

                            Account account = new Account();
                            account.Id = id;
                            account.Login = phoneNumberField.Text;
                            account.Password = password;

                            User currUser = new User();
                            currUser.IdUser = idUser;
                            currUser.Name = user.FirstName;
                            currUser.Surname = user.LastName;
                            currUser.Mail = "пусто";
                            currUser.IdAccount = id;
                            currUser.Number = phoneNumberField.Text;
                            WebClient wc = new WebClient();
                            byte[] photo = wc.DownloadData(user.PhotoMaxOrig.ToString());
                            currUser.Photo = photo;
                            context.Accounts.Add(account);
                            context.Users.Add(currUser);
                            context.SaveChanges();
                            CurrentUser.currentUser = currUser;
                            MessageBox.Show("Добавление пользователя прошло успешно");
                            this.Close();
                            HomeForm homeForm = new HomeForm();
                            homeForm.ShowDialog();
                        }
                        else
                        {
                            var currUser = context.Users.FirstOrDefault(r => r.IdAccount.Equals(currAccount.Id));
                            if (currUser == null)
                            {
                                MessageBox.Show("Ошибка в подключении к базе данных");
                                return;
                            }
                            CurrentUser.currentUser = currUser;
                            this.Close();
                            HomeForm homeForm = new HomeForm();
                            homeForm.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Неверный логил или пароль");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в подключении к базе данных");
                return;
            }
        }

        private void LoginVKForm_Resize(object sender, EventArgs e)
        {
            loginLabel.Top = (int)((MainPanel.Height + 103) * 0.04);
            loginLabel.Left = (int)(MainPanel.Width * 0.3);
            phoneNumberField.Top = (int)((MainPanel.Height + 103) * 0.04) + loginLabel.Height + 10;
            phoneNumberField.Left = (int)(MainPanel.Width * 0.3);
            phoneNumberField.Width = (int)(MainPanel.Width * 0.4);
            passwordLabel.Top = (int)((MainPanel.Height + 103) * 0.04) + loginLabel.Height + phoneNumberField.Height + 25;
            passwordLabel.Left = (int)(MainPanel.Width * 0.3);
            passwordField.Top = (int)((MainPanel.Height + 103) * 0.04) + loginLabel.Height + phoneNumberField.Height + passwordLabel.Height + 35;
            passwordField.Left = (int)(MainPanel.Width * 0.3);
            passwordField.Width = (int)(MainPanel.Width * 0.4);
            showCheckBox.Top = (int)((MainPanel.Height + 103) * 0.04) + loginLabel.Height + phoneNumberField.Height + passwordLabel.Height + passwordField.Height + 40;
            showCheckBox.Left = (int)(MainPanel.Width * 0.3);
            CodeConfirmationLabel.Top = (int)((MainPanel.Height + 103) * 0.04) + loginLabel.Height + phoneNumberField.Height + passwordLabel.Height + passwordField.Height + showCheckBox.Height + 55;
            CodeConfirmationLabel.Left = (int)(MainPanel.Width * 0.3);
            CodeConfirmationField.Top = (int)((MainPanel.Height + 103) * 0.04) + loginLabel.Height + phoneNumberField.Height + passwordLabel.Height + passwordField.Height + showCheckBox.Height + 70;
            CodeConfirmationField.Left = (int)(MainPanel.Width * 0.3);
            CodeConfirmationField.Width = (int)(MainPanel.Width * 0.4);

            LoginVKButton.Width = (int)((MainPanel.Width - 20) * 0.39);
            LoginVKButton.Height = (int)((MainPanel.Height + 103) * 0.115);
            LoginVKButton.Top = (int)((MainPanel.Height + 103) * 0.4) + phoneNumberField.Height + passwordField.Height + 30;
            LoginVKButton.Left = (int)(MainPanel.Width * 0.3);
            BackButton.Width = (int)((MainPanel.Width - 20) * 0.3);
            BackButton.Height = (int)((MainPanel.Height + 103) * 0.075);
            BackButton.Top = (int)((MainPanel.Height + 103) * 0.4) + LoginVKButton.Height + phoneNumberField.Height + passwordField.Height + 35;
            BackButton.Left = (int)(MainPanel.Width * 0.35);
        }

        private void LoginVKForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 575);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();  
            loginForm.ShowDialog();
        }
    }
}
