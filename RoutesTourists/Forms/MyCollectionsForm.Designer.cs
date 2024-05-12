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
            NameLabel = new Label();
            SelectedField = new TextBox();
            ChoiseLabel = new Label();
            choiseComboBox = new ComboBox();
            createCollectionButton = new Button();
            ViewCollectionsButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // MyCollectionLabel
            // 
            MyCollectionLabel.BackColor = Color.Cyan;
            MyCollectionLabel.Dock = DockStyle.Top;
            MyCollectionLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MyCollectionLabel.Location = new Point(0, 0);
            MyCollectionLabel.Name = "MyCollectionLabel";
            MyCollectionLabel.Size = new Size(455, 72);
            MyCollectionLabel.TabIndex = 1;
            MyCollectionLabel.Text = "Мои подборки";
            MyCollectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.None;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(24, 135);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(225, 26);
            NameLabel.TabIndex = 75;
            NameLabel.Text = "Название подборки";
            // 
            // SelectedField
            // 
            SelectedField.Anchor = AnchorStyles.None;
            SelectedField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectedField.ForeColor = Color.Black;
            SelectedField.Location = new Point(24, 164);
            SelectedField.Name = "SelectedField";
            SelectedField.Size = new Size(409, 32);
            SelectedField.TabIndex = 76;
            // 
            // ChoiseLabel
            // 
            ChoiseLabel.Anchor = AnchorStyles.None;
            ChoiseLabel.AutoSize = true;
            ChoiseLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            ChoiseLabel.ImeMode = ImeMode.NoControl;
            ChoiseLabel.Location = new Point(24, 226);
            ChoiseLabel.Name = "ChoiseLabel";
            ChoiseLabel.Size = new Size(200, 26);
            ChoiseLabel.TabIndex = 77;
            ChoiseLabel.Text = "Выбор маршрута";
            // 
            // choiseComboBox
            // 
            choiseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            choiseComboBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            choiseComboBox.FormattingEnabled = true;
            choiseComboBox.Location = new Point(24, 268);
            choiseComboBox.Name = "choiseComboBox";
            choiseComboBox.Size = new Size(409, 31);
            choiseComboBox.TabIndex = 78;
            // 
            // createCollectionButton
            // 
            createCollectionButton.BackColor = Color.Cyan;
            createCollectionButton.FlatAppearance.BorderSize = 0;
            createCollectionButton.FlatStyle = FlatStyle.Flat;
            createCollectionButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            createCollectionButton.Location = new Point(131, 336);
            createCollectionButton.Name = "createCollectionButton";
            createCollectionButton.Size = new Size(191, 36);
            createCollectionButton.TabIndex = 79;
            createCollectionButton.Text = "Создать подборку";
            createCollectionButton.UseVisualStyleBackColor = false;
            createCollectionButton.Click += createCollectionButton_Click;
            // 
            // ViewCollectionsButton
            // 
            ViewCollectionsButton.BackColor = Color.Cyan;
            ViewCollectionsButton.FlatAppearance.BorderSize = 0;
            ViewCollectionsButton.FlatStyle = FlatStyle.Flat;
            ViewCollectionsButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ViewCollectionsButton.Location = new Point(146, 378);
            ViewCollectionsButton.Name = "ViewCollectionsButton";
            ViewCollectionsButton.Size = new Size(157, 29);
            ViewCollectionsButton.TabIndex = 80;
            ViewCollectionsButton.Text = "Просмотр подборок";
            ViewCollectionsButton.UseVisualStyleBackColor = false;
            ViewCollectionsButton.Click += ViewCollectionsButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(146, 413);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(157, 29);
            BackButton.TabIndex = 81;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MyCollectionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 450);
            Controls.Add(BackButton);
            Controls.Add(ViewCollectionsButton);
            Controls.Add(createCollectionButton);
            Controls.Add(choiseComboBox);
            Controls.Add(ChoiseLabel);
            Controls.Add(SelectedField);
            Controls.Add(NameLabel);
            Controls.Add(MyCollectionLabel);
            Name = "MyCollectionsForm";
            Text = "MyCollectionsForm";
            Load += MyCollectionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MyCollectionLabel;
        private Label NameLabel;
        private TextBox SelectedField;
        private Label ChoiseLabel;
        private ComboBox choiseComboBox;
        private Button createCollectionButton;
        private Button ViewCollectionsButton;
        private Button BackButton;
    }
}