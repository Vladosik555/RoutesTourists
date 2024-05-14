namespace RoutesTourists.Forms
{
    partial class DetailsForm
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
            MainPanel = new Panel();
            deleteButton = new Button();
            likeButton = new Button();
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
            // MainPanel
            // 
            MainPanel.Controls.Add(deleteButton);
            MainPanel.Controls.Add(likeButton);
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
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(900, 528);
            MainPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Cyan;
            deleteButton.Enabled = false;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(630, 484);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(114, 40);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // likeButton
            // 
            likeButton.BackColor = Color.Cyan;
            likeButton.Enabled = false;
            likeButton.FlatAppearance.BorderSize = 0;
            likeButton.FlatStyle = FlatStyle.Flat;
            likeButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            likeButton.Location = new Point(750, 484);
            likeButton.Margin = new Padding(3, 4, 3, 4);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(114, 40);
            likeButton.TabIndex = 24;
            likeButton.Text = "Оценить";
            likeButton.UseVisualStyleBackColor = false;
            likeButton.Visible = false;
            likeButton.Click += likeButton_Click;
            // 
            // budgetRichTextBox
            // 
            budgetRichTextBox.BackColor = SystemColors.ControlLightLight;
            budgetRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetRichTextBox.Location = new Point(175, 427);
            budgetRichTextBox.Margin = new Padding(3, 4, 3, 4);
            budgetRichTextBox.Name = "budgetRichTextBox";
            budgetRichTextBox.ReadOnly = true;
            budgetRichTextBox.Size = new Size(689, 39);
            budgetRichTextBox.TabIndex = 23;
            budgetRichTextBox.Text = "";
            // 
            // durationRichTextBox
            // 
            durationRichTextBox.BackColor = SystemColors.ControlLightLight;
            durationRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationRichTextBox.Location = new Point(175, 368);
            durationRichTextBox.Margin = new Padding(3, 4, 3, 4);
            durationRichTextBox.Name = "durationRichTextBox";
            durationRichTextBox.ReadOnly = true;
            durationRichTextBox.Size = new Size(689, 39);
            durationRichTextBox.TabIndex = 22;
            durationRichTextBox.Text = "";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(12, 430);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(93, 27);
            budgetLabel.TabIndex = 21;
            budgetLabel.Text = "Бюджет";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(0, 371);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(155, 27);
            durationLabel.TabIndex = 20;
            durationLabel.Text = "Длительность";
            // 
            // flightsRichTextBox
            // 
            flightsRichTextBox.BackColor = SystemColors.ControlLightLight;
            flightsRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsRichTextBox.Location = new Point(275, 260);
            flightsRichTextBox.Margin = new Padding(3, 4, 3, 4);
            flightsRichTextBox.Name = "flightsRichTextBox";
            flightsRichTextBox.ReadOnly = true;
            flightsRichTextBox.Size = new Size(589, 73);
            flightsRichTextBox.TabIndex = 19;
            flightsRichTextBox.Text = "";
            // 
            // flightsLabel
            // 
            flightsLabel.AutoSize = true;
            flightsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsLabel.Location = new Point(275, 228);
            flightsLabel.Name = "flightsLabel";
            flightsLabel.Size = new Size(112, 27);
            flightsLabel.TabIndex = 18;
            flightsLabel.Text = "Перелёты";
            // 
            // hotelRichTextBox
            // 
            hotelRichTextBox.BackColor = SystemColors.ControlLightLight;
            hotelRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelRichTextBox.Location = new Point(275, 144);
            hotelRichTextBox.Margin = new Padding(3, 4, 3, 4);
            hotelRichTextBox.Name = "hotelRichTextBox";
            hotelRichTextBox.ReadOnly = true;
            hotelRichTextBox.Size = new Size(589, 79);
            hotelRichTextBox.TabIndex = 17;
            hotelRichTextBox.Text = "";
            // 
            // hotelLabel
            // 
            hotelLabel.AutoSize = true;
            hotelLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelLabel.Location = new Point(275, 112);
            hotelLabel.Name = "hotelLabel";
            hotelLabel.Size = new Size(211, 27);
            hotelLabel.TabIndex = 16;
            hotelLabel.Text = "Отели и гостиницы";
            // 
            // richTextBoxAttractions
            // 
            richTextBoxAttractions.BackColor = SystemColors.ControlLightLight;
            richTextBoxAttractions.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxAttractions.Location = new Point(275, 32);
            richTextBoxAttractions.Margin = new Padding(3, 4, 3, 4);
            richTextBoxAttractions.Name = "richTextBoxAttractions";
            richTextBoxAttractions.ReadOnly = true;
            richTextBoxAttractions.Size = new Size(589, 75);
            richTextBoxAttractions.TabIndex = 15;
            richTextBoxAttractions.Text = "";
            // 
            // attractionsLabel
            // 
            attractionsLabel.AutoSize = true;
            attractionsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            attractionsLabel.Location = new Point(275, 0);
            attractionsLabel.Name = "attractionsLabel";
            attractionsLabel.Size = new Size(475, 27);
            attractionsLabel.TabIndex = 14;
            attractionsLabel.Text = "Достопримечательности и интересные места";
            // 
            // pictureRoute
            // 
            pictureRoute.Location = new Point(-13, 5);
            pictureRoute.Margin = new Padding(3, 4, 3, 4);
            pictureRoute.Name = "pictureRoute";
            pictureRoute.Size = new Size(269, 345);
            pictureRoute.TabIndex = 13;
            pictureRoute.TabStop = false;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 528);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(400, 400);
            Name = "DetailsForm";
            Text = "DetailsForm";
            Load += DetailsForm_Load;
            Resize += DetailsForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button deleteButton;
        private Button likeButton;
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