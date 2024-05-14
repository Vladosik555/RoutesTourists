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
            EditButton = new Button();
            MailField = new Label();
            NumberField = new Label();
            SurnameField = new Label();
            NameField = new Label();
            MailLabel = new Label();
            NumberLabel = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
            ChangeButton = new Button();
            LoginLabel = new Label();
            pictureProfile = new PictureBox();
            ExitAccountButton = new Button();
            MySelectedButton = new Button();
            SelectionsButton = new Button();
            CharacteristicsButton = new Button();
            FavoritesButton = new Button();
            RecommenButton = new Button();
            label2 = new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProfile).BeginInit();
            SuspendLayout();
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(901, 104);
            EntryLabel.TabIndex = 1;
            EntryLabel.Text = "Профиль";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(EditButton);
            MainPanel.Controls.Add(MailField);
            MainPanel.Controls.Add(NumberField);
            MainPanel.Controls.Add(SurnameField);
            MainPanel.Controls.Add(NameField);
            MainPanel.Controls.Add(MailLabel);
            MainPanel.Controls.Add(NumberLabel);
            MainPanel.Controls.Add(SurnameLabel);
            MainPanel.Controls.Add(NameLabel);
            MainPanel.Controls.Add(ChangeButton);
            MainPanel.Controls.Add(LoginLabel);
            MainPanel.Controls.Add(pictureProfile);
            MainPanel.Controls.Add(ExitAccountButton);
            MainPanel.Controls.Add(MySelectedButton);
            MainPanel.Controls.Add(SelectionsButton);
            MainPanel.Controls.Add(CharacteristicsButton);
            MainPanel.Controls.Add(FavoritesButton);
            MainPanel.Controls.Add(RecommenButton);
            MainPanel.Controls.Add(label2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 104);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(901, 519);
            MainPanel.TabIndex = 2;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Cyan;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditButton.Location = new Point(671, 457);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(227, 48);
            EditButton.TabIndex = 67;
            EditButton.Text = "Редактирование ";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // MailField
            // 
            MailField.BackColor = Color.FromArgb(192, 255, 255);
            MailField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MailField.Location = new Point(645, 272);
            MailField.Name = "MailField";
            MailField.Size = new Size(253, 31);
            MailField.TabIndex = 66;
            // 
            // NumberField
            // 
            NumberField.BackColor = Color.FromArgb(192, 255, 255);
            NumberField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumberField.Location = new Point(645, 223);
            NumberField.Name = "NumberField";
            NumberField.Size = new Size(253, 31);
            NumberField.TabIndex = 65;
            // 
            // SurnameField
            // 
            SurnameField.BackColor = Color.FromArgb(192, 255, 255);
            SurnameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SurnameField.Location = new Point(645, 164);
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(253, 31);
            SurnameField.TabIndex = 64;
            // 
            // NameField
            // 
            NameField.BackColor = Color.FromArgb(192, 255, 255);
            NameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameField.Location = new Point(645, 112);
            NameField.Name = "NameField";
            NameField.Size = new Size(253, 31);
            NameField.TabIndex = 63;
            // 
            // MailLabel
            // 
            MailLabel.AutoSize = true;
            MailLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MailLabel.Location = new Point(541, 277);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(85, 26);
            MailLabel.TabIndex = 62;
            MailLabel.Text = "Почта ";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumberLabel.Location = new Point(522, 223);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(104, 26);
            NumberLabel.TabIndex = 61;
            NumberLabel.Text = "Телефон";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurnameLabel.Location = new Point(513, 165);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(115, 26);
            SurnameLabel.TabIndex = 60;
            SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(566, 109);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(60, 26);
            NameLabel.TabIndex = 59;
            NameLabel.Text = "Имя";
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = Color.Cyan;
            ChangeButton.FlatAppearance.BorderSize = 0;
            ChangeButton.FlatStyle = FlatStyle.Flat;
            ChangeButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChangeButton.Location = new Point(290, 287);
            ChangeButton.Margin = new Padding(3, 4, 3, 4);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(142, 33);
            ChangeButton.TabIndex = 58;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLabel.Location = new Point(349, 47);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(182, 35);
            LoginLabel.TabIndex = 57;
            LoginLabel.Text = "Вход через...";
            // 
            // pictureProfile
            // 
            pictureProfile.Image = Properties.Resources.trail_4559875;
            pictureProfile.Location = new Point(290, 112);
            pictureProfile.Margin = new Padding(3, 4, 3, 4);
            pictureProfile.Name = "pictureProfile";
            pictureProfile.Size = new Size(142, 167);
            pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProfile.TabIndex = 56;
            pictureProfile.TabStop = false;
            // 
            // ExitAccountButton
            // 
            ExitAccountButton.BackColor = Color.Cyan;
            ExitAccountButton.FlatAppearance.BorderSize = 0;
            ExitAccountButton.FlatStyle = FlatStyle.Flat;
            ExitAccountButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitAccountButton.Location = new Point(11, 451);
            ExitAccountButton.Margin = new Padding(3, 4, 3, 4);
            ExitAccountButton.Name = "ExitAccountButton";
            ExitAccountButton.Size = new Size(218, 48);
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
            MySelectedButton.Location = new Point(11, 364);
            MySelectedButton.Margin = new Padding(3, 4, 3, 4);
            MySelectedButton.Name = "MySelectedButton";
            MySelectedButton.Size = new Size(218, 48);
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
            SelectionsButton.Location = new Point(11, 277);
            SelectionsButton.Margin = new Padding(3, 4, 3, 4);
            SelectionsButton.Name = "SelectionsButton";
            SelectionsButton.Size = new Size(218, 48);
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
            CharacteristicsButton.Location = new Point(11, 192);
            CharacteristicsButton.Margin = new Padding(3, 4, 3, 4);
            CharacteristicsButton.Name = "CharacteristicsButton";
            CharacteristicsButton.Size = new Size(218, 48);
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
            FavoritesButton.Location = new Point(11, 109);
            FavoritesButton.Margin = new Padding(3, 4, 3, 4);
            FavoritesButton.Name = "FavoritesButton";
            FavoritesButton.Size = new Size(218, 48);
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
            RecommenButton.Location = new Point(11, 33);
            RecommenButton.Margin = new Padding(3, 4, 3, 4);
            RecommenButton.Name = "RecommenButton";
            RecommenButton.Size = new Size(218, 48);
            RecommenButton.TabIndex = 50;
            RecommenButton.Text = "Рекомендации";
            RecommenButton.UseVisualStyleBackColor = false;
            RecommenButton.Click += RecommenButton_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Cyan;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(249, 1);
            label2.Name = "label2";
            label2.Size = new Size(11, 509);
            label2.TabIndex = 49;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 623);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(400, 578);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            Resize += HomeForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProfile).EndInit();
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
        private PictureBox pictureProfile;
        private Label NameField;
        private Label MailLabel;
        private Label NumberLabel;
        private Label SurnameLabel;
        private Label NameLabel;
        private Button ChangeButton;
        private Button EditButton;
        private Label MailField;
        private Label NumberField;
        private Label SurnameField;
    }
}