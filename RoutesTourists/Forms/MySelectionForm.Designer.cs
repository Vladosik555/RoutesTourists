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
            NameSelectionLabel = new Label();
            BackButton = new Button();
            DeleteButton = new Button();
            SendByMailButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).BeginInit();
            SuspendLayout();
            // 
            // budgetRichTextBox
            // 
            budgetRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetRichTextBox.Location = new Point(151, 392);
            budgetRichTextBox.Name = "budgetRichTextBox";
            budgetRichTextBox.Size = new Size(476, 30);
            budgetRichTextBox.TabIndex = 21;
            budgetRichTextBox.Text = "";
            // 
            // durationRichTextBox
            // 
            durationRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationRichTextBox.Location = new Point(151, 340);
            durationRichTextBox.Name = "durationRichTextBox";
            durationRichTextBox.Size = new Size(476, 30);
            durationRichTextBox.TabIndex = 20;
            durationRichTextBox.Text = "";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(-2, 392);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(73, 21);
            budgetLabel.TabIndex = 19;
            budgetLabel.Text = "Бюджет";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(-2, 340);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(122, 21);
            durationLabel.TabIndex = 18;
            durationLabel.Text = "Длительность";
            // 
            // flightsRichTextBox
            // 
            flightsRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsRichTextBox.Location = new Point(239, 257);
            flightsRichTextBox.Name = "flightsRichTextBox";
            flightsRichTextBox.Size = new Size(388, 56);
            flightsRichTextBox.TabIndex = 17;
            flightsRichTextBox.Text = "";
            // 
            // flightsLabel
            // 
            flightsLabel.AutoSize = true;
            flightsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsLabel.Location = new Point(239, 233);
            flightsLabel.Name = "flightsLabel";
            flightsLabel.Size = new Size(87, 21);
            flightsLabel.TabIndex = 16;
            flightsLabel.Text = "Перелёты";
            // 
            // hotelRichTextBox
            // 
            hotelRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelRichTextBox.Location = new Point(239, 170);
            hotelRichTextBox.Name = "hotelRichTextBox";
            hotelRichTextBox.Size = new Size(388, 60);
            hotelRichTextBox.TabIndex = 15;
            hotelRichTextBox.Text = "";
            // 
            // hotelLabel
            // 
            hotelLabel.AutoSize = true;
            hotelLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelLabel.Location = new Point(239, 146);
            hotelLabel.Name = "hotelLabel";
            hotelLabel.Size = new Size(167, 21);
            hotelLabel.TabIndex = 14;
            hotelLabel.Text = "Отели и гостиницы";
            // 
            // richTextBoxAttractions
            // 
            richTextBoxAttractions.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxAttractions.Location = new Point(239, 86);
            richTextBoxAttractions.Name = "richTextBoxAttractions";
            richTextBoxAttractions.Size = new Size(388, 57);
            richTextBoxAttractions.TabIndex = 13;
            richTextBoxAttractions.Text = "";
            // 
            // attractionsLabel
            // 
            attractionsLabel.AutoSize = true;
            attractionsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            attractionsLabel.Location = new Point(239, 62);
            attractionsLabel.Name = "attractionsLabel";
            attractionsLabel.Size = new Size(373, 21);
            attractionsLabel.TabIndex = 12;
            attractionsLabel.Text = "Достопремичательности и интересные места";
            // 
            // pictureRoute
            // 
            pictureRoute.Location = new Point(-2, 54);
            pictureRoute.Name = "pictureRoute";
            pictureRoute.Size = new Size(235, 259);
            pictureRoute.TabIndex = 11;
            pictureRoute.TabStop = false;
            // 
            // NameSelectionLabel
            // 
            NameSelectionLabel.AutoSize = true;
            NameSelectionLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameSelectionLabel.Location = new Point(-2, 18);
            NameSelectionLabel.Name = "NameSelectionLabel";
            NameSelectionLabel.Size = new Size(182, 23);
            NameSelectionLabel.TabIndex = 22;
            NameSelectionLabel.Text = "Название подборки";
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(-1, 447);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 29);
            BackButton.TabIndex = 23;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.None;
            DeleteButton.BackColor = Color.Cyan;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleteButton.Location = new Point(517, 447);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(121, 29);
            DeleteButton.TabIndex = 24;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SendByMailButton
            // 
            SendByMailButton.Anchor = AnchorStyles.None;
            SendByMailButton.BackColor = Color.Cyan;
            SendByMailButton.FlatAppearance.BorderSize = 0;
            SendByMailButton.FlatStyle = FlatStyle.Flat;
            SendByMailButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SendByMailButton.Location = new Point(288, 447);
            SendByMailButton.Name = "SendByMailButton";
            SendByMailButton.Size = new Size(209, 29);
            SendByMailButton.TabIndex = 25;
            SendByMailButton.Text = "Отправить на почту";
            SendByMailButton.UseVisualStyleBackColor = false;
            SendByMailButton.Click += SendByMailButton_Click;
            // 
            // MySelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 474);
            Controls.Add(SendByMailButton);
            Controls.Add(DeleteButton);
            Controls.Add(BackButton);
            Controls.Add(NameSelectionLabel);
            Controls.Add(budgetRichTextBox);
            Controls.Add(durationRichTextBox);
            Controls.Add(budgetLabel);
            Controls.Add(durationLabel);
            Controls.Add(flightsRichTextBox);
            Controls.Add(flightsLabel);
            Controls.Add(hotelRichTextBox);
            Controls.Add(hotelLabel);
            Controls.Add(richTextBoxAttractions);
            Controls.Add(attractionsLabel);
            Controls.Add(pictureRoute);
            Name = "MySelectionForm";
            Text = "MySelectionForm";
            Load += MySelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label NameSelectionLabel;
        private Button BackButton;
        private Button DeleteButton;
        private Button SendByMailButton;
    }
}