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
        private int start_duration;
        private int end_duration;
        private int start_budget;
        private int end_budget;
        private string seasonality;
        public CharacteristicsForm()
        {
            InitializeComponent();
        }
        private void GetRoutes(int start_duration, int end_duration, int start_budget, int end_budget, string seasonality)
        {
            using (var context = new RoutesForTouristsContext())
            {
                if(seasonality != null)
                {
                    var routes = context.Routes.Where(r => r.Seasonality.Equals(seasonality) && r.Duration >= start_duration &&
                    r.Duration <= end_duration && r.Budget >= start_budget && r.Budget <= end_budget).ToList();
                    CurrentRoutes.currentRoutes = routes;
                    FilteredTable.DataSource = Tables.GetCharacteristicsTable(CurrentRoutes.currentRoutes);
                }
            }

        }
        private void CharacteristicsForm_Load(object sender, EventArgs e)
        {
            FilteredTable.DataSource = Tables.GetCharacteristicsTable(CurrentRoutes.currentRoutes);
        }

        private void FilteredTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
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

        private void startDuration_TextChanged(object sender, EventArgs e)
        {
            if(startDuration.Text != string.Empty)
            {
                if (Examination.CheckNumber(startDuration.Text))
                {
                    if (Convert.ToInt32(startDuration.Text) <= Int32.MaxValue)
                    {
                        start_duration = Convert.ToInt32(startDuration.Text);
                    }
                    else if (Convert.ToInt32(startDuration.Text) < 0)
                    {
                        start_duration = 0;
                    }
                }
                else
                {
                    start_duration = 0;
                }
            }
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }

        private void endDuration_TextChanged(object sender, EventArgs e)
        {
            if(endDuration.Text != string.Empty)
            {
                if (Examination.CheckNumber(endDuration.Text))
                {
                    if (Convert.ToInt32(endDuration.Text) <= Int32.MaxValue)
                    {
                        end_duration = Convert.ToInt32(endDuration.Text);
                    }
                    else if (Convert.ToInt32(endDuration.Text) < 0)
                    {
                        end_duration = 0;
                    }
                }
                else
                {
                    end_duration = 0;
                }
            }
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }

        private void startBudget_TextChanged(object sender, EventArgs e)
        {
            if(startBudget.Text != string.Empty)
            {
                if (Examination.CheckNumber(startBudget.Text))
                {
                    if (Convert.ToInt32(startBudget.Text) <= Int32.MaxValue)
                    {
                        start_budget = Convert.ToInt32(startBudget.Text);
                    }
                    else if (Convert.ToInt32(startBudget.Text) < 0)
                    {
                        start_budget = 0;
                    }
                }
                else
                {
                    start_budget = 0;
                }
            }
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }

        private void endBudget_TextChanged(object sender, EventArgs e)
        {
            if(endBudget.Text != string.Empty)
            {
                if (Examination.CheckNumber(endBudget.Text))
                {
                    if (Convert.ToInt32(endBudget.Text) <= Int32.MaxValue)
                    {
                        end_budget = Convert.ToInt32(endBudget.Text);
                    }
                    else if (Convert.ToInt32(endBudget.Text) < 0)
                    {
                        end_budget = 0;
                    }
                }
                else
                {
                    end_budget = 0;
                }
            }
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }

        private void seasonalityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seasonality = seasonalityComboBox.Text.ToString();
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }
    }
}
