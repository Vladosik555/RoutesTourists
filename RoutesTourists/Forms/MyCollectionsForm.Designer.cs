namespace RoutesTourists.Forms
{
    partial class MyCollectionsForm
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
            MyCollectionLabel = new Label();
            MainPanel = new Panel();
            BackButton = new Button();
            ViewCollectionsButton = new Button();
            createCollectionButton = new Button();
            choiseComboBox = new ComboBox();
            ChoiseLabel = new Label();
            SelectedField = new TextBox();
            NameLabel = new Label();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MyCollectionLabel
            // 
            MyCollectionLabel.BackColor = Color.Cyan;
            MyCollectionLabel.Dock = DockStyle.Top;
            MyCollectionLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MyCollectionLabel.Location = new Point(0, 0);
            MyCollectionLabel.Name = "MyCollectionLabel";
            MyCollectionLabel.Size = new Size(520, 96);
            MyCollectionLabel.TabIndex = 1;
            MyCollectionLabel.Text = "Мои подборки";
            MyCollectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(ViewCollectionsButton);
            MainPanel.Controls.Add(createCollectionButton);
            MainPanel.Controls.Add(choiseComboBox);
            MainPanel.Controls.Add(ChoiseLabel);
            MainPanel.Controls.Add(SelectedField);
            MainPanel.Controls.Add(NameLabel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 96);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(520, 504);
            MainPanel.TabIndex = 2;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(167, 418);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(179, 39);
            BackButton.TabIndex = 88;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // ViewCollectionsButton
            // 
            ViewCollectionsButton.BackColor = Color.Cyan;
            ViewCollectionsButton.FlatAppearance.BorderSize = 0;
            ViewCollectionsButton.FlatStyle = FlatStyle.Flat;
            ViewCollectionsButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ViewCollectionsButton.Location = new Point(167, 371);
            ViewCollectionsButton.Margin = new Padding(3, 4, 3, 4);
            ViewCollectionsButton.Name = "ViewCollectionsButton";
            ViewCollectionsButton.Size = new Size(179, 39);
            ViewCollectionsButton.TabIndex = 87;
            ViewCollectionsButton.Text = "Просмотр подборок";
            ViewCollectionsButton.UseVisualStyleBackColor = false;
            ViewCollectionsButton.Click += ViewCollectionsButton_Click;
            // 
            // createCollectionButton
            // 
            createCollectionButton.BackColor = Color.Cyan;
            createCollectionButton.FlatAppearance.BorderSize = 0;
            createCollectionButton.FlatStyle = FlatStyle.Flat;
            createCollectionButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            createCollectionButton.Location = new Point(150, 315);
            createCollectionButton.Margin = new Padding(3, 4, 3, 4);
            createCollectionButton.Name = "createCollectionButton";
            createCollectionButton.Size = new Size(218, 48);
            createCollectionButton.TabIndex = 86;
            createCollectionButton.Text = "Создать подборку";
            createCollectionButton.UseVisualStyleBackColor = false;
            // 
            // choiseComboBox
            // 
            choiseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            choiseComboBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            choiseComboBox.FormattingEnabled = true;
            choiseComboBox.Location = new Point(27, 224);
            choiseComboBox.Margin = new Padding(3, 4, 3, 4);
            choiseComboBox.Name = "choiseComboBox";
            choiseComboBox.Size = new Size(467, 37);
            choiseComboBox.TabIndex = 85;
            // 
            // ChoiseLabel
            // 
            ChoiseLabel.Anchor = AnchorStyles.None;
            ChoiseLabel.AutoSize = true;
            ChoiseLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            ChoiseLabel.ImeMode = ImeMode.NoControl;
            ChoiseLabel.Location = new Point(27, 168);
            ChoiseLabel.Name = "ChoiseLabel";
            ChoiseLabel.Size = new Size(250, 35);
            ChoiseLabel.TabIndex = 84;
            ChoiseLabel.Text = "Выбор маршрута";
            // 
            // SelectedField
            // 
            SelectedField.Anchor = AnchorStyles.None;
            SelectedField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectedField.ForeColor = Color.Black;
            SelectedField.Location = new Point(27, 86);
            SelectedField.Margin = new Padding(3, 4, 3, 4);
            SelectedField.Name = "SelectedField";
            SelectedField.Size = new Size(467, 38);
            SelectedField.TabIndex = 83;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.None;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(27, 47);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(276, 35);
            NameLabel.TabIndex = 82;
            NameLabel.Text = "Название подборки";
            // 
            // MyCollectionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 600);
            Controls.Add(MainPanel);
            Controls.Add(MyCollectionLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyCollectionsForm";
            Text = "MyCollectionsForm";
            Load += MyCollectionsForm_Load;
            Resize += MyCollectionsForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label MyCollectionLabel;
        private Panel MainPanel;
        private Button BackButton;
        private Button ViewCollectionsButton;
        private Button createCollectionButton;
        private ComboBox choiseComboBox;
        private Label ChoiseLabel;
        private TextBox SelectedField;
        private Label NameLabel;
    }
}