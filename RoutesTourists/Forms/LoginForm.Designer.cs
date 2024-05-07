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
            passwondLabel = new Label();
            passwordField = new TextBox();
            loginLabel = new Label();
            loginField = new TextBox();
            LoginButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(409, 72);
            EntryLabel.TabIndex = 0;
            EntryLabel.Text = "Вход";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwondLabel
            // 
            passwondLabel.AutoSize = true;
            passwondLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwondLabel.Location = new Point(52, 202);
            passwondLabel.Name = "passwondLabel";
            passwondLabel.Size = new Size(93, 26);
            passwondLabel.TabIndex = 9;
            passwondLabel.Text = "Пароль";
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.ForeColor = Color.Gray;
            passwordField.Location = new Point(52, 231);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(326, 32);
            passwordField.TabIndex = 8;
            passwordField.Text = "Введите пароль";
            passwordField.Enter += passwordField_Enter;
            passwordField.Leave += passwordField_Leave;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(57, 124);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(80, 26);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Логин";
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.ForeColor = Color.Gray;
            loginField.Location = new Point(52, 153);
            loginField.Name = "loginField";
            loginField.Size = new Size(326, 32);
            loginField.TabIndex = 6;
            loginField.Text = "Введите логин";
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Cyan;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(122, 303);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(156, 45);
            LoginButton.TabIndex = 10;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(140, 370);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 29);
            BackButton.TabIndex = 11;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(409, 411);
            Controls.Add(BackButton);
            Controls.Add(LoginButton);
            Controls.Add(passwondLabel);
            Controls.Add(passwordField);
            Controls.Add(loginLabel);
            Controls.Add(loginField);
            Controls.Add(EntryLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EntryLabel;
        private Label passwondLabel;
        private TextBox passwordField;
        private Label loginLabel;
        private TextBox loginField;
        private Button LoginButton;
        private Button BackButton;
    }
}