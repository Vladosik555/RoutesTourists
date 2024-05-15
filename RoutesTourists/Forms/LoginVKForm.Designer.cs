namespace RoutesTourists.Forms
{
    partial class LoginVKForm
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
            MainPanel = new Panel();
            CodeConfirmationField = new TextBox();
            CodeConfirmationLabel = new Label();
            showCheckBox = new CheckBox();
            passwordField = new TextBox();
            BackButton = new Button();
            phoneNumberField = new TextBox();
            LoginVKButton = new Button();
            loginLabel = new Label();
            passwordLabel = new Label();
            EntryLabel = new Label();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(CodeConfirmationField);
            MainPanel.Controls.Add(CodeConfirmationLabel);
            MainPanel.Controls.Add(showCheckBox);
            MainPanel.Controls.Add(passwordField);
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(phoneNumberField);
            MainPanel.Controls.Add(LoginVKButton);
            MainPanel.Controls.Add(loginLabel);
            MainPanel.Controls.Add(passwordLabel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 103);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(511, 501);
            MainPanel.TabIndex = 14;
            // 
            // CodeConfirmationField
            // 
            CodeConfirmationField.Enabled = false;
            CodeConfirmationField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CodeConfirmationField.ForeColor = Color.Gray;
            CodeConfirmationField.Location = new Point(66, 296);
            CodeConfirmationField.Margin = new Padding(3, 4, 3, 4);
            CodeConfirmationField.Name = "CodeConfirmationField";
            CodeConfirmationField.Size = new Size(372, 38);
            CodeConfirmationField.TabIndex = 14;
            CodeConfirmationField.Text = "Введите код";
            CodeConfirmationField.Visible = false;
            CodeConfirmationField.Enter += CodeConfirmationField_Enter;
            CodeConfirmationField.Leave += CodeConfirmationField_Leave;
            // 
            // CodeConfirmationLabel
            // 
            CodeConfirmationLabel.AutoSize = true;
            CodeConfirmationLabel.Enabled = false;
            CodeConfirmationLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CodeConfirmationLabel.Location = new Point(66, 257);
            CodeConfirmationLabel.Name = "CodeConfirmationLabel";
            CodeConfirmationLabel.Size = new Size(294, 35);
            CodeConfirmationLabel.TabIndex = 13;
            CodeConfirmationLabel.Text = "Подтверждение кода";
            CodeConfirmationLabel.Visible = false;
            // 
            // showCheckBox
            // 
            showCheckBox.AutoSize = true;
            showCheckBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showCheckBox.Location = new Point(66, 219);
            showCheckBox.Margin = new Padding(3, 4, 3, 4);
            showCheckBox.Name = "showCheckBox";
            showCheckBox.Size = new Size(217, 30);
            showCheckBox.TabIndex = 12;
            showCheckBox.Text = "Показать пароль";
            showCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.ForeColor = Color.Gray;
            passwordField.Location = new Point(66, 168);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(372, 38);
            passwordField.TabIndex = 8;
            passwordField.Text = "Введите пароль";
            passwordField.Enter += passwordField_Enter;
            passwordField.Leave += passwordField_Leave;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(187, 435);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 39);
            BackButton.TabIndex = 11;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // phoneNumberField
            // 
            phoneNumberField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            phoneNumberField.ForeColor = Color.Gray;
            phoneNumberField.Location = new Point(66, 83);
            phoneNumberField.Margin = new Padding(3, 4, 3, 4);
            phoneNumberField.Name = "phoneNumberField";
            phoneNumberField.Size = new Size(372, 38);
            phoneNumberField.TabIndex = 6;
            phoneNumberField.Text = "Введите номер телефона";
            phoneNumberField.Enter += phoneNumberField_Enter;
            phoneNumberField.Leave += phoneNumberField_Leave;
            // 
            // LoginVKButton
            // 
            LoginVKButton.BackColor = Color.Cyan;
            LoginVKButton.FlatAppearance.BorderSize = 0;
            LoginVKButton.FlatStyle = FlatStyle.Flat;
            LoginVKButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginVKButton.Location = new Point(167, 367);
            LoginVKButton.Margin = new Padding(3, 4, 3, 4);
            LoginVKButton.Name = "LoginVKButton";
            LoginVKButton.Size = new Size(178, 60);
            LoginVKButton.TabIndex = 10;
            LoginVKButton.Text = "Войти";
            LoginVKButton.UseVisualStyleBackColor = false;
            LoginVKButton.Click += LoginVKButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(66, 44);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(235, 35);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Номер телефона";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel.Location = new Point(66, 129);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(116, 35);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Пароль";
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(511, 103);
            EntryLabel.TabIndex = 13;
            EntryLabel.Text = "Вход через ВК";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginVKForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 604);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(400, 560);
            Name = "LoginVKForm";
            Text = "LoginVKForm";
            Load += LoginVKForm_Load;
            Resize += LoginVKForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button LoginViaVKButton;
        private CheckBox showCheckBox;
        private TextBox passwordField;
        private Button BackButton;
        private TextBox phoneNumberField;
        private Button LoginVKButton;
        private Label loginLabel;
        private Label passwordLabel;
        private Label EntryLabel;
        private TextBox CodeConfirmationField;
        private Label CodeConfirmationLabel;
    }
}