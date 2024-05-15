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

namespace RoutesTourists.Forms
{
    public partial class EditingForm : Form
    {
        public EditingForm()
        {
            InitializeComponent();
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            NameFiled.Text = CurrentUser.currentUser.Name;
            SurnameField.Text = CurrentUser.currentUser.Surname;
            NumberField.Text = CurrentUser.currentUser.Number;
            MaiLField.Text = CurrentUser.currentUser.Mail;
        }

        private void EditingButton_Click(object sender, EventArgs e)
        {
            if (NameFiled.Text == string.Empty)
            {
                MessageBox.Show("Поле для имени обязательно для заполнения");
                return;
            }
            if (SurnameField.Text == string.Empty)
            {
                MessageBox.Show("Поле для фамилии обязательно для заполения");
                return;
            }
            if (NumberField.Text == string.Empty)
            {
                MessageBox.Show("Поле для номера телефона обязательно для заполнения");
                return;
            }
            if (MaiLField.Text == string.Empty)
            {
                MessageBox.Show("Поле для почты обязательно для заполнения");
                return;
            }
            if (!Examination.CheckLetter(NameFiled.Text))
            {
                MessageBox.Show("Имя должно содержать только буквы");
                return;
            }
            if (!Examination.CheckLetter(SurnameField.Text))
            {
                MessageBox.Show("Фамилия должна содержать только буквы");
                return;
            }
            if (!Examination.CheckPhoneNumber(NumberField.Text))
            {
                MessageBox.Show("Некорректный номер телефона");
                return;
            }
            if (!Examination.CheckFormatMail(MaiLField.Text))
            {
                MessageBox.Show("Некорректный формат почты");
                return;
            }
            using (var context = new RoutesForTouristsContext())
            {
                var currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (currUser == null)
                {
                    MessageBox.Show("Ошибка в подключении к базе данных");
                    return;
                }
                currUser.Name = NameFiled.Text;
                currUser.Surname = SurnameField.Text;
                currUser.Number = NumberField.Text;
                currUser.Mail = MaiLField.Text;
                context.SaveChanges();
            }
        }

        private void EditingForm_Resize(object sender, EventArgs e)
        {
            NameLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + 27;
            NameLabel.Left = (int)(MainPanel.Width * 0.6) + 10;
            SurnameLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + 85;
            SurnameLabel.Left = (int)(MainPanel.Width * 0.6) - 30;
            SurnameField.Top = (int)((MainPanel.Height + 103) * 0.05) + 85;
            SurnameField.Left = (int)(MainPanel.Width * 0.65) + 50;
            SurnameField.Width = (int)((MainPanel.Width - 20) * 0.27);
            NumberLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + 150;
            NumberLabel.Left = (int)(MainPanel.Width * 0.6) - 25;
            NumberField.Top = (int)((MainPanel.Height + 103) * 0.05) + 150;
            NumberField.Left = (int)(MainPanel.Width * 0.65) + 50;
            NumberField.Width = (int)((MainPanel.Width - 20) * 0.27);
            MailLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + 220;
            MailLabel.Left = (int)(MainPanel.Width * 0.6) - 10;
        }
    }
}
