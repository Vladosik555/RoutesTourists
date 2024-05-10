namespace RoutesTourists.Forms
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
            pictureRoute = new PictureBox();
            NameLabel = new Label();
            richTextBoxRoute = new RichTextBox();
            ВetailsButton = new Button();
            NextButton = new Button();
            likeButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureRoute).BeginInit();
            SuspendLayout();
            // 
            // pictureRoute
            // 
            pictureRoute.Location = new Point(0, 0);
            pictureRoute.Name = "pictureRoute";
            pictureRoute.Size = new Size(202, 355);
            pictureRoute.TabIndex = 0;
            pictureRoute.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(208, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(133, 31);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Название";
            // 
            // richTextBoxRoute
            // 
            richTextBoxRoute.BackColor = Color.White;
            richTextBoxRoute.Location = new Point(208, 43);
            richTextBoxRoute.Name = "richTextBoxRoute";
            richTextBoxRoute.ReadOnly = true;
            richTextBoxRoute.Size = new Size(420, 312);
            richTextBoxRoute.TabIndex = 2;
            richTextBoxRoute.Text = "";
            // 
            // ВetailsButton
            // 
            ВetailsButton.BackColor = Color.Cyan;
            ВetailsButton.FlatAppearance.BorderSize = 0;
            ВetailsButton.FlatStyle = FlatStyle.Flat;
            ВetailsButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ВetailsButton.Location = new Point(362, 364);
            ВetailsButton.Name = "ВetailsButton";
            ВetailsButton.Size = new Size(150, 30);
            ВetailsButton.TabIndex = 3;
            ВetailsButton.Text = "Узнать подробнее";
            ВetailsButton.UseVisualStyleBackColor = false;
            ВetailsButton.Click += ВetailsButton_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.Cyan;
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NextButton.Location = new Point(518, 364);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(110, 30);
            NextButton.TabIndex = 4;
            NextButton.Text = "Следующее";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // likeButton
            // 
            likeButton.BackColor = Color.Cyan;
            likeButton.FlatAppearance.BorderSize = 0;
            likeButton.FlatStyle = FlatStyle.Flat;
            likeButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            likeButton.Location = new Point(256, 364);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(100, 30);
            likeButton.TabIndex = 5;
            likeButton.Text = "Оценить";
            likeButton.UseVisualStyleBackColor = false;
            likeButton.Click += likeButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(160, 364);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(90, 30);
            BackButton.TabIndex = 6;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // RecommenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 402);
            Controls.Add(BackButton);
            Controls.Add(likeButton);
            Controls.Add(NextButton);
            Controls.Add(ВetailsButton);
            Controls.Add(richTextBoxRoute);
            Controls.Add(NameLabel);
            Controls.Add(pictureRoute);
            Name = "RecommenForm";
            Text = "RecommenForm";
            Load += RecommenForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureRoute;
        private Label NameLabel;
        private RichTextBox richTextBoxRoute;
        private Button ВetailsButton;
        private Button NextButton;
        private Button likeButton;
        private Button BackButton;
    }
}