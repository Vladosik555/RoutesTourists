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
    public partial class MyCollectionsForm : Form
    {
        public MyCollectionsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MyCollectionsForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 575);
            using (var context = new RoutesForTouristsContext())
            {
                if (CurrentUser.currentUser.AnotherRoutes != null)
                {
                    List<Route> favoriteRoutes = new List<Route>();
                    var currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                    if (currUser == null)
                    {
                        MessageBox.Show("Ошибка подключении базы данных");
                    }
                    foreach (string anotherRoutes in CurrentUser.currentUser.AnotherRoutes.Split(","))
                    {
                        var route = context.Routes.FirstOrDefault(r => r.Id.Equals(anotherRoutes));
                        favoriteRoutes.Add(route);
                    }
                    CurrentRoutes.currentRoutes = favoriteRoutes;
                }
                else
                {
                    CurrentRoutes.currentRoutes = null;
                }
                if (CurrentRoutes.currentRoutes != null)
                {
                    foreach (Route nameRoute in CurrentRoutes.currentRoutes)
                    {
                        choiseComboBox.Items.Add(nameRoute.Name);
                    }
                }
            }
        }

        private void createCollectionButton_Click(object sender, EventArgs e)
        {
            if (SelectedField.Text == string.Empty)
            {
                MessageBox.Show("Поле для названии подборки добжно быть заполнено");
                return;
            }
            if (choiseComboBox.Text.ToString() == null)
            {
                MessageBox.Show("Выберите маршрут");
                return;
            }
            using (var context = new RoutesForTouristsContext())
            {
                Selection selection = new Selection();
                selection.Id = Guid.NewGuid().ToString();
                selection.Name = SelectedField.Text;
                if (CurrentRoutes.currentRoutes[choiseComboBox.SelectedIndex] != null)
                {
                    selection.IdRoutes = CurrentRoutes.currentRoutes[choiseComboBox.SelectedIndex].Id;
                }
                var route = context.Routes.FirstOrDefault(r => r.Id.Equals(CurrentRoutes.currentRoutes[choiseComboBox.SelectedIndex].Id));
                if (route == null)
                {
                    MessageBox.Show("Ошибка в подключении базы данных");
                    return;
                }
                route.LikesSelection += 1;
                var user = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (user == null)
                {
                    MessageBox.Show("Ошибка в подключении базы данных");
                    return;
                }
                var selections = context.Selections.Where(r => r.IdRoutes.Equals(route.Id));
                if (selections != null)
                {
                    foreach (var currSelection in selections)
                    {
                        if (user.IdSelection.Split(",").Contains(currSelection.Id))
                        {
                            MessageBox.Show("Данный маршрут был добавлен ранее в подборки");
                            return;
                        }
                    }
                }
                if (user.IdSelection == null)
                {
                    user.IdSelection = selection.Id;
                }
                else
                {
                    user.IdSelection += "," + selection.Id;
                }
                context.Selections.Add(selection);
                context.SaveChanges();
                MessageBox.Show("Данная маршрут был добавлен в подборки");
            }
        }


        private void ViewCollectionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }

        private void MyCollectionsForm_Resize(object sender, EventArgs e)
        {
            NameLabel.Top = (int)((MainPanel.Height + 103) * 0.07);
            NameLabel.Left = (int)(MainPanel.Width * 0.06);
            SelectedField.Top = (int)((MainPanel.Height + 103) * 0.07) + NameLabel.Height + 15;
            SelectedField.Left = (int)(MainPanel.Width * 0.06);
            SelectedField.Width = (int)(MainPanel.Width * 0.9);
            ChoiseLabel.Top = (int)((MainPanel.Height + 103) * 0.07) + NameLabel.Height + SelectedField.Height + 30;
            ChoiseLabel.Left = (int)(MainPanel.Width * 0.06);
            choiseComboBox.Top = (int)((MainPanel.Height + 103) * 0.07) + NameLabel.Height + SelectedField.Height + ChoiseLabel.Height + 45;
            choiseComboBox.Left = (int)(MainPanel.Width * 0.06);
            choiseComboBox.Width = (int)(MainPanel.Width * 0.9);

            createCollectionButton.Width = (int)((MainPanel.Width - 20) * 0.4);
            createCollectionButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            createCollectionButton.Top = (int)((MainPanel.Height + 103) * 0.4) + 45;
            createCollectionButton.Left = (int)(MainPanel.Width * 0.35) - 20;
            ViewCollectionsButton.Width = (int)((MainPanel.Width - 20) * 0.35);
            ViewCollectionsButton.Height = (int)((MainPanel.Height + 103) * 0.07);
            ViewCollectionsButton.Top = (int)((MainPanel.Height + 103) * 0.4)  + createCollectionButton.Height + 65;
            ViewCollectionsButton.Left = (int)(MainPanel.Width * 0.35) - 5;
            BackButton.Width = (int)((MainPanel.Width - 20) * 0.35);
            BackButton.Height = (int)((MainPanel.Height + 103) * 0.07);
            BackButton.Top = (int)((MainPanel.Height + 103) * 0.4) + createCollectionButton.Height + ViewCollectionsButton.Height + 75;
            BackButton.Left = (int)(MainPanel.Width * 0.35) - 5;

        }
    }
}
