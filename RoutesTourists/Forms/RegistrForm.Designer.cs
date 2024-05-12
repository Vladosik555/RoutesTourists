namespace RoutesTourists
{
    partial class RegistrForm
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
            BackButton = new Button();
            RegistrButton = new Button();
            MailLabel = new Label();
            MailField = new TextBox();
            SurnameField = new TextBox();
            NameField = new TextBox();
            nameLabel = new Label();
            surnameLabel = new Label();
            loginLabel = new Label();
            LoginField = new TextBox();
            passwordLabel2 = new Label();
            password2Field = new TextBox();
            passwordLabel = new Label();
            passwordField = new TextBox();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(900, 96);
            EntryLabel.TabIndex = 1;
            EntryLabel.Text = "Регистрация";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(RegistrButton);
            MainPanel.Controls.Add(MailLabel);
            MainPanel.Controls.Add(MailField);
            MainPanel.Controls.Add(SurnameField);
            MainPanel.Controls.Add(NameField);
            MainPanel.Controls.Add(nameLabel);
            MainPanel.Controls.Add(surnameLabel);
            MainPanel.Controls.Add(loginLabel);
            MainPanel.Controls.Add(LoginField);
            MainPanel.Controls.Add(passwordLabel2);
            MainPanel.Controls.Add(password2Field);
            MainPanel.Controls.Add(passwordLabel);
            MainPanel.Controls.Add(passwordField);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 96);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(900, 432);
            MainPanel.TabIndex = 86;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(392, 378);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 39);
            BackButton.TabIndex = 99;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // RegistrButton
            // 
            RegistrButton.Anchor = AnchorStyles.None;
            RegistrButton.BackColor = Color.Cyan;
            RegistrButton.FlatAppearance.BorderSize = 0;
            RegistrButton.FlatStyle = FlatStyle.Flat;
            RegistrButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegistrButton.Location = new Point(310, 310);
            RegistrButton.Margin = new Padding(3, 4, 3, 4);
            RegistrButton.Name = "RegistrButton";
            RegistrButton.Size = new Size(313, 60);
            RegistrButton.TabIndex = 98;
            RegistrButton.Text = "Зарегистрироваться";
            RegistrButton.UseVisualStyleBackColor = false;
            // 
            // MailLabel
            // 
            MailLabel.Anchor = AnchorStyles.None;
            MailLabel.AutoSize = true;
            MailLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MailLabel.ImeMode = ImeMode.NoControl;
            MailLabel.Location = new Point(481, 216);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(99, 35);
            MailLabel.TabIndex = 97;
            MailLabel.Text = "Почта";
            // 
            // MailField
            // 
            MailField.Anchor = AnchorStyles.None;
            MailField.Font = new Font("Times New Roman", 15.75F);
            MailField.ForeColor = Color.Gray;
            MailField.Location = new Point(481, 255);
            MailField.Margin = new Padding(3, 4, 3, 4);
            MailField.Name = "MailField";
            MailField.Size = new Size(372, 38);
            MailField.TabIndex = 96;
            MailField.Text = "Введите почту";
            // 
            // SurnameField
            // 
            SurnameField.Anchor = AnchorStyles.None;
            SurnameField.Font = new Font("Times New Roman", 15.75F);
            SurnameField.ForeColor = Color.Gray;
            SurnameField.Location = new Point(481, 156);
            SurnameField.Margin = new Padding(3, 4, 3, 4);
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(372, 38);
            SurnameField.TabIndex = 95;
            SurnameField.Text = "Введите фамилию";
            // 
            // NameField
            // 
            NameField.Anchor = AnchorStyles.None;
            NameField.Font = new Font("Times New Roman", 15.75F);
            NameField.ForeColor = Color.Gray;
            NameField.Location = new Point(481, 55);
            NameField.Margin = new Padding(3, 4, 3, 4);
            NameField.Name = "NameField";
            NameField.Size = new Size(372, 38);
            NameField.TabIndex = 94;
            NameField.Text = "Введите имя";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.ImeMode = ImeMode.NoControl;
            nameLabel.Location = new Point(481, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(74, 35);
            nameLabel.TabIndex = 93;
            nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            surnameLabel.Anchor = AnchorStyles.None;
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.ImeMode = ImeMode.NoControl;
            surnameLabel.Location = new Point(481, 118);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(142, 35);
            surnameLabel.TabIndex = 92;
            surnameLabel.Text = "Фамилия";
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.None;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            loginLabel.ImeMode = ImeMode.NoControl;
            loginLabel.Location = new Point(47, 16);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(99, 35);
            loginLabel.TabIndex = 91;
            loginLabel.Text = "Логин";
            // 
            // LoginField
            // 
            LoginField.Anchor = AnchorStyles.None;
            LoginField.Font = new Font("Times New Roman", 15.75F);
            LoginField.ForeColor = Color.Gray;
            LoginField.Location = new Point(47, 55);
            LoginField.Margin = new Padding(3, 4, 3, 4);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(372, 38);
            LoginField.TabIndex = 90;
            LoginField.Text = "Введите логин";
            // 
            // passwordLabel2
            // 
            passwordLabel2.Anchor = AnchorStyles.None;
            passwordLabel2.AutoSize = true;
            passwordLabel2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            passwordLabel2.ImeMode = ImeMode.NoControl;
            passwordLabel2.Location = new Point(47, 216);
            passwordLabel2.Name = "passwordLabel2";
            passwordLabel2.Size = new Size(275, 35);
            passwordLabel2.TabIndex = 89;
            passwordLabel2.Text = "Повторный пароль";
            // 
            // password2Field
            // 
            password2Field.Anchor = AnchorStyles.None;
            password2Field.Font = new Font("Times New Roman", 15.75F);
            password2Field.ForeColor = Color.Gray;
            password2Field.Location = new Point(47, 255);
            password2Field.Margin = new Padding(3, 4, 3, 4);
            password2Field.Name = "password2Field";
            password2Field.Size = new Size(372, 38);
            password2Field.TabIndex = 88;
            password2Field.Text = "Повторите пароль";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            passwordLabel.ImeMode = ImeMode.NoControl;
            passwordLabel.Location = new Point(47, 118);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(116, 35);
            passwordLabel.TabIndex = 87;
            passwordLabel.Text = "Пароль";
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.None;
            passwordField.Font = new Font("Times New Roman", 15.75F);
            passwordField.ForeColor = Color.Gray;
            passwordField.Location = new Point(47, 156);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(372, 38);
            passwordField.TabIndex = 86;
            passwordField.Text = "Введите пароль";
            // 
            // RegistrForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 528);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrForm";
            Text = "RegistrForm";
            Load += RegistrForm_Load;
            Resize += RegistrForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label EntryLabel;
        private Panel MainPanel;
        private Button BackButton;
        private Button RegistrButton;
        private Label MailLabel;
        private TextBox MailField;
        private TextBox SurnameField;
        private TextBox NameField;
        private Label nameLabel;
        private Label surnameLabel;
        private Label loginLabel;
        private TextBox LoginField;
        private Label passwordLabel2;
        private TextBox password2Field;
        private Label passwordLabel;
        private TextBox passwordField;
    }
}