namespace RoutesTourists
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Hello
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm registerForm = new RegistrForm();
            registerForm.Show();
        }

        private void MainPanel_Resize(object sender, EventArgs e)
        {
            LoginButton.Width = (int)(MainPanel.Width * 0.16);
            LoginButton.Height = (int)(MainPanel.Height * 0.086);
            RegisterButton.Width = (int)(MainPanel.Width * 0.1982);
            RegisterButton.Height = (int)(MainPanel.Height * 0.086);
            LoginButton.Top = (int)(MainPanel.Height * 0.65);
            LoginButton.Left = (int)(MainPanel.Width * 0.4);
            RegisterButton.Top = (int)(MainPanel.Height * 0.65) + LoginButton.Height + 8;
            RegisterButton.Left = (int)(MainPanel.Width * 0.38);
            pictureBox1.Width = (int)(MainPanel.Width * 0.4);
            pictureBox1.Height = (int)(MainPanel.Height * 0.5);
            pictureBox1.Top = (int)(MainPanel.Height * 0.1);
            pictureBox1.Left = (int)(MainPanel.Width * 0.3);
        }
    }
}
