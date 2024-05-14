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
    public partial class AllSelectionForm : Form
    {
        public AllSelectionForm()
        {
            InitializeComponent();
        }

        private void AllSelectionForm_Load(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                var selectionRoutes = context.Routes.Where(r => r.LikesSelection == 5).ToList();
                AllSelectionTable.DataSource = Tables.GetCharacteristicsTable(selectionRoutes);
                CurrentRoutes.currentRoutes = selectionRoutes;
                //скуф
                //d
            }
        }

        private void AllSelectionTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = AllSelectionTable.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Позиция"].Value;
                if(CurrentRoutes.currentRoutes[position - 1] == null)
                {
                    MessageBox.Show("Данный маршрут не был найден");
                    return;
                }
                var route = CurrentRoutes.currentRoutes[position - 1];
                CurrentRoute.currentRoute = route;
                SelectedSelectionForm selectedSelectionForm = new SelectedSelectionForm();
                selectedSelectionForm.ShowDialog();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
