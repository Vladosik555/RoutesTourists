﻿namespace RoutesTourists.Forms
{
    partial class RecommenForm
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
            BackButton = new Button();
            likeButton = new Button();
            NextButton = new Button();
            ВetailsButton = new Button();
            richTextBoxRoute = new RichTextBox();
            NameLabel = new Label();
            pictureRoute = new PictureBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(likeButton);
            MainPanel.Controls.Add(NextButton);
            MainPanel.Controls.Add(ВetailsButton);
            MainPanel.Controls.Add(richTextBoxRoute);
            MainPanel.Controls.Add(NameLabel);
            MainPanel.Controls.Add(pictureRoute);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(719, 536);
            MainPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(183, 491);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(103, 40);
            BackButton.TabIndex = 13;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // likeButton
            // 
            likeButton.BackColor = Color.Cyan;
            likeButton.FlatAppearance.BorderSize = 0;
            likeButton.FlatStyle = FlatStyle.Flat;
            likeButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            likeButton.Location = new Point(293, 491);
            likeButton.Margin = new Padding(3, 4, 3, 4);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(114, 40);
            likeButton.TabIndex = 12;
            likeButton.Text = "Оценить";
            likeButton.UseVisualStyleBackColor = false;
            likeButton.Click += likeButton_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.Cyan;
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NextButton.Location = new Point(592, 491);
            NextButton.Margin = new Padding(3, 4, 3, 4);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(126, 40);
            NextButton.TabIndex = 11;
            NextButton.Text = "Следующее";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // ВetailsButton
            // 
            ВetailsButton.BackColor = Color.Cyan;
            ВetailsButton.FlatAppearance.BorderSize = 0;
            ВetailsButton.FlatStyle = FlatStyle.Flat;
            ВetailsButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ВetailsButton.Location = new Point(414, 491);
            ВetailsButton.Margin = new Padding(3, 4, 3, 4);
            ВetailsButton.Name = "ВetailsButton";
            ВetailsButton.Size = new Size(171, 40);
            ВetailsButton.TabIndex = 10;
            ВetailsButton.Text = "Узнать подробнее";
            ВetailsButton.UseVisualStyleBackColor = false;
            ВetailsButton.Click += ВetailsButton_Click;
            // 
            // richTextBoxRoute
            // 
            richTextBoxRoute.BackColor = Color.White;
            richTextBoxRoute.Location = new Point(238, 63);
            richTextBoxRoute.Margin = new Padding(3, 4, 3, 4);
            richTextBoxRoute.Name = "richTextBoxRoute";
            richTextBoxRoute.ReadOnly = true;
            richTextBoxRoute.Size = new Size(479, 415);
            richTextBoxRoute.TabIndex = 9;
            richTextBoxRoute.Text = "";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(238, 18);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(164, 38);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "Название";
            // 
            // pictureRoute
            // 
            pictureRoute.Anchor = AnchorStyles.None;
            pictureRoute.Location = new Point(0, 4);
            pictureRoute.Margin = new Padding(3, 4, 3, 4);
            pictureRoute.Name = "pictureRoute";
            pictureRoute.Size = new Size(231, 475);
            pictureRoute.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureRoute.TabIndex = 7;
            pictureRoute.TabStop = false;
            // 
            // RecommenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(719, 536);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(600, 400);
            Name = "RecommenForm";
            Text = "RecommenForm";
            Load += RecommenForm_Load;
            Resize += RecommenForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button BackButton;
        private Button likeButton;
        private Button NextButton;
        private Button ВetailsButton;
        private RichTextBox richTextBoxRoute;
        private Label NameLabel;
        private PictureBox pictureRoute;
    }
}