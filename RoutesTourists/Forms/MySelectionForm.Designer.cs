namespace RoutesTourists.Forms
{
    partial class MySelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameSelectionLabel = new Label();
            MainPanel = new Panel();
            SendByMailButton = new Button();
            DeleteButton = new Button();
            BackButton = new Button();
            budgetRichTextBox = new RichTextBox();
            durationRichTextBox = new RichTextBox();
            budgetLabel = new Label();
            durationLabel = new Label();
            flightsRichTextBox = new RichTextBox();
            flightsLabel = new Label();
            hotelRichTextBox = new RichTextBox();
            hotelLabel = new Label();
            richTextBoxAttractions = new RichTextBox();
            attractionsLabel = new Label();
            pictureRoute = new PictureBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).BeginInit();
            SuspendLayout();
            // 
            // NameSelectionLabel
            // 
            NameSelectionLabel.AutoSize = true;
            NameSelectionLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameSelectionLabel.Location = new Point(241, 7);
            NameSelectionLabel.Name = "NameSelectionLabel";
            NameSelectionLabel.Size = new Size(182, 23);
            NameSelectionLabel.TabIndex = 22;
            NameSelectionLabel.Text = "Название подборки";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(SendByMailButton);
            MainPanel.Controls.Add(DeleteButton);
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(budgetRichTextBox);
            MainPanel.Controls.Add(durationRichTextBox);
            MainPanel.Controls.Add(budgetLabel);
            MainPanel.Controls.Add(durationLabel);
            MainPanel.Controls.Add(flightsRichTextBox);
            MainPanel.Controls.Add(flightsLabel);
            MainPanel.Controls.Add(hotelRichTextBox);
            MainPanel.Controls.Add(hotelLabel);
            MainPanel.Controls.Add(richTextBoxAttractions);
            MainPanel.Controls.Add(attractionsLabel);
            MainPanel.Controls.Add(pictureRoute);
            MainPanel.Controls.Add(NameSelectionLabel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(639, 474);
            MainPanel.TabIndex = 23;
            // 
            // SendByMailButton
            // 
            SendByMailButton.Anchor = AnchorStyles.None;
            SendByMailButton.BackColor = Color.Cyan;
            SendByMailButton.FlatAppearance.BorderSize = 0;
            SendByMailButton.FlatStyle = FlatStyle.Flat;
            SendByMailButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SendByMailButton.Location = new Point(282, 429);
            SendByMailButton.Name = "SendByMailButton";
            SendByMailButton.Size = new Size(209, 29);
            SendByMailButton.TabIndex = 39;
            SendByMailButton.Text = "Отправить на почту";
            SendByMailButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.None;
            DeleteButton.BackColor = Color.Cyan;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleteButton.Location = new Point(508, 429);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(121, 29);
            DeleteButton.TabIndex = 38;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(1, 429);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 29);
            BackButton.TabIndex = 37;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click_1;
            // 
            // budgetRichTextBox
            // 
            budgetRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetRichTextBox.Location = new Point(153, 374);
            budgetRichTextBox.Name = "budgetRichTextBox";
            budgetRichTextBox.Size = new Size(476, 30);
            budgetRichTextBox.TabIndex = 36;
            budgetRichTextBox.Text = "";
            // 
            // durationRichTextBox
            // 
            durationRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationRichTextBox.Location = new Point(153, 322);
            durationRichTextBox.Name = "durationRichTextBox";
            durationRichTextBox.Size = new Size(476, 30);
            durationRichTextBox.TabIndex = 35;
            durationRichTextBox.Text = "";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(0, 374);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(73, 21);
            budgetLabel.TabIndex = 34;
            budgetLabel.Text = "Бюджет";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(0, 322);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(122, 21);
            durationLabel.TabIndex = 33;
            durationLabel.Text = "Длительность";
            // 
            // flightsRichTextBox
            // 
            flightsRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsRichTextBox.Location = new Point(241, 239);
            flightsRichTextBox.Name = "flightsRichTextBox";
            flightsRichTextBox.Size = new Size(388, 56);
            flightsRichTextBox.TabIndex = 32;
            flightsRichTextBox.Text = "";
            // 
            // flightsLabel
            // 
            flightsLabel.AutoSize = true;
            flightsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsLabel.Location = new Point(241, 215);
            flightsLabel.Name = "flightsLabel";
            flightsLabel.Size = new Size(87, 21);
            flightsLabel.TabIndex = 31;
            flightsLabel.Text = "Перелёты";
            // 
            // hotelRichTextBox
            // 
            hotelRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelRichTextBox.Location = new Point(241, 152);
            hotelRichTextBox.Name = "hotelRichTextBox";
            hotelRichTextBox.Size = new Size(388, 60);
            hotelRichTextBox.TabIndex = 30;
            hotelRichTextBox.Text = "";
            // 
            // hotelLabel
            // 
            hotelLabel.AutoSize = true;
            hotelLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelLabel.Location = new Point(241, 128);
            hotelLabel.Name = "hotelLabel";
            hotelLabel.Size = new Size(167, 21);
            hotelLabel.TabIndex = 29;
            hotelLabel.Text = "Отели и гостиницы";
            // 
            // richTextBoxAttractions
            // 
            richTextBoxAttractions.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxAttractions.Location = new Point(241, 68);
            richTextBoxAttractions.Name = "richTextBoxAttractions";
            richTextBoxAttractions.Size = new Size(388, 57);
            richTextBoxAttractions.TabIndex = 28;
            richTextBoxAttractions.Text = "";
            // 
            // attractionsLabel
            // 
            attractionsLabel.AutoSize = true;
            attractionsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            attractionsLabel.Location = new Point(241, 44);
            attractionsLabel.Name = "attractionsLabel";
            attractionsLabel.Size = new Size(373, 21);
            attractionsLabel.TabIndex = 27;
            attractionsLabel.Text = "Достопримечательности и интересные места";
            // 
            // pictureRoute
            // 
            pictureRoute.Location = new Point(0, 36);
            pictureRoute.Name = "pictureRoute";
            pictureRoute.Size = new Size(235, 259);
            pictureRoute.TabIndex = 26;
            pictureRoute.TabStop = false;
            // 
            // MySelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 474);
            Controls.Add(MainPanel);
            MinimumSize = new Size(352, 400);
            Name = "MySelectionForm";
            Text = "MySelectionForm";
            Load += MySelectionForm_Load;
            Resize += MySelectionForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label NameSelectionLabel;
        private Panel MainPanel;
        private Button SendByMailButton;
        private Button DeleteButton;
        private Button BackButton;
        private RichTextBox budgetRichTextBox;
        private RichTextBox durationRichTextBox;
        private Label budgetLabel;
        private Label durationLabel;
        private RichTextBox flightsRichTextBox;
        private Label flightsLabel;
        private RichTextBox hotelRichTextBox;
        private Label hotelLabel;
        private RichTextBox richTextBoxAttractions;
        private Label attractionsLabel;
        private PictureBox pictureRoute;
    }
}