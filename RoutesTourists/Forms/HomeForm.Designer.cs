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
            EnterButton = new Button();
            MySelectedButton = new Button();
            SelectionsButton = new Button();
            CharacteristicsButton = new Button();
            FavoritesButton = new Button();
            RecommenButton = new Button();
            label2 = new Label();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(900, 104);
            EntryLabel.TabIndex = 1;
            EntryLabel.Text = "Профиль";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(EnterButton);
            MainPanel.Controls.Add(MySelectedButton);
            MainPanel.Controls.Add(SelectionsButton);
            MainPanel.Controls.Add(CharacteristicsButton);
            MainPanel.Controls.Add(FavoritesButton);
            MainPanel.Controls.Add(RecommenButton);
            MainPanel.Controls.Add(label2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 104);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(900, 510);
            MainPanel.TabIndex = 2;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Cyan;
            EnterButton.FlatAppearance.BorderSize = 0;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EnterButton.Location = new Point(12, 450);
            EnterButton.Margin = new Padding(3, 4, 3, 4);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(218, 48);
            EnterButton.TabIndex = 55;
            EnterButton.Text = "Вход";
            EnterButton.UseVisualStyleBackColor = false;
            // 
            // MySelectedButton
            // 
            MySelectedButton.BackColor = Color.Cyan;
            MySelectedButton.FlatAppearance.BorderSize = 0;
            MySelectedButton.FlatStyle = FlatStyle.Flat;
            MySelectedButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MySelectedButton.Location = new Point(12, 364);
            MySelectedButton.Margin = new Padding(3, 4, 3, 4);
            MySelectedButton.Name = "MySelectedButton";
            MySelectedButton.Size = new Size(218, 48);
            MySelectedButton.TabIndex = 54;
            MySelectedButton.Text = "Свои подборки";
            MySelectedButton.UseVisualStyleBackColor = false;
            // 
            // SelectionsButton
            // 
            SelectionsButton.BackColor = Color.Cyan;
            SelectionsButton.FlatAppearance.BorderSize = 0;
            SelectionsButton.FlatStyle = FlatStyle.Flat;
            SelectionsButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectionsButton.Location = new Point(12, 277);
            SelectionsButton.Margin = new Padding(3, 4, 3, 4);
            SelectionsButton.Name = "SelectionsButton";
            SelectionsButton.Size = new Size(218, 48);
            SelectionsButton.TabIndex = 53;
            SelectionsButton.Text = "Подборки";
            SelectionsButton.UseVisualStyleBackColor = false;
            // 
            // CharacteristicsButton
            // 
            CharacteristicsButton.BackColor = Color.Cyan;
            CharacteristicsButton.FlatAppearance.BorderSize = 0;
            CharacteristicsButton.FlatStyle = FlatStyle.Flat;
            CharacteristicsButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CharacteristicsButton.Location = new Point(12, 192);
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
            FavoritesButton.Location = new Point(12, 110);
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
            RecommenButton.Location = new Point(12, 33);
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
            label2.Size = new Size(11, 510);
            label2.TabIndex = 49;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 614);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(300, 580);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            Resize += HomeForm_Resize;
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label EntryLabel;
        private Panel MainPanel;
        private Button EnterButton;
        private Button MySelectedButton;
        private Button SelectionsButton;
        private Button CharacteristicsButton;
        private Button FavoritesButton;
        private Button RecommenButton;
        private Label label2;
    }
}