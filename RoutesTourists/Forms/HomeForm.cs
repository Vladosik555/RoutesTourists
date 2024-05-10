using RoutesTourists.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutesTourists
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void RecommenButton_Click(object sender, EventArgs e)
        {
            this.Close();
            RecommenForm recommenForm = new RecommenForm();
            recommenForm.ShowDialog();
        }

        private void CharacteristicsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CharacteristicsForm characteristicsForm = new CharacteristicsForm();
            characteristicsForm.ShowDialog();
        }

        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FavoritesForm favoritesForm = new FavoritesForm();
            favoritesForm.ShowDialog();
        }
    }
}
