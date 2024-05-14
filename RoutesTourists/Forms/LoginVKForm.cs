using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Enums.Filters;using VkNet.Model;

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
            MessageBox.Show(user.FirstName);
            MessageBox.Show(user.LastName);
        }
    }
}
