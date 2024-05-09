namespace RoutesTourists
{
    partial class LoginForm
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
            passwordLabel = new Label();
            passwordField = new TextBox();
            loginLabel = new Label();
            loginField = new TextBox();
            LoginButton = new Button();
            BackButton = new Button();
            MainPanel = new Panel();
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
            EntryLabel.Size = new Size(467, 96);
            EntryLabel.TabIndex = 0;
            EntryLabel.Text = "Вход";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel.Location = new Point(58, 137);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(116, 35);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Пароль";
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.None;
            passwordField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.ForeColor = Color.Gray;
            passwordField.Location = new Point(58, 176);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(372, 38);
            passwordField.TabIndex = 8;
            passwordField.Text = "Введите пароль";
            passwordField.Enter += passwordField_Enter;
            passwordField.Leave += passwordField_Leave;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.None;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(58, 33);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(99, 35);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Логин";
            // 
            // loginField
            // 
            loginField.Anchor = AnchorStyles.None;
            loginField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.ForeColor = Color.Gray;
            loginField.Location = new Point(58, 72);
            loginField.Margin = new Padding(3, 4, 3, 4);
            loginField.Name = "loginField";
            loginField.Size = new Size(372, 38);
            loginField.TabIndex = 6;
            loginField.Text = "Введите логин";
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.BackColor = Color.Cyan;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(138, 272);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(178, 60);
            LoginButton.TabIndex = 10;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(159, 361);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 39);
            BackButton.TabIndex = 11;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(passwordField);
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(loginField);
            MainPanel.Controls.Add(LoginButton);
            MainPanel.Controls.Add(loginLabel);
            MainPanel.Controls.Add(passwordLabel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 96);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(467, 452);
            MainPanel.TabIndex = 12;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(467, 548);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            Resize += LoginForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label EntryLabel;
        private Label passwordLabel;
        private TextBox passwordField;
        private Label loginLabel;
        private TextBox loginField;
        private Button LoginButton;
        private Button BackButton;
        private Panel MainPanel;
    }
}