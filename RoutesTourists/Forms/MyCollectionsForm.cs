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
        }

        private void MyCollectionsForm_Load(object sender, EventArgs e)
        {
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
            if(choiseComboBox.Text.ToString() == null)
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
                route.LikesSelection++;
                var user = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (user == null)
                {
                    MessageBox.Show("Ошибка в подключении базы данных");
                    return;
                }
                // добавить проверку на существующий маршрут
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
            }
        }


        private void ViewCollectionsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectionForm selectionForm = new SelectionForm();  
            selectionForm.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
