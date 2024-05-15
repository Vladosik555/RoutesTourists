namespace RoutesTourists.Forms
{
    partial class SelectionForm
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
            SelectionTable = new DataGridView();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SelectionTable).BeginInit();
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
            EntryLabel.Text = "Мои подборки";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(SelectionTable);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 96);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(900, 432);
            MainPanel.TabIndex = 2;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(374, 380);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 39);
            BackButton.TabIndex = 15;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // SelectionTable
            // 
            SelectionTable.AllowUserToAddRows = false;
            SelectionTable.BackgroundColor = Color.White;
            SelectionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelectionTable.Dock = DockStyle.Top;
            SelectionTable.Location = new Point(0, 0);
            SelectionTable.Margin = new Padding(3, 4, 3, 4);
            SelectionTable.Name = "SelectionTable";
            SelectionTable.ReadOnly = true;
            SelectionTable.RowHeadersWidth = 51;
            SelectionTable.Size = new Size(900, 299);
            SelectionTable.TabIndex = 14;
            // 
            // SelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 528);
            Controls.Add(MainPanel);
            Controls.Add(EntryLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(325, 535);
            Name = "SelectionForm";
            Text = "SelectionForm";
            Load += SelectionForm_Load;
            Resize += SelectionForm_Resize;
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SelectionTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label EntryLabel;
        private Panel MainPanel;
        private Button BackButton;
        private DataGridView SelectionTable;
    }
}