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
    public partial class CharacteristicsForm : Form
    {
        public CharacteristicsForm()
        {
            InitializeComponent();
        }
        private List<Route> GetRoutes(string duration, string budget, string seasonality)
        {
            using (var context = new RoutesForTouristsContext())
            {
                string[] durationNumber = Examination.GetAllNumber(duration).Split(' ');
                string[] budgetNumber = Examination.GetAllNumber(budget).Split(' ');
                if (budgetNumber.Length == 2)
                {
                    int minDurationNumber = Convert.ToInt32(durationNumber[0]);
                    int maxDurationNumber = Convert.ToInt32(durationNumber[1]);
                    int minDudgetNumber = Convert.ToInt32(budgetNumber[0]);
                    int maxDudgetNumber = Convert.ToInt32(budgetNumber[1]);
                    var routes = context.Routes.Where(r => r.Duration >= minDurationNumber || r.Duration <= maxDurationNumber &&
                    r.Budget >= minDudgetNumber || r.Budget <= maxDudgetNumber && r.Seasonality.Equals(seasonality)).ToList();
                    CurrentRoutes.currentRoutes = null;
                    CurrentRoutes.currentRoutes = routes;
                    return routes;
                }
                if (budgetNumber.Length == 1)
                {
                    int minDurationNumber = Convert.ToInt32(durationNumber[0]);
                    int maxDurationNumber = Convert.ToInt32(durationNumber[1]);
                    int DudgetNumber = Convert.ToInt32(budgetNumber[0]);
                    var routes = context.Routes.Where(r => r.Duration >= minDurationNumber || r.Duration <= maxDurationNumber &&
                    r.Budget > DudgetNumber && r.Seasonality.Equals(seasonality)).ToList();
                    CurrentRoutes.currentRoutes = null;
                    CurrentRoutes.currentRoutes = routes;
                    return routes;
                }
                CurrentRoutes.currentRoutes = null;
                return null;
            }
        }
        private void CharacteristicsForm_Load(object sender, EventArgs e)
        {
            FilteredTable.DataSource = Tables.GetCharacteristicsTable(CurrentRoutes.currentRoutes);
        }

        private void durationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string duration = durationComboBox.Text;
            string budget = budgetComboBox.Text;
            string seasonality = seasonalityComboBox.Text;
        }

        private void budgetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string duration = durationComboBox.Text;
            string budget = budgetComboBox.Text;
            string seasonality = seasonalityComboBox.Text;
        }

        private void seasonalityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string duration = durationComboBox.Text;
            string budget = budgetComboBox.Text;
            string seasonality = seasonalityComboBox.Text;
        }

        private void FilteredTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = FilteredTable.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Позиция"].Value;
                var route = CurrentRoutes.currentRoutes[position - 1];
                CurrentRoute.currentRoute = route;
                DetailsForm detailsForm = new DetailsForm();    
                detailsForm.ShowDialog();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
