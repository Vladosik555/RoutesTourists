﻿using RoutesTourists.Classes;
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
        }

        private void MySelectionForm_Load(object sender, EventArgs e)
        {
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
            this.Hide();
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.ShowDialog();
        }

        private void SendByMailButton_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("papa_papa20@list.ru", "RoutesTourists");
            MailAddress to = new MailAddress("sholokhov.04@list.ru");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Крутое место";
            message.Body = "Москва";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.mail.ru";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from.Address, "qx9ZZ6t7cnZQpiGSsNQX");
            smtp.Send(message);
        }
    }
}
