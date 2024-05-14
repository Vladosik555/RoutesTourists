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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            if (CurrentRoute.currentRoute == null)
            {
                MessageBox.Show("Данный маршрут не был найден");
                return;
            }
            if(CurrentUser.currentUser.AnotherRoutes != null)
            {
                if (CurrentUser.currentUser.AnotherRoutes.Equals(CurrentRoute.currentRoute.Id))
                {
                    deleteButton.Enabled = true;
                    deleteButton.Visible = true;
                }
                else
                {
                    if (CurrentUser.currentUser.AnotherRoutes.Split(",").Contains(CurrentRoute.currentRoute.Id))
                    {
                        deleteButton.Enabled = true;
                        deleteButton.Visible = true;
                    }
                    else
                    {
                        likeButton.Enabled = true;
                        likeButton.Visible = true;
                    }
                }
            }
            if(CurrentUser.currentUser.AnotherRoutes == null)
            {
                likeButton.Enabled = true;
                likeButton.Visible = true;
            }
            richTextBoxAttractions.Text = CurrentRoute.currentRoute.Attractions;
            hotelRichTextBox.Text = CurrentRoute.currentRoute.Hotels;
            flightsRichTextBox.Text = CurrentRoute.currentRoute.Flight;
            durationRichTextBox.Text = CurrentRoute.currentRoute.Duration.ToString();
            budgetRichTextBox.Text = $"{CurrentRoute.currentRoute.Budget} рублей";
            if (CurrentRoute.currentRoute.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(CurrentRoute.currentRoute.Photo);
                pictureRoute.Image = Image.FromStream(memoryStream);
            }
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                var currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (currUser == null)
                {
                    MessageBox.Show("Пользователь был утерян");
                    return;
                }
                var currRoure = context.Routes.FirstOrDefault(r => r.Id.Equals(CurrentRoute.currentRoute.Id));
                if (currRoure == null)
                {
                    MessageBox.Show("Данный маршрут не был найден");
                    return;
                }
                if(currUser.AnotherRoutes != string.Empty)
                {
                    if (currUser.AnotherRoutes.Split(",").Contains(currRoure.Id))
                    {
                        MessageBox.Show("Нельзя оценить аккаунт более одного раза");
                        return;
                    }
                }
                if (currRoure.Likes == null || currRoure.Likes == 0)
                {
                    currRoure.Likes = 0;
                }
                if (currUser.AnotherRoutes == null)
                {
                    currUser.AnotherRoutes = currRoure.Id.ToString();
                }
                else
                {
                    currUser.AnotherRoutes += "," + currRoure.Id.ToString();
                }
                currRoure.Likes += 1;
                context.SaveChanges();
                MessageBox.Show("Даннай маршрут был добавлен в избранное");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                var currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (currUser == null)
                {
                    MessageBox.Show("Пользователь был утерян");
                    return;
                }
                var currRoure = context.Routes.FirstOrDefault(r => r.Id.Equals(CurrentRoute.currentRoute.Id));
                if (currRoure == null)
                {
                    MessageBox.Show("Данный маршрут не был найден");
                    return;
                }
                if(currUser.AnotherRoutes != null)
                {
                    if (currUser.AnotherRoutes.Equals(currRoure.Id))
                    {
                        currUser.AnotherRoutes = null;
                    }
                    else
                    {
                        currUser.AnotherRoutes = currUser.AnotherRoutes.Replace($"{currRoure.Id}" + ",", "").Replace("," + $"{currRoure.Id}", "").Replace($"{currRoure.Id}", "");
                    }
                }
                currRoure.Likes -= 1;
                CurrentUser.currentUser = currUser;
                context.SaveChanges();
                MessageBox.Show("Даннай маршрут был удалён");
            }
        }
    }
}
