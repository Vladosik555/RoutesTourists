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
            FavoriteTable = new DataGridView();
            BackButton = new Button();
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
            FavoritesLabel.Size = new Size(443, 78);
            FavoritesLabel.TabIndex = 2;
            FavoritesLabel.Text = "Избранное";
            FavoritesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FavoriteTable
            // 
            FavoriteTable.BackgroundColor = Color.White;
            FavoriteTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavoriteTable.Location = new Point(0, 77);
            FavoriteTable.Name = "FavoriteTable";
            FavoriteTable.ReadOnly = true;
            FavoriteTable.Size = new Size(443, 331);
            FavoriteTable.TabIndex = 3;
            FavoriteTable.CellDoubleClick += FavoriteTable_CellDoubleClick;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(154, 414);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 29);
            BackButton.TabIndex = 12;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // FavoritesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 444);
            Controls.Add(BackButton);
            Controls.Add(FavoriteTable);
            Controls.Add(FavoritesLabel);
            Name = "FavoritesForm";
            Text = "FavoritesForm";
            Load += FavoritesForm_Load;
            ((System.ComponentModel.ISupportInitialize)FavoriteTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label FavoritesLabel;
        private DataGridView FavoriteTable;
        private Button BackButton;
    }
}