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
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void GetRoutes(int start_duration, int end_duration, int start_budget, int end_budget, string seasonality)
        {
            using (var context = new RoutesForTouristsContext())
            {
                if (seasonality != null)
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
            ClientSize = new Size(918, 575);
        }
        private void CharacteristicsForm_Resize(object sender, EventArgs e)
        {
            FilteredTable.Height = (int)((MainPanel.Height + 103) * 0.55);
            BackButton.Width = (int)((MainPanel.Width - 20) * 0.3);
            BackButton.Height = (int)((MainPanel.Height + 103) * 0.075);
            BackButton.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height + 50;
            BackButton.Left = (int)(MainPanel.Width * 0.35);
            durationLabel.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height - 55;
            durationLabel.Left = (int)(MainPanel.Width * 0.1);
            startLabel.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            startLabel.Left = (int)(MainPanel.Width * 0.07);
            startDuration.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            startDuration.Left = (int)(MainPanel.Width * 0.07) + 48;
            endLabel.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            endLabel.Left = (int)(MainPanel.Width * 0.07) + 105;
            endDuration.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            endDuration.Left = (int)(MainPanel.Width * 0.07) + 150;
            startLabel_1.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            startLabel_1.Left = (int)(MainPanel.Width * 0.07) + 210;
            startBudget.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            startBudget.Left = (int)(MainPanel.Width * 0.07) + 255;
            endLabel_1.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            endLabel_1.Left = (int)(MainPanel.Width * 0.07) + 370;
            endBudget.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            endBudget.Left = (int)(MainPanel.Width * 0.07) + 415;
            seasonalityComboBox.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height;
            seasonalityComboBox.Left = (int)(MainPanel.Width * 0.07) + 550;
            budgetLabel.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height - 55;
            budgetLabel.Left = (int)(MainPanel.Width * 0.1) + 250;
            seasonalityLabel.Top = (int)((MainPanel.Height + 103) * 0.1) + FilteredTable.Height - 55;
            seasonalityLabel.Left = (int)(MainPanel.Width * 0.1) + 515;
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }

        private void FilteredTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = FilteredTable.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Позиция"].Value;
                if (CurrentRoutes.currentRoutes[position - 1] == null)
                {
                    MessageBox.Show("Данный маршрут не был найден");
                    return;
                }
                var route = CurrentRoutes.currentRoutes[position - 1];
                CurrentRoute.currentRoute = route;
                DetailsForm detailsForm = new DetailsForm();
                detailsForm.ShowDialog();
            }
        }

        private void startDuration_TextChanged_1(object sender, EventArgs e)
        {
            if (startDuration.Text != string.Empty)
            {
                if (!(startDuration.Text.Length >= 9))
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
                else
                {
                    MessageBox.Show("Нельзя вводить текст, который большей 8 символов");
                    return;
                }
            }
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }

        private void endDuration_TextChanged_1(object sender, EventArgs e)
        {
            if (endDuration.Text != string.Empty)
            {
                if (!(endDuration.Text.Length >= 9))
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
                else
                {
                    MessageBox.Show("Нельзя вводить текст, который большей 8 символов");
                    return;
                }
            }
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }

        private void startBudget_TextChanged_1(object sender, EventArgs e)
        {
            if (startBudget.Text != string.Empty)
            {
                if (!(startBudget.Text.Length >= 9))
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
                else
                {
                    MessageBox.Show("Нельзя вводить текст, который большей 8 символов");
                    return;
                }
            }
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }

        private void endBudget_TextChanged_1(object sender, EventArgs e)
        {
            if (endBudget.Text != string.Empty)
            {
                if (!(endBudget.Text.Length >= 9))
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
                else
                {
                    MessageBox.Show("Нельзя вводить текст, который большей 8 символов");
                    return;
                }
            }
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }

        private void seasonalityComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            seasonality = seasonalityComboBox.Text.ToString();
            GetRoutes(start_duration, end_duration, start_budget, end_budget, seasonality);
        }
    }
}
