namespace RoutesTourists
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            MainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(228, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Cyan;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(326, 315);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(127, 36);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Вход";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Cyan;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegisterButton.Location = new Point(311, 357);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(157, 36);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(RegisterButton);
            MainPanel.Controls.Add(LoginButton);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(788, 396);
            MainPanel.TabIndex = 3;
            MainPanel.Resize += MainPanel_Resize;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(788, 396);
            Controls.Add(MainPanel);
            MinimumSize = new Size(352, 377);
            Name = "InitialForm";
            Text = "InitialForm";
            Load += InitialForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button LoginButton;
        private Button RegisterButton;
        private Panel MainPanel;
    }
}
