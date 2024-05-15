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
            EntryLabel.Size = new Size(459, 78);
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
            MainPanel.Location = new Point(0, 78);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(459, 284);
            MainPanel.TabIndex = 3;
            // 
            // MaiLFiel
            // 
            MaiLFiel.BackColor = Color.FromArgb(192, 255, 255);
            MaiLFiel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaiLFiel.Location = new Point(189, 146);
            MaiLFiel.Name = "MaiLFiel";
            MaiLFiel.Size = new Size(270, 26);
            MaiLFiel.TabIndex = 90;
            // 
            // NumberFiel
            // 
            NumberFiel.BackColor = Color.FromArgb(192, 255, 255);
            NumberFiel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumberFiel.Location = new Point(186, 103);
            NumberFiel.Name = "NumberFiel";
            NumberFiel.Size = new Size(270, 26);
            NumberFiel.TabIndex = 89;
            // 
            // SurnameField
            // 
            SurnameField.BackColor = Color.FromArgb(192, 255, 255);
            SurnameField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SurnameField.Location = new Point(186, 58);
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(270, 26);
            SurnameField.TabIndex = 88;
            // 
            // NameFile
            // 
            NameFile.BackColor = Color.FromArgb(192, 255, 255);
            NameFile.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameFile.Location = new Point(186, 20);
            NameFile.Name = "NameFile";
            NameFile.Size = new Size(270, 26);
            NameFile.TabIndex = 87;
            // 
            // EditingButton
            // 
            EditingButton.Anchor = AnchorStyles.None;
            EditingButton.BackColor = Color.Cyan;
            EditingButton.FlatAppearance.BorderSize = 0;
            EditingButton.FlatStyle = FlatStyle.Flat;
            EditingButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditingButton.Location = new Point(131, 192);
            EditingButton.Name = "EditingButton";
            EditingButton.Size = new Size(178, 33);
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
            BackButton.Location = new Point(158, 231);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 33);
            BackButton.TabIndex = 85;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MailLabel
            // 
            MailLabel.AutoSize = true;
            MailLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MailLabel.Location = new Point(95, 146);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(69, 22);
            MailLabel.TabIndex = 80;
            MailLabel.Text = "Почта ";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumberLabel.Location = new Point(6, 104);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(158, 22);
            NumberLabel.TabIndex = 79;
            NumberLabel.Text = "Номер телефона ";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurnameLabel.Location = new Point(71, 62);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(93, 22);
            SurnameLabel.TabIndex = 78;
            SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(117, 20);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(47, 22);
            NameLabel.TabIndex = 77;
            NameLabel.Text = "Имя";
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 362);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
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