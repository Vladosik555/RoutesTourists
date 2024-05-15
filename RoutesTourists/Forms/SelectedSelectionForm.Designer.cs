namespace RoutesTourists.Forms
{
    partial class SelectedSelectionForm
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
            deleteButton = new Button();
            AddSelectionButton = new Button();
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
            BackButton = new Button();
            NameLabel = new Label();
            NameSelectionText = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).BeginInit();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Cyan;
            deleteButton.Enabled = false;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(405, 568);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(114, 40);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // AddSelectionButton
            // 
            AddSelectionButton.BackColor = Color.Cyan;
            AddSelectionButton.Enabled = false;
            AddSelectionButton.FlatAppearance.BorderSize = 0;
            AddSelectionButton.FlatStyle = FlatStyle.Flat;
            AddSelectionButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddSelectionButton.Location = new Point(526, 568);
            AddSelectionButton.Margin = new Padding(3, 4, 3, 4);
            AddSelectionButton.Name = "AddSelectionButton";
            AddSelectionButton.Size = new Size(193, 40);
            AddSelectionButton.TabIndex = 24;
            AddSelectionButton.Text = "Добавить в подборку";
            AddSelectionButton.UseVisualStyleBackColor = false;
            AddSelectionButton.Visible = false;
            AddSelectionButton.Click += AddSelectionButton_Click;
            // 
            // budgetRichTextBox
            // 
            budgetRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetRichTextBox.Location = new Point(175, 520);
            budgetRichTextBox.Margin = new Padding(3, 4, 3, 4);
            budgetRichTextBox.Name = "budgetRichTextBox";
            budgetRichTextBox.Size = new Size(543, 39);
            budgetRichTextBox.TabIndex = 23;
            budgetRichTextBox.Text = "";
            // 
            // durationRichTextBox
            // 
            durationRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationRichTextBox.Location = new Point(175, 451);
            durationRichTextBox.Margin = new Padding(3, 4, 3, 4);
            durationRichTextBox.Name = "durationRichTextBox";
            durationRichTextBox.Size = new Size(543, 39);
            durationRichTextBox.TabIndex = 22;
            durationRichTextBox.Text = "";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(0, 520);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(93, 27);
            budgetLabel.TabIndex = 21;
            budgetLabel.Text = "Бюджет";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(0, 451);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(155, 27);
            durationLabel.TabIndex = 20;
            durationLabel.Text = "Длительность";
            // 
            // flightsRichTextBox
            // 
            flightsRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsRichTextBox.Location = new Point(275, 340);
            flightsRichTextBox.Margin = new Padding(3, 4, 3, 4);
            flightsRichTextBox.Name = "flightsRichTextBox";
            flightsRichTextBox.Size = new Size(443, 73);
            flightsRichTextBox.TabIndex = 19;
            flightsRichTextBox.Text = "";
            // 
            // flightsLabel
            // 
            flightsLabel.AutoSize = true;
            flightsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsLabel.Location = new Point(275, 308);
            flightsLabel.Name = "flightsLabel";
            flightsLabel.Size = new Size(112, 27);
            flightsLabel.TabIndex = 18;
            flightsLabel.Text = "Перелёты";
            // 
            // hotelRichTextBox
            // 
            hotelRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelRichTextBox.Location = new Point(275, 224);
            hotelRichTextBox.Margin = new Padding(3, 4, 3, 4);
            hotelRichTextBox.Name = "hotelRichTextBox";
            hotelRichTextBox.Size = new Size(443, 79);
            hotelRichTextBox.TabIndex = 17;
            hotelRichTextBox.Text = "";
            // 
            // hotelLabel
            // 
            hotelLabel.AutoSize = true;
            hotelLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelLabel.Location = new Point(275, 192);
            hotelLabel.Name = "hotelLabel";
            hotelLabel.Size = new Size(211, 27);
            hotelLabel.TabIndex = 16;
            hotelLabel.Text = "Отели и гостиницы";
            // 
            // richTextBoxAttractions
            // 
            richTextBoxAttractions.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxAttractions.Location = new Point(275, 112);
            richTextBoxAttractions.Margin = new Padding(3, 4, 3, 4);
            richTextBoxAttractions.Name = "richTextBoxAttractions";
            richTextBoxAttractions.Size = new Size(443, 75);
            richTextBoxAttractions.TabIndex = 15;
            richTextBoxAttractions.Text = "";
            // 
            // attractionsLabel
            // 
            attractionsLabel.AutoSize = true;
            attractionsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            attractionsLabel.Location = new Point(275, 80);
            attractionsLabel.Name = "attractionsLabel";
            attractionsLabel.Size = new Size(476, 27);
            attractionsLabel.TabIndex = 14;
            attractionsLabel.Text = "Достопремичательности и интересные места";
            // 
            // pictureRoute
            // 
            pictureRoute.Location = new Point(0, 69);
            pictureRoute.Margin = new Padding(3, 4, 3, 4);
            pictureRoute.Name = "pictureRoute";
            pictureRoute.Size = new Size(269, 345);
            pictureRoute.TabIndex = 13;
            pictureRoute.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(17, 569);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 39);
            BackButton.TabIndex = 100;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.None;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(18, 12);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(276, 35);
            NameLabel.TabIndex = 101;
            NameLabel.Text = "Название подборки";
            // 
            // NameSelectionText
            // 
            NameSelectionText.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameSelectionText.ForeColor = Color.Gray;
            NameSelectionText.Location = new Point(275, 12);
            NameSelectionText.Margin = new Padding(3, 4, 3, 4);
            NameSelectionText.Name = "NameSelectionText";
            NameSelectionText.Size = new Size(443, 39);
            NameSelectionText.TabIndex = 102;
            NameSelectionText.Text = "Запишите название подборки";
            NameSelectionText.Enter += NameSelectionText_Enter;
            NameSelectionText.Leave += NameSelectionText_Leave;
            // 
            // SelectedSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 609);
            Controls.Add(NameSelectionText);
            Controls.Add(NameLabel);
            Controls.Add(BackButton);
            Controls.Add(deleteButton);
            Controls.Add(AddSelectionButton);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "SelectedSelectionForm";
            Text = "SelectedSelectionForm";
            Load += SelectedSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private Button AddSelectionButton;
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
        private Button BackButton;
        private Label NameLabel;
        private RichTextBox NameSelectionText;
    }
}