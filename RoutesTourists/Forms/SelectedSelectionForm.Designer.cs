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
            deleteButton.Location = new Point(354, 426);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 30);
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
            AddSelectionButton.Location = new Point(460, 426);
            AddSelectionButton.Name = "AddSelectionButton";
            AddSelectionButton.Size = new Size(169, 30);
            AddSelectionButton.TabIndex = 24;
            AddSelectionButton.Text = "Добавить в подборку";
            AddSelectionButton.UseVisualStyleBackColor = false;
            AddSelectionButton.Visible = false;
            AddSelectionButton.Click += AddSelectionButton_Click;
            // 
            // budgetRichTextBox
            // 
            budgetRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetRichTextBox.Location = new Point(153, 390);
            budgetRichTextBox.Name = "budgetRichTextBox";
            budgetRichTextBox.Size = new Size(476, 30);
            budgetRichTextBox.TabIndex = 23;
            budgetRichTextBox.Text = "";
            // 
            // durationRichTextBox
            // 
            durationRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationRichTextBox.Location = new Point(153, 338);
            durationRichTextBox.Name = "durationRichTextBox";
            durationRichTextBox.Size = new Size(476, 30);
            durationRichTextBox.TabIndex = 22;
            durationRichTextBox.Text = "";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(0, 390);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(73, 21);
            budgetLabel.TabIndex = 21;
            budgetLabel.Text = "Бюджет";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(0, 338);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(122, 21);
            durationLabel.TabIndex = 20;
            durationLabel.Text = "Длительность";
            // 
            // flightsRichTextBox
            // 
            flightsRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsRichTextBox.Location = new Point(241, 255);
            flightsRichTextBox.Name = "flightsRichTextBox";
            flightsRichTextBox.Size = new Size(388, 56);
            flightsRichTextBox.TabIndex = 19;
            flightsRichTextBox.Text = "";
            // 
            // flightsLabel
            // 
            flightsLabel.AutoSize = true;
            flightsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsLabel.Location = new Point(241, 231);
            flightsLabel.Name = "flightsLabel";
            flightsLabel.Size = new Size(87, 21);
            flightsLabel.TabIndex = 18;
            flightsLabel.Text = "Перелёты";
            // 
            // hotelRichTextBox
            // 
            hotelRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelRichTextBox.Location = new Point(241, 168);
            hotelRichTextBox.Name = "hotelRichTextBox";
            hotelRichTextBox.Size = new Size(388, 60);
            hotelRichTextBox.TabIndex = 17;
            hotelRichTextBox.Text = "";
            // 
            // hotelLabel
            // 
            hotelLabel.AutoSize = true;
            hotelLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelLabel.Location = new Point(241, 144);
            hotelLabel.Name = "hotelLabel";
            hotelLabel.Size = new Size(167, 21);
            hotelLabel.TabIndex = 16;
            hotelLabel.Text = "Отели и гостиницы";
            // 
            // richTextBoxAttractions
            // 
            richTextBoxAttractions.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxAttractions.Location = new Point(241, 84);
            richTextBoxAttractions.Name = "richTextBoxAttractions";
            richTextBoxAttractions.Size = new Size(388, 57);
            richTextBoxAttractions.TabIndex = 15;
            richTextBoxAttractions.Text = "";
            // 
            // attractionsLabel
            // 
            attractionsLabel.AutoSize = true;
            attractionsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            attractionsLabel.Location = new Point(241, 60);
            attractionsLabel.Name = "attractionsLabel";
            attractionsLabel.Size = new Size(373, 21);
            attractionsLabel.TabIndex = 14;
            attractionsLabel.Text = "Достопремичательности и интересные места";
            // 
            // pictureRoute
            // 
            pictureRoute.Location = new Point(0, 52);
            pictureRoute.Name = "pictureRoute";
            pictureRoute.Size = new Size(235, 259);
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
            BackButton.Location = new Point(-1, 427);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 29);
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
            NameLabel.Location = new Point(0, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(225, 26);
            NameLabel.TabIndex = 101;
            NameLabel.Text = "Название подборки";
            // 
            // NameSelectionText
            // 
            NameSelectionText.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameSelectionText.ForeColor = Color.Gray;
            NameSelectionText.Location = new Point(241, 9);
            NameSelectionText.Name = "NameSelectionText";
            NameSelectionText.Size = new Size(388, 30);
            NameSelectionText.TabIndex = 102;
            NameSelectionText.Text = "Запишите название подборки";
            NameSelectionText.Enter += NameSelectionText_Enter;
            NameSelectionText.Leave += NameSelectionText_Leave;
            // 
            // SelectedSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(628, 457);
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