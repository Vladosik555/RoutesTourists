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
            MainPanel = new Panel();
            ExitAccountButton = new Button();
            MySelectedButton = new Button();
            SelectionsButton = new Button();
            CharacteristicsButton = new Button();
            FavoritesButton = new Button();
            RecommenButton = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            LoginLabel = new Label();
            ChangeButton = new Button();
            NameLabel = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(788, 78);
            EntryLabel.TabIndex = 1;
            EntryLabel.Text = "Профиль";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(button1);
            MainPanel.Controls.Add(label8);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(NameLabel);
            MainPanel.Controls.Add(ChangeButton);
            MainPanel.Controls.Add(LoginLabel);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(ExitAccountButton);
            MainPanel.Controls.Add(MySelectedButton);
            MainPanel.Controls.Add(SelectionsButton);
            MainPanel.Controls.Add(CharacteristicsButton);
            MainPanel.Controls.Add(FavoritesButton);
            MainPanel.Controls.Add(RecommenButton);
            MainPanel.Controls.Add(label2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 78);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(788, 382);
            MainPanel.TabIndex = 2;
            // 
            // ExitAccountButton
            // 
            ExitAccountButton.BackColor = Color.Cyan;
            ExitAccountButton.FlatAppearance.BorderSize = 0;
            ExitAccountButton.FlatStyle = FlatStyle.Flat;
            ExitAccountButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitAccountButton.Location = new Point(10, 338);
            ExitAccountButton.Name = "ExitAccountButton";
            ExitAccountButton.Size = new Size(191, 36);
            ExitAccountButton.TabIndex = 55;
            ExitAccountButton.Text = "Выход";
            ExitAccountButton.UseVisualStyleBackColor = false;
            ExitAccountButton.Click += ExitAccountButton_Click;
            // 
            // MySelectedButton
            // 
            MySelectedButton.BackColor = Color.Cyan;
            MySelectedButton.FlatAppearance.BorderSize = 0;
            MySelectedButton.FlatStyle = FlatStyle.Flat;
            MySelectedButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MySelectedButton.Location = new Point(10, 273);
            MySelectedButton.Name = "MySelectedButton";
            MySelectedButton.Size = new Size(191, 36);
            MySelectedButton.TabIndex = 54;
            MySelectedButton.Text = "Свои подборки";
            MySelectedButton.UseVisualStyleBackColor = false;
            MySelectedButton.Click += MySelectedButton_Click;
            // 
            // SelectionsButton
            // 
            SelectionsButton.BackColor = Color.Cyan;
            SelectionsButton.FlatAppearance.BorderSize = 0;
            SelectionsButton.FlatStyle = FlatStyle.Flat;
            SelectionsButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectionsButton.Location = new Point(10, 208);
            SelectionsButton.Name = "SelectionsButton";
            SelectionsButton.Size = new Size(191, 36);
            SelectionsButton.TabIndex = 53;
            SelectionsButton.Text = "Подборки";
            SelectionsButton.UseVisualStyleBackColor = false;
            SelectionsButton.Click += SelectionsButton_Click;
            // 
            // CharacteristicsButton
            // 
            CharacteristicsButton.BackColor = Color.Cyan;
            CharacteristicsButton.FlatAppearance.BorderSize = 0;
            CharacteristicsButton.FlatStyle = FlatStyle.Flat;
            CharacteristicsButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CharacteristicsButton.Location = new Point(10, 144);
            CharacteristicsButton.Name = "CharacteristicsButton";
            CharacteristicsButton.Size = new Size(191, 36);
            CharacteristicsButton.TabIndex = 52;
            CharacteristicsButton.Text = "Характеристики";
            CharacteristicsButton.UseVisualStyleBackColor = false;
            CharacteristicsButton.Click += CharacteristicsButton_Click;
            // 
            // FavoritesButton
            // 
            FavoritesButton.BackColor = Color.Cyan;
            FavoritesButton.FlatAppearance.BorderSize = 0;
            FavoritesButton.FlatStyle = FlatStyle.Flat;
            FavoritesButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FavoritesButton.Location = new Point(10, 82);
            FavoritesButton.Name = "FavoritesButton";
            FavoritesButton.Size = new Size(191, 36);
            FavoritesButton.TabIndex = 51;
            FavoritesButton.Text = "Избранное";
            FavoritesButton.UseVisualStyleBackColor = false;
            FavoritesButton.Click += FavoritesButton_Click;
            // 
            // RecommenButton
            // 
            RecommenButton.BackColor = Color.Cyan;
            RecommenButton.FlatAppearance.BorderSize = 0;
            RecommenButton.FlatStyle = FlatStyle.Flat;
            RecommenButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RecommenButton.Location = new Point(10, 25);
            RecommenButton.Name = "RecommenButton";
            RecommenButton.Size = new Size(191, 36);
            RecommenButton.TabIndex = 50;
            RecommenButton.Text = "Рекомендации";
            RecommenButton.UseVisualStyleBackColor = false;
            RecommenButton.Click += RecommenButton_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Cyan;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(218, 1);
            label2.Name = "label2";
            label2.Size = new Size(10, 382);
            label2.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(254, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 125);
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLabel.Location = new Point(305, 35);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(145, 26);
            LoginLabel.TabIndex = 57;
            LoginLabel.Text = "Вход через...";
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = Color.Cyan;
            ChangeButton.FlatAppearance.BorderSize = 0;
            ChangeButton.FlatStyle = FlatStyle.Flat;
            ChangeButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChangeButton.Location = new Point(254, 215);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(124, 25);
            ChangeButton.TabIndex = 58;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(495, 82);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(47, 22);
            NameLabel.TabIndex = 59;
            NameLabel.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(449, 124);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 60;
            label1.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(384, 167);
            label3.Name = "label3";
            label3.Size = new Size(158, 22);
            label3.TabIndex = 61;
            label3.Text = "Номер телефона ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(473, 208);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 62;
            label4.Text = "Почта ";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(192, 255, 255);
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(564, 84);
            label5.Name = "label5";
            label5.Size = new Size(221, 23);
            label5.TabIndex = 63;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(192, 255, 255);
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(564, 123);
            label6.Name = "label6";
            label6.Size = new Size(221, 23);
            label6.TabIndex = 64;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(192, 255, 255);
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(564, 167);
            label7.Name = "label7";
            label7.Size = new Size(221, 23);
            label7.TabIndex = 65;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(192, 255, 255);
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(567, 207);
            label8.Name = "label8";
            label8.Size = new Size(221, 23);
            label8.TabIndex = 66;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(597, 346);
            button1.Name = "button1";
            button1.Size = new Size(191, 36);
            button1.TabIndex = 67;
            button1.Text = "Редактирование ";
            button1.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(788, 460);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            MinimumSize = new Size(264, 445);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            Resize += HomeForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label EntryLabel;
        private Panel MainPanel;
        private Button ExitAccountButton;
        private Button MySelectedButton;
        private Button SelectionsButton;
        private Button CharacteristicsButton;
        private Button FavoritesButton;
        private Button RecommenButton;
        private Label label2;
        private Label LoginLabel;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label NameLabel;
        private Button ChangeButton;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}