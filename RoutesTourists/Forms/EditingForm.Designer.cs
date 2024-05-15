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
            MaiLField = new Label();
            NumberField = new Label();
            SurnameField = new Label();
            NameFiled = new Label();
            MailLabel = new Label();
            NumberLabel = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
            BackButton = new Button();
            EditingButton = new Button();
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
            // MaiLField
            // 
            MaiLField.BackColor = Color.FromArgb(192, 255, 255);
            MaiLField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaiLField.Location = new Point(190, 241);
            MaiLField.Name = "MaiLField";
            MaiLField.Size = new Size(264, 23);
            MaiLField.TabIndex = 74;
            // 
            // NumberField
            // 
            NumberField.BackColor = Color.FromArgb(192, 255, 255);
            NumberField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumberField.Location = new Point(187, 201);
            NumberField.Name = "NumberField";
            NumberField.Size = new Size(267, 23);
            NumberField.TabIndex = 73;
            // 
            // SurnameField
            // 
            SurnameField.BackColor = Color.FromArgb(192, 255, 255);
            SurnameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SurnameField.Location = new Point(187, 157);
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(267, 23);
            SurnameField.TabIndex = 72;
            // 
            // NameFiled
            // 
            NameFiled.BackColor = Color.FromArgb(192, 255, 255);
            NameFiled.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameFiled.Location = new Point(187, 118);
            NameFiled.Name = "NameFiled";
            NameFiled.Size = new Size(267, 23);
            NameFiled.TabIndex = 71;
            // 
            // MailLabel
            // 
            MailLabel.AutoSize = true;
            MailLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MailLabel.Location = new Point(96, 242);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(69, 22);
            MailLabel.TabIndex = 70;
            MailLabel.Text = "Почта ";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumberLabel.Location = new Point(7, 201);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(158, 22);
            NumberLabel.TabIndex = 69;
            NumberLabel.Text = "Номер телефона ";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurnameLabel.Location = new Point(72, 158);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(93, 22);
            SurnameLabel.TabIndex = 68;
            SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(118, 117);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(47, 22);
            NameLabel.TabIndex = 67;
            NameLabel.Text = "Имя";
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(158, 328);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 33);
            BackButton.TabIndex = 75;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // EditingButton
            // 
            EditingButton.Anchor = AnchorStyles.None;
            EditingButton.BackColor = Color.Cyan;
            EditingButton.FlatAppearance.BorderSize = 0;
            EditingButton.FlatStyle = FlatStyle.Flat;
            EditingButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditingButton.Location = new Point(132, 289);
            EditingButton.Name = "EditingButton";
            EditingButton.Size = new Size(178, 33);
            EditingButton.TabIndex = 76;
            EditingButton.Text = "Редактировать";
            EditingButton.UseVisualStyleBackColor = false;
            EditingButton.Click += EditingButton_Click;
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 362);
            Controls.Add(EditingButton);
            Controls.Add(BackButton);
            Controls.Add(MaiLField);
            Controls.Add(NumberField);
            Controls.Add(SurnameField);
            Controls.Add(NameFiled);
            Controls.Add(MailLabel);
            Controls.Add(NumberLabel);
            Controls.Add(SurnameLabel);
            Controls.Add(NameLabel);
            Controls.Add(EntryLabel);
            Name = "EditingForm";
            Text = "EditingForm";
            Load += EditingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EntryLabel;
        private Label MaiLField;
        private Label NumberField;
        private Label SurnameField;
        private Label NameFiled;
        private Label MailLabel;
        private Label NumberLabel;
        private Label SurnameLabel;
        private Label NameLabel;
        private Button BackButton;
        private Button EditingButton;
    }
}