namespace RoutesTourists.Forms
{
    partial class AllSelectionForm
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
            BackButton = new Button();
            FavoriteTable = new DataGridView();
            FavoritesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FavoriteTable).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(155, 418);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(145, 29);
            BackButton.TabIndex = 15;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // FavoriteTable
            // 
            FavoriteTable.AllowUserToAddRows = false;
            FavoriteTable.BackgroundColor = Color.White;
            FavoriteTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavoriteTable.Location = new Point(0, 81);
            FavoriteTable.Name = "FavoriteTable";
            FavoriteTable.ReadOnly = true;
            FavoriteTable.Size = new Size(467, 331);
            FavoriteTable.TabIndex = 14;
            // 
            // FavoritesLabel
            // 
            FavoritesLabel.BackColor = Color.Cyan;
            FavoritesLabel.Dock = DockStyle.Top;
            FavoritesLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FavoritesLabel.Location = new Point(0, 0);
            FavoritesLabel.Name = "FavoritesLabel";
            FavoritesLabel.Size = new Size(469, 78);
            FavoritesLabel.TabIndex = 13;
            FavoritesLabel.Text = "Все подборки";
            FavoritesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AllSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(469, 450);
            Controls.Add(BackButton);
            Controls.Add(FavoriteTable);
            Controls.Add(FavoritesLabel);
            Name = "AllSelectionForm";
            Text = "AllSelectionForm";
            ((System.ComponentModel.ISupportInitialize)FavoriteTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private DataGridView FavoriteTable;
        private Label FavoritesLabel;
    }
}