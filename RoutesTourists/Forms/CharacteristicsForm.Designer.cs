namespace RoutesTourists.Forms
{
    partial class CharacteristicsForm
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
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            MainPanel = new Panel();
            endBudget = new TextBox();
            endLabel_1 = new Label();
            startBudget = new TextBox();
            endDuration = new TextBox();
            startLabel_1 = new Label();
            endLabel = new Label();
            startLabel = new Label();
            startDuration = new TextBox();
            BackButton = new Button();
            seasonalityComboBox = new ComboBox();
            seasonalityLabel = new Label();
            budgetLabel = new Label();
            durationLabel = new Label();
            FilteredTable = new DataGridView();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilteredTable).BeginInit();
            SuspendLayout();
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(endBudget);
            MainPanel.Controls.Add(endLabel_1);
            MainPanel.Controls.Add(startBudget);
            MainPanel.Controls.Add(endDuration);
            MainPanel.Controls.Add(startLabel_1);
            MainPanel.Controls.Add(endLabel);
            MainPanel.Controls.Add(startLabel);
            MainPanel.Controls.Add(startDuration);
            MainPanel.Controls.Add(BackButton);
            MainPanel.Controls.Add(seasonalityComboBox);
            MainPanel.Controls.Add(seasonalityLabel);
            MainPanel.Controls.Add(budgetLabel);
            MainPanel.Controls.Add(durationLabel);
            MainPanel.Controls.Add(FilteredTable);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(900, 528);
            MainPanel.TabIndex = 0;
            // 
            // endBudget
            // 
            endBudget.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endBudget.Location = new Point(478, 440);
            endBudget.Margin = new Padding(3, 4, 3, 4);
            endBudget.Name = "endBudget";
            endBudget.Size = new Size(105, 30);
            endBudget.TabIndex = 30;
            // 
            // endLabel_1
            // 
            endLabel_1.AutoSize = true;
            endLabel_1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endLabel_1.Location = new Point(440, 443);
            endLabel_1.Name = "endLabel_1";
            endLabel_1.Size = new Size(47, 31);
            endLabel_1.TabIndex = 29;
            endLabel_1.Text = "До";
            // 
            // startBudget
            // 
            startBudget.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startBudget.Location = new Point(328, 441);
            startBudget.Margin = new Padding(3, 4, 3, 4);
            startBudget.Name = "startBudget";
            startBudget.Size = new Size(105, 30);
            startBudget.TabIndex = 28;
            // 
            // endDuration
            // 
            endDuration.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endDuration.Location = new Point(227, 441);
            endDuration.Margin = new Padding(3, 4, 3, 4);
            endDuration.Name = "endDuration";
            endDuration.Size = new Size(47, 30);
            endDuration.TabIndex = 27;
            // 
            // startLabel_1
            // 
            startLabel_1.AutoSize = true;
            startLabel_1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startLabel_1.Location = new Point(281, 440);
            startLabel_1.Name = "startLabel_1";
            startLabel_1.Size = new Size(47, 31);
            startLabel_1.TabIndex = 26;
            startLabel_1.Text = "От";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endLabel.Location = new Point(181, 440);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(47, 31);
            endLabel.TabIndex = 25;
            endLabel.Text = "До";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startLabel.Location = new Point(79, 440);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(47, 31);
            startLabel.TabIndex = 24;
            startLabel.Text = "От";
            // 
            // startDuration
            // 
            startDuration.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startDuration.Location = new Point(126, 440);
            startDuration.Margin = new Padding(3, 4, 3, 4);
            startDuration.Name = "startDuration";
            startDuration.Size = new Size(47, 30);
            startDuration.TabIndex = 23;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(384, 479);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(103, 40);
            BackButton.TabIndex = 22;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // seasonalityComboBox
            // 
            seasonalityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            seasonalityComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            seasonalityComboBox.FormattingEnabled = true;
            seasonalityComboBox.Items.AddRange(new object[] { "Зима", "Весна", "Лето", "Осень" });
            seasonalityComboBox.Location = new Point(590, 436);
            seasonalityComboBox.Margin = new Padding(3, 4, 3, 4);
            seasonalityComboBox.Name = "seasonalityComboBox";
            seasonalityComboBox.Size = new Size(188, 35);
            seasonalityComboBox.TabIndex = 21;
            // 
            // seasonalityLabel
            // 
            seasonalityLabel.AutoSize = true;
            seasonalityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            seasonalityLabel.Location = new Point(617, 381);
            seasonalityLabel.Name = "seasonalityLabel";
            seasonalityLabel.Size = new Size(155, 31);
            seasonalityLabel.TabIndex = 20;
            seasonalityLabel.Text = "Сезонность";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(384, 381);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(109, 31);
            budgetLabel.TabIndex = 19;
            budgetLabel.Text = "Бюджет";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(104, 381);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(185, 31);
            durationLabel.TabIndex = 18;
            durationLabel.Text = "Длительность";
            // 
            // FilteredTable
            // 
            FilteredTable.AllowUserToAddRows = false;
            FilteredTable.BackgroundColor = Color.White;
            FilteredTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilteredTable.Dock = DockStyle.Top;
            FilteredTable.Location = new Point(0, 0);
            FilteredTable.Margin = new Padding(3, 4, 3, 4);
            FilteredTable.Name = "FilteredTable";
            FilteredTable.ReadOnly = true;
            FilteredTable.RowHeadersWidth = 51;
            FilteredTable.Size = new Size(900, 368);
            FilteredTable.TabIndex = 17;
            // 
            // CharacteristicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 528);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(815, 500);
            Name = "CharacteristicsForm";
            Text = "CharacteristicsForm";
            Load += CharacteristicsForm_Load;
            Resize += CharacteristicsForm_Resize;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FilteredTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Panel MainPanel;
        private TextBox endBudget;
        private Label endLabel_1;
        private TextBox startBudget;
        private TextBox endDuration;
        private Label startLabel_1;
        private Label endLabel;
        private Label startLabel;
        private TextBox startDuration;
        private Button BackButton;
        private ComboBox seasonalityComboBox;
        private Label seasonalityLabel;
        private Label budgetLabel;
        private Label durationLabel;
        private DataGridView FilteredTable;
    }
}