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
using System.Xml;

namespace RoutesTourists.Forms
{
    public partial class RecommenForm : Form
    {
        private bool flag = true;
        private int count = 1;
        public RecommenForm()
        {
            InitializeComponent();
        }

        private void RecommenForm_Load(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                var PopupalRoutes = context.Routes.ToList();
                CurrentRoutes.currentRoutes = PopupalRoutes;
                if (PopupalRoutes == null)
                {
                    MessageBox.Show("Маршруты не были найдены");
                    return;
                }
                var PopularRoute = PopupalRoutes.OrderByDescending(u => u.Likes).ToList();
                var firstPopularRoute = PopularRoute[0];
                NameLabel.Text = firstPopularRoute.Name;
                richTextBoxRoute.Text = firstPopularRoute.Description;
                if (firstPopularRoute.Photo != null)
                {
                    MemoryStream memoryStream = new MemoryStream(firstPopularRoute.Photo);
                    pictureRoute.Image = Image.FromStream(memoryStream);
                }
                CurrentRoute.currentRoute = PopularRoute[0];
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
                if(currUser.AnotherRoutes != null)
                {
                    if (currUser.AnotherRoutes.Split(",").Contains(currRoure.Id))
                    {
                        MessageBox.Show("Нельзя оценить аккаунт более одного раза");
                        return;
                    }
                }
                if (currRoure.Likes == null)
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
                currRoure.Likes++;
                context.SaveChanges();
                MessageBox.Show("Данный маршрут был добавлен в избранное");
            }
        }

        private void ВetailsButton_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm();
            detailsForm.ShowDialog();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (CurrentRoutes.currentRoutes.Count - 1 > count)
                {
                    count++;
                    NameLabel.Text = CurrentRoutes.currentRoutes[count].Description;
                    richTextBoxRoute.Text = CurrentRoutes.currentRoutes[count].Description;
                    CurrentRoute.currentRoute = CurrentRoutes.currentRoutes[count];
                    if (CurrentRoutes.currentRoutes[count].Photo != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(CurrentRoutes.currentRoutes[count].Photo);
                        pictureRoute.Image = Image.FromStream(memoryStream);
                    }
                    else
                    {
                        pictureRoute.Image = null;
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CurrentRoutes.currentRoutes = null;
            this.Close();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
