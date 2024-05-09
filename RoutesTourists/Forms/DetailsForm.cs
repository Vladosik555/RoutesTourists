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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            if(CurrentRoute.currentRoute == null)
            {
                MessageBox.Show("Данный маршрут не был найден");
                return;
            }
            richTextBoxAttractions.Text = CurrentRoute.currentRoute.Attractions;
            hotelRichTextBox.Text = CurrentRoute.currentRoute.Hotels;
            flightsRichTextBox.Text = CurrentRoute.currentRoute.Flight;
            durationRichTextBox.Text = CurrentRoute.currentRoute.Duration;
            budgetRichTextBox.Text = $"{CurrentRoute.currentRoute.Budget} рублей";
            if (CurrentRoute.currentRoute.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(CurrentRoute.currentRoute.Photo);
                pictureRoute.Image = Image.FromStream(memoryStream);
            }
        }
    }
}
