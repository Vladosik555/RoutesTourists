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
            pictureRoute = new PictureBox();
            attractionsLabel = new Label();
            richTextBoxAttractions = new RichTextBox();
            hotelLabel = new Label();
            hotelRichTextBox = new RichTextBox();
            flightsLabel = new Label();
            flightsRichTextBox = new RichTextBox();
            durationLabel = new Label();
            budgetLabel = new Label();
            durationRichTextBox = new RichTextBox();
            budgetRichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).BeginInit();
            SuspendLayout();
            // 
            // pictureRoute
            // 
            pictureRoute.Location = new Point(0, 1);
            pictureRoute.Name = "pictureRoute";
            pictureRoute.Size = new Size(235, 259);
            pictureRoute.TabIndex = 0;
            pictureRoute.TabStop = false;
            // 
            // attractionsLabel
            // 
            attractionsLabel.AutoSize = true;
            attractionsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            attractionsLabel.Location = new Point(241, 9);
            attractionsLabel.Name = "attractionsLabel";
            attractionsLabel.Size = new Size(373, 21);
            attractionsLabel.TabIndex = 1;
            attractionsLabel.Text = "Достопремичательности и интересные места";
            // 
            // richTextBoxAttractions
            // 
            richTextBoxAttractions.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxAttractions.Location = new Point(241, 33);
            richTextBoxAttractions.Name = "richTextBoxAttractions";
            richTextBoxAttractions.Size = new Size(388, 57);
            richTextBoxAttractions.TabIndex = 2;
            richTextBoxAttractions.Text = "";
            // 
            // hotelLabel
            // 
            hotelLabel.AutoSize = true;
            hotelLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelLabel.Location = new Point(241, 93);
            hotelLabel.Name = "hotelLabel";
            hotelLabel.Size = new Size(167, 21);
            hotelLabel.TabIndex = 3;
            hotelLabel.Text = "Отели и гостиницы";
            // 
            // hotelRichTextBox
            // 
            hotelRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hotelRichTextBox.Location = new Point(241, 117);
            hotelRichTextBox.Name = "hotelRichTextBox";
            hotelRichTextBox.Size = new Size(388, 60);
            hotelRichTextBox.TabIndex = 4;
            hotelRichTextBox.Text = "";
            // 
            // flightsLabel
            // 
            flightsLabel.AutoSize = true;
            flightsLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsLabel.Location = new Point(241, 180);
            flightsLabel.Name = "flightsLabel";
            flightsLabel.Size = new Size(87, 21);
            flightsLabel.TabIndex = 5;
            flightsLabel.Text = "Перелёты";
            // 
            // flightsRichTextBox
            // 
            flightsRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flightsRichTextBox.Location = new Point(241, 204);
            flightsRichTextBox.Name = "flightsRichTextBox";
            flightsRichTextBox.Size = new Size(388, 56);
            flightsRichTextBox.TabIndex = 6;
            flightsRichTextBox.Text = "";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(0, 287);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(122, 21);
            durationLabel.TabIndex = 7;
            durationLabel.Text = "Длительность";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(0, 353);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(73, 21);
            budgetLabel.TabIndex = 8;
            budgetLabel.Text = "Бюджет";
            // 
            // durationRichTextBox
            // 
            durationRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationRichTextBox.Location = new Point(153, 287);
            durationRichTextBox.Name = "durationRichTextBox";
            durationRichTextBox.Size = new Size(476, 30);
            durationRichTextBox.TabIndex = 9;
            durationRichTextBox.Text = "";
            // 
            // budgetRichTextBox
            // 
            budgetRichTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetRichTextBox.Location = new Point(153, 350);
            budgetRichTextBox.Name = "budgetRichTextBox";
            budgetRichTextBox.Size = new Size(476, 30);
            budgetRichTextBox.TabIndex = 10;
            budgetRichTextBox.Text = "";
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(634, 411);
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
            Name = "DetailsForm";
            Text = "DetailsForm";
            Load += DetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureRoute;
        private Label attractionsLabel;
        private RichTextBox richTextBoxAttractions;
        private Label hotelLabel;
        private RichTextBox hotelRichTextBox;
        private Label flightsLabel;
        private RichTextBox flightsRichTextBox;
        private Label durationLabel;
        private Label budgetLabel;
        private RichTextBox durationRichTextBox;
        private RichTextBox budgetRichTextBox;
    }
}