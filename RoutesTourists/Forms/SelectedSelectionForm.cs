using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class SelectedSelectionForm : Form
    {
        private bool flag = false;
        public SelectedSelectionForm()
        {
            InitializeComponent();
        }

        private void NameSelectionText_Enter(object sender, EventArgs e)
        {
            if (NameSelectionText.Text.Equals("Запишите название подборки"))
            {
                NameSelectionText.Text = string.Empty;
                NameSelectionText.ForeColor = Color.Black;
            }
        }

        private void NameSelectionText_Leave(object sender, EventArgs e)
        {
            if (NameSelectionText.Text.Equals(string.Empty))
            {
                NameSelectionText.ForeColor = Color.Gray;
                NameSelectionText.Text = "Запишите название подборки";
            }
        }

        private void SelectedSelectionForm_Load(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                var selections = context.Selections.Where(r=>r.IdRoutes.Equals(CurrentRoute.currentRoute.Id)).ToList();
                if(selections.Count != 0)
                {
                    foreach (var selection in selections)
                    {
                        if (CurrentUser.currentUser.IdSelection.Split(",").Contains(selection.Id))
                        {
                            flag = true;
                        }
                    }
                }
                if(selections.Count == 0)
                {
                    AddSelectionButton.Enabled = true;
                    AddSelectionButton.Visible = true;
                }
                if (flag)
                {
                    deleteButton.Enabled = true;
                    deleteButton.Visible = true;
                }
                else
                {
                    AddSelectionButton.Enabled = true;
                    AddSelectionButton.Visible = true;
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
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                var currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (currUser == null)
                {
                    MessageBox.Show("Ошибка в подключении к базе данных");
                    return;
                }
                var route = context.Routes.FirstOrDefault(r => r.Id.Equals(CurrentRoute.currentRoute.Id));
                if (route == null)
                {
                    MessageBox.Show("Ошибка в подключении к базе данных");
                    return;
                }
                var selections = context.Selections.Where(r => r.IdRoutes.Equals(CurrentRoute.currentRoute.Id)).ToList();
                string selectionId;
                var currSelection = new Selection();
                foreach (var selection in selections)
                {
                    if (currUser.IdSelection.Split(",").Contains(selection.Id))
                    {
                        selectionId = selection.Id;
                        currSelection = context.Selections.FirstOrDefault(r => r.Id.Equals(selection.Id));
                        if (currSelection == null)
                        {
                            MessageBox.Show("Ошибка в подключении к базе данных");
                            return;
                        }
                    }
                }
                route.LikesSelection -= 1;
                if (currUser.AnotherRoutes != null)
                {
                    if (currUser.IdSelection.Equals(currSelection.Id))
                    {
                        currUser.IdSelection = null;
                    }
                    else
                    {
                        currUser.IdSelection = currUser.IdSelection.Replace($"{currSelection.Id}" + ",", "").Replace("," + $"{currSelection.Id}", "").Replace($"{currSelection.Id}", "");
                    }
                }
                context.Selections.Remove(currSelection);
                CurrentUser.currentUser = currUser;
                context.SaveChanges();
                MessageBox.Show("Ваша подборка была удалена");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.ShowDialog();
        }

        private void AddSelectionButton_Click(object sender, EventArgs e)
        {
            if(NameSelectionText.Text == string.Empty || NameSelectionText.Text.Equals("Запишите название подборки"))
            {
                MessageBox.Show("Введите название подборки");
                return;
            }
            using (var context = new RoutesForTouristsContext())
            {
                Selection selection = new Selection();
                selection.Id = Guid.NewGuid().ToString();
                selection.Name = NameSelectionText.Text;
                selection.IdRoutes = CurrentRoute.currentRoute.Id;
                Route currRoute = context.Routes.FirstOrDefault(r => r.Id.Equals(CurrentRoute.currentRoute.Id));
                User currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (!currUser.AnotherRoutes.Split(",").Contains(currRoute.Id))
                {
                    if (currUser.AnotherRoutes == null)
                    {
                        currUser.AnotherRoutes = currRoute.Id.ToString();
                    }
                    else
                    {
                        currUser.AnotherRoutes += "," + currRoute.Id.ToString();
                    }
                    currRoute.Likes += 1;
                }
                if (currRoute == null)
                {
                    MessageBox.Show("Ошибка в подключение к базе данных");
                    return;
                }
                currRoute.LikesSelection += 1;
                if(currUser == null)
                {
                    MessageBox.Show("Ошибка в подключение к базе данных");
                    return;
                }
                if (currUser.IdSelection == null)
                {
                    currUser.IdSelection = selection.Id;
                }
                else
                {
                    currUser.IdSelection += "," + selection.Id;
                }
                context.Selections.Add(selection);
                context.SaveChanges();
                MessageBox.Show("Данная маршрут был добавлен в подборки");
            }
        }
    }
}
