﻿using RoutesTourists.Classes;
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
                var PopularRoute = PopupalRoutes.OrderByDescending(u => u.AverageMark).ToList();
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
                if (currRoure.Id.Split(",").Contains(currUser.AnotherRoutes))
                {
                    MessageBox.Show("Нельзя оценить аккаунт более одного раза");
                    return;
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
                    currUser.AnotherRoutes = "," + currRoure.Id.ToString();
                }
                currRoure.Likes++;
                context.SaveChanges();
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
                if(CurrentRoutes.currentRoutes.Count - 1 > count)
                {

                }
            }
        }
    }
}
