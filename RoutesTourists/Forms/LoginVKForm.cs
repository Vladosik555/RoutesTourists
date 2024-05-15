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
using VkNet.Enums.Filters;
using VkNet.Model;

namespace RoutesTourists.Forms
{
    public partial class LoginVKForm : Form
    {
        public LoginVKForm()
        {
            InitializeComponent();
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
                        var user = vkApi.Users.Get(new long[] { vkApi.UserId.Value }, ProfileFields.Photo50).FirstOrDefault();
                        var currAccount = context.Accounts.FirstOrDefault(r=>r.Login.Equals(phoneNumberField.Text) && r.Password.Equals(Hash.CalculateMD5Hash(passwordField.Text)));
                        if(currAccount == null)
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
                            currUser.Mail = null;
                            currUser.IdAccount = id;
                            currUser.Number = phoneNumberField.Text;
                            context.Accounts.Add(account);
                            context.Users.Add(currUser);
                            context.SaveChanges();
                            MessageBox.Show("Добавление пользователя прошло успешно");
                        }
                        else
                        {
                            var currUser = context.Users.FirstOrDefault(r => r.IdAccount.Equals(currAccount.Id));
                            if(currUser == null)
                            {
                                MessageBox.Show("Ошибка в подключении к базе данных");
                                return;
                            }
                            CurrentUser.currentUser = currUser;
                        }
                        this.Close();
                        HomeForm homeForm = new HomeForm();
                        homeForm.ShowDialog();
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
    }
}
