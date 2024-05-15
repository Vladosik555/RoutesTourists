using RoutesTourists.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutesTourists.Forms
{
    public partial class MySelectionForm : Form
    {
        public MySelectionForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MySelectionForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(918, 575);
            using (var context = new RoutesForTouristsContext())
            {
                var route = context.Routes.FirstOrDefault(r => r.Id.Equals(CurrentSelection.currentSelection.IdRoutes));
                if (route == null)
                {
                    MessageBox.Show("Ошибка в подключении к базе данных");
                    return;
                }
                NameSelectionLabel.Text = CurrentSelection.currentSelection.Name;
                richTextBoxAttractions.Text = route.Attractions;
                hotelRichTextBox.Text = route.Hotels;
                flightsRichTextBox.Text = route.Flight;
                durationRichTextBox.Text = route.Duration.ToString();
                budgetRichTextBox.Text = route.Budget.ToString();
                if (route.Photo != null)
                {
                    MemoryStream memoryStream = new MemoryStream(route.Photo);
                    pictureRoute.Image = Image.FromStream(memoryStream);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                var currUser = context.Users.FirstOrDefault(r => r.IdUser.Equals(CurrentUser.currentUser.IdUser));
                if (currUser == null)
                {
                    MessageBox.Show("Ошибка в подключении к базе данных");
                    return;
                }
                var currSelection = context.Selections.FirstOrDefault(r => r.Id.Equals(CurrentSelection.currentSelection.Id));
                if (currSelection == null)
                {
                    MessageBox.Show("Ошибка в подключении к базе данных");
                    return;
                }
                var route = context.Routes.FirstOrDefault(r => r.Id.Equals(currSelection.IdRoutes));
                if (currUser.IdSelection.Equals(currSelection.Id))
                {
                    currUser.IdSelection = null;
                }
                else
                {
                    if (currUser.IdSelection.Split(",").Contains(currSelection.Id))
                    {
                        currUser.IdSelection = currUser.IdSelection.Replace($"{currSelection.Id}" + ",", "").Replace("," + $"{currSelection.Id}", "").Replace($"{currSelection.Id}", "");
                    }
                    else
                    {
                        MessageBox.Show("Данная подборка уже была удалена");
                        return;
                    }
                }
                route.LikesSelection -= 1;
                Selection selection = currSelection;
                context.Selections.Remove(selection);
                context.SaveChanges();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.ShowDialog();
        }

        private void SendByMailButton_Click(object sender, EventArgs e)
        {
            using (var context = new RoutesForTouristsContext())
            {
                try
                {
                    var currRoute = context.Routes.FirstOrDefault(r => r.Id.Equals(CurrentSelection.currentSelection.IdRoutes));
                    if (currRoute == null)
                    {
                        MessageBox.Show("Ошибка в доключении к базе данных");
                        return;
                    }
                    MailAddress from = new MailAddress("papa_papa20@list.ru", "RoutesTourists");
                    MailAddress to = new MailAddress(CurrentUser.currentUser.Mail);

                    MailMessage message = new MailMessage(from, to);
                    message.Subject = CurrentSelection.currentSelection.Name;
                    message.Body = $"{currRoute.Name}" +
                        $"\n{currRoute.Attractions}" +
                        $"\n{currRoute.Hotels}" +
                        $"\n{currRoute.Flight}" +
                        $"\n{currRoute.Duration}" +
                        $"\n{currRoute.Budget}";

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.mail.ru";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(from.Address, "qx9ZZ6t7cnZQpiGSsNQX");
                    smtp.Send(message);
                    MessageBox.Show("Сообщение отправлено на почту");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Некоррекнтная почта");
                    return;
                }
            }
        }

        private void MySelectionForm_Resize(object sender, EventArgs e)
        {
            NameSelectionLabel.Top = (int)(MainPanel.Height * 0);
            NameSelectionLabel.Left = (int)(MainPanel.Width * 0.35);
            pictureRoute.Width = (int)(MainPanel.Width * 0.33);
            pictureRoute.Height = (int)(MainPanel.Height * 0.65);
            pictureRoute.Top = (int)(MainPanel.Height * 0.015) + NameSelectionLabel.Height + 10;
            pictureRoute.Left = 0;
            attractionsLabel.Top = (int)(MainPanel.Height * 0.015) + NameSelectionLabel.Height + 10;
            attractionsLabel.Left = (int)(MainPanel.Width * 0.35);
            richTextBoxAttractions.Top = (int)((MainPanel.Height + 103) * 0.015) + NameSelectionLabel.Height + attractionsLabel.Height + 10;
            richTextBoxAttractions.Left = (int)(MainPanel.Width * 0.35);
            richTextBoxAttractions.Width = (int)(MainPanel.Width * 0.64);
            richTextBoxAttractions.Height = (int)(MainPanel.Width * 0.08);
            hotelLabel.Top = (int)(MainPanel.Height * 0.015) + NameSelectionLabel.Height + attractionsLabel.Height + richTextBoxAttractions.Height + 20;
            hotelLabel.Left = (int)(MainPanel.Width * 0.35);
            hotelRichTextBox.Top = (int)((MainPanel.Height + 103) * 0.015) + NameSelectionLabel.Height + attractionsLabel.Height + richTextBoxAttractions.Height + hotelLabel.Height + 20;
            hotelRichTextBox.Left = (int)(MainPanel.Width * 0.35);
            hotelRichTextBox.Width = (int)(MainPanel.Width * 0.64);
            hotelRichTextBox.Height = (int)(MainPanel.Width * 0.08);
            flightsLabel.Top = (int)(MainPanel.Height * 0.015) + NameSelectionLabel.Height + attractionsLabel.Height + richTextBoxAttractions.Height + hotelLabel.Height + hotelRichTextBox.Height + 30;
            flightsLabel.Left = (int)(MainPanel.Width * 0.35);
            flightsRichTextBox.Top = (int)((MainPanel.Height + 103) * 0.015) + NameSelectionLabel.Height + attractionsLabel.Height + richTextBoxAttractions.Height + hotelLabel.Height + hotelRichTextBox.Height + flightsLabel.Height + 35;
            flightsRichTextBox.Left = (int)(MainPanel.Width * 0.35);
            flightsRichTextBox.Width = (int)(MainPanel.Width * 0.64);
            flightsRichTextBox.Height = (int)(MainPanel.Width * 0.08);

            durationLabel.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height + 30;
            durationLabel.Left = (int)(MainPanel.Width * 0.015);
            durationRichTextBox.Top = (int)((MainPanel.Height + 103) * 0.015) + pictureRoute.Height + 30;
            durationRichTextBox.Left = (int)(MainPanel.Width * 0.015) + 150;
            durationRichTextBox.Width = (int)(MainPanel.Width * 0.64);
            durationRichTextBox.Height = (int)(MainPanel.Width * 0.05);
            budgetLabel.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height + durationRichTextBox.Height + 40;
            budgetLabel.Left = (int)(MainPanel.Width * 0.015);
            budgetRichTextBox.Top = (int)((MainPanel.Height + 103) * 0.015) + pictureRoute.Height + durationRichTextBox.Height + 40;
            budgetRichTextBox.Left = (int)(MainPanel.Width * 0.015) + 150;
            budgetRichTextBox.Width = (int)(MainPanel.Width * 0.64);
            budgetRichTextBox.Height = (int)(MainPanel.Width * 0.05);

            DeleteButton.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height + durationRichTextBox.Height + budgetRichTextBox.Height + 60;
            DeleteButton.Left = (int)(MainPanel.Width * 0.7);
            SendByMailButton.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height + durationRichTextBox.Height + budgetRichTextBox.Height + 60;
            SendByMailButton.Left = (int)(MainPanel.Width * 0.3);
            SendByMailButton.Width = (int)((MainPanel.Width - 20) * 0.4);
            SendByMailButton.Height = (int)((MainPanel.Height + 103) * 0.06);
            DeleteButton.Width = (int)((MainPanel.Width - 20) * 0.2);
            DeleteButton.Height = (int)((MainPanel.Height + 103) * 0.06);
            BackButton.Top = (int)(MainPanel.Height * 0.015) + pictureRoute.Height + durationRichTextBox.Height + budgetRichTextBox.Height + 60;
            BackButton.Left = (int)(MainPanel.Width * 0.07);
            BackButton.Width = (int)((MainPanel.Width - 20) * 0.2);
            BackButton.Height = (int)((MainPanel.Height + 103) * 0.06);
        }
    }
}
