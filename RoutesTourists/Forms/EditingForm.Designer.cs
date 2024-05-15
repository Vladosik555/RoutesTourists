namespace RoutesTourists.Forms
{
    partial class EditingForm
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
            MaiLFiel = new TextBox();
            NumberFiel = new TextBox();
            SurnameField = new TextBox();
            NameFile = new TextBox();
            EditingButton = new Button();
            BackButton = new Button();
            MailLabel = new Label();
            NumberLabel = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
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
            EntryLabel.Size = new Size(525, 104);
            EntryLabel.TabIndex = 2;
            EntryLabel.Text = "Редактирование";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(MaiLFiel);
            MainPanel.Controls.Add(NumberFiel);
            MainPanel.Controls.Add(SurnameField);
            MainPanel.Controls.Add(NameFile);
            MainPanel.Controls.Add(EditingButton);
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(MailLabel);
            MainPanel.Controls.Add(NumberLabel);
            MainPanel.Controls.Add(SurnameLabel);
            MainPanel.Controls.Add(NameLabel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 104);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(525, 379);
            MainPanel.TabIndex = 3;
            // 
            // MaiLFiel
            // 
            MaiLFiel.BackColor = Color.FromArgb(192, 255, 255);
            MaiLFiel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaiLFiel.Location = new Point(216, 195);
            MaiLFiel.Margin = new Padding(3, 4, 3, 4);
            MaiLFiel.Name = "MaiLFiel";
            MaiLFiel.Size = new Size(308, 30);
            MaiLFiel.TabIndex = 90;
            // 
            // NumberFiel
            // 
            NumberFiel.BackColor = Color.FromArgb(192, 255, 255);
            NumberFiel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumberFiel.Location = new Point(213, 137);
            NumberFiel.Margin = new Padding(3, 4, 3, 4);
            NumberFiel.Name = "NumberFiel";
            NumberFiel.Size = new Size(308, 30);
            NumberFiel.TabIndex = 89;
            // 
            // SurnameField
            // 
            SurnameField.BackColor = Color.FromArgb(192, 255, 255);
            SurnameField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SurnameField.Location = new Point(213, 77);
            SurnameField.Margin = new Padding(3, 4, 3, 4);
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(308, 30);
            SurnameField.TabIndex = 88;
            // 
            // NameFile
            // 
            NameFile.BackColor = Color.FromArgb(192, 255, 255);
            NameFile.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameFile.Location = new Point(213, 27);
            NameFile.Margin = new Padding(3, 4, 3, 4);
            NameFile.Name = "NameFile";
            NameFile.Size = new Size(308, 30);
            NameFile.TabIndex = 87;
            // 
            // EditingButton
            // 
            EditingButton.Anchor = AnchorStyles.None;
            EditingButton.BackColor = Color.Cyan;
            EditingButton.FlatAppearance.BorderSize = 0;
            EditingButton.FlatStyle = FlatStyle.Flat;
            EditingButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditingButton.Location = new Point(150, 256);
            EditingButton.Margin = new Padding(3, 4, 3, 4);
            EditingButton.Name = "EditingButton";
            EditingButton.Size = new Size(203, 44);
            EditingButton.TabIndex = 86;
            EditingButton.Text = "Редактировать";
            EditingButton.UseVisualStyleBackColor = false;
            EditingButton.Click += EditingButton_Click_1;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(181, 308);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 44);
            BackButton.TabIndex = 85;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MailLabel
            // 
            MailLabel.AutoSize = true;
            MailLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MailLabel.Location = new Point(109, 195);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(85, 26);
            MailLabel.TabIndex = 80;
            MailLabel.Text = "Почта ";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumberLabel.Location = new Point(7, 139);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(196, 26);
            NumberLabel.TabIndex = 79;
            NumberLabel.Text = "Номер телефона ";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurnameLabel.Location = new Point(81, 83);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(115, 26);
            SurnameLabel.TabIndex = 78;
            SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(134, 27);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(60, 26);
            NameLabel.TabIndex = 77;
            NameLabel.Text = "Имя";
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 483);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(400, 500);
            Name = "EditingForm";
            Text = "EditingForm";
            Load += EditingForm_Load;
            Resize += EditingForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label EntryLabel;
        private Panel MainPanel;
        private Button EditingButton;
        private Button BackButton;
        private Label MailLabel;
        private Label NumberLabel;
        private Label SurnameLabel;
        private Label NameLabel;
        private TextBox MaiLFiel;
        private TextBox NumberFiel;
        private TextBox SurnameField;
        private TextBox NameFile;
    }
}