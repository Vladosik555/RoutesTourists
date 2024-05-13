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
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RecommenForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 575);
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
                if (currUser.AnotherRoutes != null)
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

        private void RecommenForm_Resize(object sender, EventArgs e)
        {
            pictureRoute.Width = (int)(MainPanel.Width * 0.35);
            pictureRoute.Height = (int)(MainPanel.Height * 0.82);
            pictureRoute.Top = 0;
            pictureRoute.Left = 0;
            NameLabel.Top = (int)(MainPanel.Height * 0.015);
            NameLabel.Left = (int)(MainPanel.Width * 0.4);
            richTextBoxRoute.Top = (int)((MainPanel.Height + 103) * 0.015) + NameLabel.Height + 10;
            richTextBoxRoute.Left = (int)(MainPanel.Width * 0.4);
            richTextBoxRoute.Width = (int)(MainPanel.Width * 0.55);
            richTextBoxRoute.Height = (int)(MainPanel.Width * 0.38);

            BackButton.Width = (int)(MainPanel.Width * 0.11);
            BackButton.Height = (int)(MainPanel.Height * 0.07);
            BackButton.Top = (int)(MainPanel.Height * 0.9);
            BackButton.Left = (int)(MainPanel.Width * 0.4);
            likeButton.Width = (int)(MainPanel.Width * 0.11);
            likeButton.Height = (int)(MainPanel.Height * 0.07);
            likeButton.Top = (int)(MainPanel.Height * 0.9);
            likeButton.Left = (int)(MainPanel.Width * 0.4) + BackButton.Width + 20;
            ВetailsButton.Width = (int)(MainPanel.Width * 0.11);
            ВetailsButton.Height = (int)(MainPanel.Height * 0.07);
            ВetailsButton.Top = (int)(MainPanel.Height * 0.9);
            ВetailsButton.Left = (int)(MainPanel.Width * 0.4) + BackButton.Width + likeButton.Width + 40;
            NextButton.Width = (int)(MainPanel.Width * 0.17);
            NextButton.Height = (int)(MainPanel.Height * 0.07);
            NextButton.Top = (int)(MainPanel.Height * 0.9);
            NextButton.Left = (int)(MainPanel.Width * 0.4) + BackButton.Width + likeButton.Width + ВetailsButton.Width + 60;
        }
    }
}
