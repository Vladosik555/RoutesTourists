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
            EntryLabel = new Label();
            MainPanel = new Panel();
            BackButton = new Button();
            AllSelectionTable = new DataGridView();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllSelectionTable).BeginInit();
            SuspendLayout();
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(576, 96);
            EntryLabel.TabIndex = 14;
            EntryLabel.Text = "Все подборки";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(AllSelectionTable);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 96);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(576, 532);
            MainPanel.TabIndex = 15;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(216, 490);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 39);
            BackButton.TabIndex = 18;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // AllSelectionTable
            // 
            AllSelectionTable.AllowUserToAddRows = false;
            AllSelectionTable.BackgroundColor = Color.White;
            AllSelectionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllSelectionTable.Dock = DockStyle.Top;
            AllSelectionTable.Location = new Point(0, 0);
            AllSelectionTable.Margin = new Padding(3, 4, 3, 4);
            AllSelectionTable.Name = "AllSelectionTable";
            AllSelectionTable.ReadOnly = true;
            AllSelectionTable.RowHeadersWidth = 51;
            AllSelectionTable.Size = new Size(576, 460);
            AllSelectionTable.TabIndex = 17;
            // 
            // AllSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(576, 628);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(325, 535);
            Name = "AllSelectionForm";
            Text = "AllSelectionForm";
            Load += AllSelectionForm_Load;
            Resize += AllSelectionForm_Resize;
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllSelectionTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label EntryLabel;
        private Panel MainPanel;
        private Button BackButton;
        private DataGridView AllSelectionTable;
    }
}