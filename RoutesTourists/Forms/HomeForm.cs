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

namespace RoutesTourists
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RecommenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecommenForm recommenForm = new RecommenForm();
            recommenForm.ShowDialog();
        }

        private void CharacteristicsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharacteristicsForm characteristicsForm = new CharacteristicsForm();
            characteristicsForm.ShowDialog();
        }

        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FavoritesForm favoritesForm = new FavoritesForm();
            favoritesForm.ShowDialog();
        }

        private void MySelectedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyCollectionsForm myCollectionsForm = new MyCollectionsForm();
            myCollectionsForm.ShowDialog();
        }

        private void HomeForm_Resize(object sender, EventArgs e)
        {
            label2.Left = (int)(MainPanel.Width * 0.28);
            label2.Height = MainPanel.Height;

            RecommenButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            RecommenButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            RecommenButton.Top = (int)((MainPanel.Height + 103) * 0.05);
            RecommenButton.Left = (int)(MainPanel.Width * 0.015);
            FavoritesButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            FavoritesButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            FavoritesButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 27;
            FavoritesButton.Left = (int)(MainPanel.Width * 0.015);
            CharacteristicsButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            CharacteristicsButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            CharacteristicsButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + 55;
            CharacteristicsButton.Left = (int)(MainPanel.Width * 0.015);
            SelectionsButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            SelectionsButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            SelectionsButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + CharacteristicsButton.Height + 85;
            SelectionsButton.Left = (int)(MainPanel.Width * 0.015);
            MySelectedButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            MySelectedButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            MySelectedButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + CharacteristicsButton.Height + SelectionsButton.Height + 115;
            MySelectedButton.Left = (int)(MainPanel.Width * 0.015);
            ExitAccountButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            ExitAccountButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            ExitAccountButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + CharacteristicsButton.Height + SelectionsButton.Height + MySelectedButton.Height + 145;
            ExitAccountButton.Left = (int)(MainPanel.Width * 0.015);

            LoginLabel.Top = (int)((MainPanel.Height + 103) * 0.06);
            LoginLabel.Left = (int)(MainPanel.Width * 0.33);
            ChangeButton.Width = (int)((MainPanel.Width - 20) * 0.17);
            ChangeButton.Height = (int)((MainPanel.Height + 103) * 0.05);
            ChangeButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + CharacteristicsButton.Height + 93;
            ChangeButton.Left = (int)(MainPanel.Width * 0.33);
            EditButton.Width = (int)((MainPanel.Width - 20) * 0.27);
            EditButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            EditButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + CharacteristicsButton.Height + SelectionsButton.Height + MySelectedButton.Height + 145;
            EditButton.Left = (int)(MainPanel.Width * 0.7);
            pictureProfile.Width = (int)((MainPanel.Width - 20) * 0.15);
            pictureProfile.Height = (int)((MainPanel.Height + 103) * 0.15);
            pictureProfile.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 27;
            pictureProfile.Left = (int)(MainPanel.Width * 0.33);
            NameLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 27;
            NameLabel.Left = (int)(MainPanel.Width * 0.6) + 10;
            NameField.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 27;
            NameField.Left = (int)(MainPanel.Width * 0.65) + 50;
            NameField.Width = (int)((MainPanel.Width - 20) * 0.27);
            SurnameLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 85;
            SurnameLabel.Left = (int)(MainPanel.Width * 0.6) - 30;
            SurnameField.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 85;
            SurnameField.Left = (int)(MainPanel.Width * 0.65) + 50;
            SurnameField.Width = (int)((MainPanel.Width - 20) * 0.27);
            NumberLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 150;
            NumberLabel.Left = (int)(MainPanel.Width * 0.6) - 25;
            NumberField.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 150;
            NumberField.Left = (int)(MainPanel.Width * 0.65) + 50;
            NumberField.Width = (int)((MainPanel.Width - 20) * 0.27);
            MailLabel.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 220;
            MailLabel.Left = (int)(MainPanel.Width * 0.6) - 10;
            MailField.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 220;
            MailField.Left = (int)(MainPanel.Width * 0.65) + 50;
            MailField.Width = (int)((MainPanel.Width - 20) * 0.27);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 661);
            NameField.Text = CurrentUser.currentUser.Name;
            SurnameField.Text = CurrentUser.currentUser.Surname;
            NumberField.Text = CurrentUser.currentUser.Number;
            MailField.Text = CurrentUser.currentUser.Mail;
            if (CurrentUser.currentUser.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(CurrentUser.currentUser.Photo);
                pictureProfile.Image = Image.FromStream(memoryStream);
            }
        }

        private void SelectionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllSelectionForm allSelectionForm = new AllSelectionForm();
            allSelectionForm.ShowDialog();
        }

        private void ExitAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InitialForm initialForm = new InitialForm();
            initialForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Close();
            EditingForm editingForm = new EditingForm();
            editingForm.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.gif;*.raw;*.jpg)|*.png;*.jpeg;*.gif;*.raw|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureProfile.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить эту картинку", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            byte[] imageBytes;
            try
            {
                using (var context = new RoutesForTouristsContext())
                {
                    var person = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                    if (person == null)
                    {
                        MessageBox.Show("Пользователь не найден");
                        return;
                    }
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureProfile.Image.Save(ms, pictureProfile.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                    CurrentUser.currentUser.Photo = imageBytes;
                    person.Photo = CurrentUser.currentUser.Photo;
                    CurrentUser.currentUser = person;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
