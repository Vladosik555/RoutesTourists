namespace RoutesTourists.Forms
{
    partial class FavoritesForm
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
            FavoritesLabel = new Label();
            MainPanel = new Panel();
            BackButton = new Button();
            FavoriteTable = new DataGridView();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FavoriteTable).BeginInit();
            SuspendLayout();
            // 
            // FavoritesLabel
            // 
            FavoritesLabel.BackColor = Color.Cyan;
            FavoritesLabel.Dock = DockStyle.Top;
            FavoritesLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FavoritesLabel.Location = new Point(0, 0);
            FavoritesLabel.Name = "FavoritesLabel";
            FavoritesLabel.Size = new Size(900, 104);
            FavoritesLabel.TabIndex = 2;
            FavoritesLabel.Text = "Избранное";
            FavoritesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(FavoriteTable);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 104);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(900, 449);
            MainPanel.TabIndex = 3;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(371, 379);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 44);
            BackButton.TabIndex = 14;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // FavoriteTable
            // 
            FavoriteTable.AllowUserToAddRows = false;
            FavoriteTable.BackgroundColor = Color.White;
            FavoriteTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavoriteTable.Dock = DockStyle.Top;
            FavoriteTable.Location = new Point(0, 0);
            FavoriteTable.Margin = new Padding(3, 4, 3, 4);
            FavoriteTable.Name = "FavoriteTable";
            FavoriteTable.ReadOnly = true;
            FavoriteTable.RowHeadersWidth = 51;
            FavoriteTable.Size = new Size(900, 355);
            FavoriteTable.TabIndex = 13;
            // 
            // FavoritesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 553);
            Controls.Add(MainPanel);
            Controls.Add(FavoritesLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(325, 535);
            Name = "FavoritesForm";
            Text = "FavoritesForm";
            Load += FavoritesForm_Load;
            Resize += FavoritesForm_Resize;
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FavoriteTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label FavoritesLabel;
        private Panel MainPanel;
        private Button BackButton;
        private DataGridView FavoriteTable;
    }
}