using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FavoritesForm : Form
    {
        public FavoritesForm()
        {
            InitializeComponent();
        }

        private void FavoritesForm_Load(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                var currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (currUser == null)
                {
                    MessageBox.Show("Ошибка в подключении к базе данных");
                    return;
                }
                List<Route> favoritesRoutes = new List<Route>();
                foreach (string idAnother in currUser.AnotherRoutes.Split(","))
                {
                    var favotiteRoute = context.Routes.FirstOrDefault(r => r.Id.Equals(idAnother));
                    if (favotiteRoute != null)
                    {
                        favoritesRoutes.Add(favotiteRoute);
                    }
                }
                CurrentRoutes.currentRoutes = favoritesRoutes;
                DataTable dataTable = Tables.GetCharacteristicsTable(favoritesRoutes);
                FavoriteTable.DataSource = dataTable;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void FavoriteTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = FavoriteTable.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Позиция"].Value;
                var route = CurrentRoutes.currentRoutes[position - 1];
                CurrentRoute.currentRoute = route;
                DetailsForm detailsForm = new DetailsForm();
                detailsForm.ShowDialog();
            }
        }
    }
}
