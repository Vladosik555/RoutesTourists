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
            NameFile.Text = CurrentUser.currentUser.Name;
            SurnameField.Text = CurrentUser.currentUser.Surname;
            NumberFiel.Text = CurrentUser.currentUser.Number;
            MaiLFiel.Text = CurrentUser.currentUser.Mail;
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
            NumberFiel.Top = (int)((MainPanel.Height + 103) * 0.05) + 150;
            NumberFiel.Left = (int)(MainPanel.Width * 0.65) + 50;
            NumberFiel.Width = (int)((MainPanel.Width - 20) * 0.27);
            MailLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + 220;
            MailLabel.Left = (int)(MainPanel.Width * 0.6) - 10;
        }

        private void EditingButton_Click_1(object sender, EventArgs e)
        {
            if (NameFile.Text == string.Empty)
            {
                MessageBox.Show("Поле для имени обязательно для заполнения");
                return;
            }
            if (SurnameField.Text == string.Empty)
            {
                MessageBox.Show("Поле для фамилии обязательно для заполения");
                return;
            }
            if (NumberFiel.Text == string.Empty)
            {
                MessageBox.Show("Поле для номера телефона обязательно для заполнения");
                return;
            }
            if (MaiLFiel.Text == string.Empty)
            {
                MessageBox.Show("Поле для почты обязательно для заполнения");
                return;
            }
            if (!Examination.CheckLetter(NameFile.Text))
            {
                MessageBox.Show("Имя должно содержать только буквы");
                return;
            }
            if (!Examination.CheckLetter(SurnameField.Text))
            {
                MessageBox.Show("Фамилия должна содержать только буквы");
                return;
            }
            if (!Examination.CheckPhoneNumber(NumberFiel.Text))
            {
                MessageBox.Show("Некорректный номер телефона");
                return;
            }
            if (!Examination.CheckFormatMail(MaiLFiel.Text))
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
                currUser.Name = NameFile.Text;
                currUser.Surname = SurnameField.Text;
                currUser.Number = NumberFiel.Text;
                currUser.Mail = MaiLFiel.Text;
                currUser.Number = NumberFiel.Text;
                CurrentUser.currentUser = currUser;
                context.SaveChanges();
                MessageBox.Show("Редактирование прошло успешно");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm homeForm = new HomeForm(); 
            homeForm.ShowDialog();
        }
    }
}
