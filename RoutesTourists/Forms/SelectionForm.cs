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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                List<Selection> selections = new List<Selection>();
                var currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (currUser == null)
                {
                    MessageBox.Show("Ошибка в подключении базы данных");
                    return;
                }
                if(currUser.IdSelection != null)
                {
                    foreach (string id in currUser.IdSelection.Split(","))
                    {
                        var selection = context.Selections.FirstOrDefault(r => r.Id.Equals(id));
                        selections.Add(selection);
                    }
                }
                CurrentSelections.currentSelections = selections;
                DataTable dataTable = Tables.GetSelectionTable(selections);
                SelectionTable.DataSource = dataTable;
            }
        }

        private void SelectionTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = SelectionTable.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Позиция"].Value;
                var selection = CurrentSelections.currentSelections[position - 1];
                CurrentSelection.currentSelection = selection;
                MySelectionForm mySelectionForm = new MySelectionForm();
                mySelectionForm.ShowDialog();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MyCollectionsForm myCollectionsForm = new MyCollectionsForm();
            myCollectionsForm.ShowDialog();
        }
    }
}
