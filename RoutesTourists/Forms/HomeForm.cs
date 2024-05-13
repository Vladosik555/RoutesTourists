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
            StartPosition = FormStartPosition.CenterScreen;
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

        private void MySelectedButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MyCollectionsForm myCollectionsForm = new MyCollectionsForm();
            myCollectionsForm.ShowDialog();
        }

        private void HomeForm_Resize(object sender, EventArgs e)
        {
            label2.Left = (int)(MainPanel.Width * 0.28);
            label2.Height = MainPanel.Height;

            RecommenButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            RecommenButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            RecommenButton.Top = (int)((MainPanel.Height + 103) * 0.05);
            RecommenButton.Left = (int)(MainPanel.Width * 0.015);
            FavoritesButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            FavoritesButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            FavoritesButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + 27;
            FavoritesButton.Left = (int)(MainPanel.Width * 0.015);
            CharacteristicsButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            CharacteristicsButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            CharacteristicsButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + 55;
            CharacteristicsButton.Left = (int)(MainPanel.Width * 0.015);
            SelectionsButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            SelectionsButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            SelectionsButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + CharacteristicsButton.Height + 85;
            SelectionsButton.Left = (int)(MainPanel.Width * 0.015);
            MySelectedButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            MySelectedButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            MySelectedButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + CharacteristicsButton.Height + SelectionsButton.Height + 115;
            MySelectedButton.Left = (int)(MainPanel.Width * 0.015);
            EnterButton.Width = (int)((MainPanel.Width - 20) * 0.241);
            EnterButton.Height = (int)((MainPanel.Height + 103) * 0.08);
            EnterButton.Top = (int)((MainPanel.Height + 103) * 0.05) + RecommenButton.Height + FavoritesButton.Height + CharacteristicsButton.Height + SelectionsButton.Height + MySelectedButton.Height + 145;
            EnterButton.Left = (int)(MainPanel.Width * 0.015);

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 661);
        }
    }
}
