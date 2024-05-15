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
            NameLabel.Top = (int)((MainPanel.Height + 103) * 0.04);
            NameLabel.Left = (int)(MainPanel.Width * 0.1);
            NameFiled.Top = (int)((MainPanel.Height + 103) * 0.04);
            NameFiled.Left = (int)(MainPanel.Width * 0.1) + NumberLabel.Left + 150;
            NameFiled.Width = (int)((MainPanel.Width - 20) * 0.4);
            SurnameLabel.Top = (int)((MainPanel.Height + 103) * 0.04) + NameFiled.Height + 25;
            SurnameLabel.Left = (int)(MainPanel.Width * 0.1);
            SurnameField.Top = (int)((MainPanel.Height + 103) * 0.04) + NameFiled.Height + 25;
            SurnameField.Left = (int)(MainPanel.Width * 0.1) + NumberLabel.Left + 150;
            SurnameField.Width = (int)((MainPanel.Width - 20) * 0.4);
            NumberLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + NameFiled.Height + SurnameField.Height + 45;
            NumberLabel.Left = (int)(MainPanel.Width * 0.1);
            NumberField.Top = (int)((MainPanel.Height + 103) * 0.05) + NameFiled.Height + SurnameField.Height + 45;
            NumberField.Left = (int)(MainPanel.Width * 0.1) + NumberLabel.Left + 150;
            NumberField.Width = (int)((MainPanel.Width - 20) * 0.4);
            MailLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + NameFiled.Height + SurnameField.Height + NumberField.Height + 65;
            MailLabel.Left = (int)(MainPanel.Width * 0.1);
            MaiLField.Top = (int)((MainPanel.Height + 103) * 0.05) + NameFiled.Height + SurnameField.Height + NumberField.Height + 65;
            MaiLField.Left = (int)(MainPanel.Width * 0.1) + NumberLabel.Left + 150;
            MaiLField.Width = (int)((MainPanel.Width - 20) * 0.4);

            EditingButton.Width = (int)((MainPanel.Width - 20) * 0.39);
            EditingButton.Height = (int)((MainPanel.Height + 103) * 0.115);
            EditingButton.Top = (int)((MainPanel.Height + 103) * 0.4) + NameFiled.Height + SurnameField.Height + NumberField.Height - 30;
            EditingButton.Left = (int)(MainPanel.Width * 0.3);
            BackButton.Width = (int)((MainPanel.Width - 20) * 0.3);
            BackButton.Height = (int)((MainPanel.Height + 103) * 0.075);
            BackButton.Top = (int)((MainPanel.Height + 103) * 0.4) + NameFiled.Height + SurnameField.Height + NumberField.Height + EditingButton.Height - 20;
            BackButton.Left = (int)(MainPanel.Width * 0.35);
        }
    }
}
