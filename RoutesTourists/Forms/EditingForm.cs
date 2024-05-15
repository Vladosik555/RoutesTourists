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
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 575);
            NameFile.Text = CurrentUser.currentUser.Name;
            SurnameField.Text = CurrentUser.currentUser.Surname;
            NumberFiel.Text = CurrentUser.currentUser.Number;
            MaiLFiel.Text = CurrentUser.currentUser.Mail;
        }

        private void EditingForm_Resize(object sender, EventArgs e)
        {
            NameLabel.Top = (int)((MainPanel.Height + 103) * 0.04);
            NameLabel.Left = (int)(MainPanel.Width * 0.1);
            NameFile.Top = (int)((MainPanel.Height + 103) * 0.04);
            NameFile.Left = (int)(MainPanel.Width * 0.1) + NumberLabel.Left + 150;
            NameFile.Width = (int)((MainPanel.Width - 20) * 0.4);
            SurnameLabel.Top = (int)((MainPanel.Height + 103) * 0.04) + NameFile.Height + 25;
            SurnameLabel.Left = (int)(MainPanel.Width * 0.1);
            SurnameField.Top = (int)((MainPanel.Height + 103) * 0.04) + NameFile.Height + 25;
            SurnameField.Left = (int)(MainPanel.Width * 0.1) + NumberLabel.Left + 150;
            SurnameField.Width = (int)((MainPanel.Width - 20) * 0.4);
            NumberLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + NameFile.Height + SurnameField.Height + 45;
            NumberLabel.Left = (int)(MainPanel.Width * 0.1);
            NumberFiel.Top = (int)((MainPanel.Height + 103) * 0.05) + NameFile.Height + SurnameField.Height + 45;
            NumberFiel.Left = (int)(MainPanel.Width * 0.1) + NumberLabel.Left + 150;
            NumberFiel.Width = (int)((MainPanel.Width - 20) * 0.4);
            MailLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + NameFile.Height + SurnameField.Height + NumberFiel.Height + 65;
            MailLabel.Left = (int)(MainPanel.Width * 0.1);
            MaiLFiel.Top = (int)((MainPanel.Height + 103) * 0.05) + NameFile.Height + SurnameField.Height + NumberFiel.Height + 65;
            MaiLFiel.Left = (int)(MainPanel.Width * 0.1) + NumberLabel.Left + 150;
            MaiLFiel.Width = (int)((MainPanel.Width - 20) * 0.4);

            EditingButton.Width = (int)((MainPanel.Width - 20) * 0.39);
            EditingButton.Height = (int)((MainPanel.Height + 103) * 0.115);
            EditingButton.Top = (int)((MainPanel.Height + 103) * 0.4) + NameFile.Height + SurnameField.Height + NumberFiel.Height - 30;
            EditingButton.Left = (int)(MainPanel.Width * 0.3);
            BackButton.Width = (int)((MainPanel.Width - 20) * 0.3);
            BackButton.Height = (int)((MainPanel.Height + 103) * 0.075);
            BackButton.Top = (int)((MainPanel.Height + 103) * 0.4) + NameFile.Height + SurnameField.Height + NumberFiel.Height + EditingButton.Height - 20;
            BackButton.Left = (int)(MainPanel.Width * 0.35);
        }

        private void EditingButton_Click_1(object sender, EventArgs e)
        {
            //
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
