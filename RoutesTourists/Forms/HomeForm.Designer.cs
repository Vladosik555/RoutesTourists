namespace RoutesTourists
{
    partial class HomeForm
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
            EntryLabel = new Label();
            label2 = new Label();
            RecommenButton = new Button();
            FavoritesButton = new Button();
            CharacteristicsButton = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(800, 78);
            EntryLabel.TabIndex = 1;
            EntryLabel.Text = "Профиль";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Cyan;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(220, 78);
            label2.Name = "label2";
            label2.Size = new Size(10, 373);
            label2.TabIndex = 42;
            // 
            // RecommenButton
            // 
            RecommenButton.BackColor = Color.Cyan;
            RecommenButton.FlatAppearance.BorderSize = 0;
            RecommenButton.FlatStyle = FlatStyle.Flat;
            RecommenButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RecommenButton.Location = new Point(12, 102);
            RecommenButton.Name = "RecommenButton";
            RecommenButton.Size = new Size(191, 36);
            RecommenButton.TabIndex = 43;
            RecommenButton.Text = "Рекомендации";
            RecommenButton.UseVisualStyleBackColor = false;
            RecommenButton.Click += RecommenButton_Click;
            // 
            // FavoritesButton
            // 
            FavoritesButton.BackColor = Color.Cyan;
            FavoritesButton.FlatAppearance.BorderSize = 0;
            FavoritesButton.FlatStyle = FlatStyle.Flat;
            FavoritesButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FavoritesButton.Location = new Point(12, 160);
            FavoritesButton.Name = "FavoritesButton";
            FavoritesButton.Size = new Size(191, 36);
            FavoritesButton.TabIndex = 44;
            FavoritesButton.Text = "Избранное";
            FavoritesButton.UseVisualStyleBackColor = false;
            FavoritesButton.Click += FavoritesButton_Click;
            // 
            // CharacteristicsButton
            // 
            CharacteristicsButton.BackColor = Color.Cyan;
            CharacteristicsButton.FlatAppearance.BorderSize = 0;
            CharacteristicsButton.FlatStyle = FlatStyle.Flat;
            CharacteristicsButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CharacteristicsButton.Location = new Point(12, 221);
            CharacteristicsButton.Name = "CharacteristicsButton";
            CharacteristicsButton.Size = new Size(191, 36);
            CharacteristicsButton.TabIndex = 45;
            CharacteristicsButton.Text = "Характеристики";
            CharacteristicsButton.UseVisualStyleBackColor = false;
            CharacteristicsButton.Click += CharacteristicsButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(12, 285);
            button3.Name = "button3";
            button3.Size = new Size(191, 36);
            button3.TabIndex = 46;
            button3.Text = "Подборки";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Cyan;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(12, 350);
            button4.Name = "button4";
            button4.Size = new Size(191, 36);
            button4.TabIndex = 47;
            button4.Text = "Свои подборки";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Cyan;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.Location = new Point(12, 415);
            button5.Name = "button5";
            button5.Size = new Size(191, 36);
            button5.TabIndex = 48;
            button5.Text = "Вход";
            button5.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(CharacteristicsButton);
            Controls.Add(FavoritesButton);
            Controls.Add(RecommenButton);
            Controls.Add(label2);
            Controls.Add(EntryLabel);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Label EntryLabel;
        private Label label2;
        private Button RecommenButton;
        private Button FavoritesButton;
        private Button CharacteristicsButton;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}