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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 575);
            if (CurrentRoute.currentRoute == null)
            {
                MessageBox.Show("Данный маршрут не был найден");
                return;
            }
            if (CurrentUser.currentUser.AnotherRoutes != null)
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
            if (CurrentUser.currentUser.AnotherRoutes == null)
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
                if (currUser.AnotherRoutes != string.Empty)
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
                if (currUser.AnotherRoutes != null)
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
                MessageBox.Show("Данный маршрут был удалён");
            }
        }

        private void DetailsForm_Resize(object sender, EventArgs e)
        {
            pictureRoute.Width = (int)(MainPanel.Width * 0.33);
            pictureRoute.Height = (int)(MainPanel.Height * 0.65);
            pictureRoute.Top = 0;
            pictureRoute.Left = 0;
            attractionsLabel.Top = (int)(MainPanel.Height * 0.015);
            attractionsLabel.Left = (int)(MainPanel.Width * 0.35);
            richTextBoxAttractions.Top = (int)((MainPanel.Height + 103) * 0.015) + attractionsLabel.Height + 10;
            richTextBoxAttractions.Left = (int)(MainPanel.Width * 0.35);
            richTextBoxAttractions.Width = (int)(MainPanel.Width * 0.64);
            richTextBoxAttractions.Height = (int)(MainPanel.Width * 0.08);
            hotelLabel.Top = (int)(MainPanel.Height * 0.015) + attractionsLabel.Height + richTextBoxAttractions.Height + 20;
            hotelLabel.Left = (int)(MainPanel.Width * 0.35);
            hotelRichTextBox.Top = (int)((MainPanel.Height + 103) * 0.015) + attractionsLabel.Height + richTextBoxAttractions.Height + hotelLabel.Height + 20;
            hotelRichTextBox.Left = (int)(MainPanel.Width * 0.35);
            hotelRichTextBox.Width = (int)(MainPanel.Width * 0.64);
            hotelRichTextBox.Height = (int)(MainPanel.Width * 0.08);
            flightsLabel.Top = (int)(MainPanel.Height * 0.015) + attractionsLabel.Height + richTextBoxAttractions.Height + hotelLabel.Height + hotelRichTextBox.Height + 30;
            flightsLabel.Left = (int)(MainPanel.Width * 0.35);
            flightsRichTextBox.Top = (int)((MainPanel.Height + 103) * 0.015) + attractionsLabel.Height + richTextBoxAttractions.Height + hotelLabel.Height + hotelRichTextBox.Height + flightsLabel.Height + 35;
            flightsRichTextBox.Left = (int)(MainPanel.Width * 0.35);
            flightsRichTextBox.Width = (int)(MainPanel.Width * 0.64);
            flightsRichTextBox.Height = (int)(MainPanel.Width * 0.08);

            durationLabel.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height;
            durationLabel.Left = (int)(MainPanel.Width * 0.015);
            durationRichTextBox.Top = (int)((MainPanel.Height + 103) * 0.015) + pictureRoute.Height;
            durationRichTextBox.Left = (int)(MainPanel.Width * 0.015) + 150;
            durationRichTextBox.Width = (int)(MainPanel.Width * 0.64);
            durationRichTextBox.Height = (int)(MainPanel.Width * 0.05);
            budgetLabel.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height + durationRichTextBox.Height + 10;
            budgetLabel.Left = (int)(MainPanel.Width * 0.015);
            budgetRichTextBox.Top = (int)((MainPanel.Height + 103) * 0.015) + pictureRoute.Height + durationRichTextBox.Height + 10;
            budgetRichTextBox.Left = (int)(MainPanel.Width * 0.015) + 150;
            budgetRichTextBox.Width = (int)(MainPanel.Width * 0.64);
            budgetRichTextBox.Height = (int)(MainPanel.Width * 0.05);

            deleteButton.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height + durationRichTextBox.Height + budgetRichTextBox.Height + 30;
            deleteButton.Left = (int)(MainPanel.Width * 0.6);
            likeButton.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height + durationRichTextBox.Height + budgetRichTextBox.Height + 30;
            likeButton.Left = (int)(MainPanel.Width * 0.6) + 20;
            deleteButton.Width = (int)((MainPanel.Width - 20) * 0.2);
            deleteButton.Height = (int)((MainPanel.Height + 103) * 0.075);
        }
    }
}
