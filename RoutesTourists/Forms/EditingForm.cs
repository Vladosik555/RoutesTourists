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
            if(NameFiled.Text == string.Empty)
            {
                MessageBox.Show("Поле для имени обязательно для заполнения");
                return;
            }
            if(SurnameField.Text == string.Empty)
            {
                MessageBox.Show("Поле для фамилии обязательно для заполения");
                return;
            }
            if (NumberField.Text == string.Empty)
            {
                MessageBox.Show("Поле для номера телефона обязательно для заполнения");
                return;
            }
            if(MaiLField.Text == string.Empty)
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
    }
}
