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
            FilteredTable = new DataGridView();
            durationLabel = new Label();
            budgetLabel = new Label();
            seasonalityLabel = new Label();
            seasonalityComboBox = new ComboBox();
            BackButton = new Button();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            startDuration = new TextBox();
            startLabel = new Label();
            endLabel = new Label();
            startLabel_1 = new Label();
            endDuration = new TextBox();
            startBudget = new TextBox();
            endLabel_1 = new Label();
            endBudget = new TextBox();
            ((System.ComponentModel.ISupportInitialize)FilteredTable).BeginInit();
            SuspendLayout();
            // 
            // FilteredTable
            // 
            FilteredTable.AllowUserToAddRows = false;
            FilteredTable.Anchor = AnchorStyles.None;
            FilteredTable.BackgroundColor = Color.White;
            FilteredTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilteredTable.Location = new Point(0, 0);
            FilteredTable.Margin = new Padding(3, 4, 3, 4);
            FilteredTable.Name = "FilteredTable";
            FilteredTable.ReadOnly = true;
            FilteredTable.RowHeadersWidth = 51;
            FilteredTable.Size = new Size(702, 368);
            FilteredTable.TabIndex = 0;
            FilteredTable.CellDoubleClick += FilteredTable_CellDoubleClick;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(26, 373);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(185, 31);
            durationLabel.TabIndex = 1;
            durationLabel.Text = "Длительность";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(306, 373);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(109, 31);
            budgetLabel.TabIndex = 2;
            budgetLabel.Text = "Бюджет";
            // 
            // seasonalityLabel
            // 
            seasonalityLabel.AutoSize = true;
            seasonalityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            seasonalityLabel.Location = new Point(539, 373);
            seasonalityLabel.Name = "seasonalityLabel";
            seasonalityLabel.Size = new Size(155, 31);
            seasonalityLabel.TabIndex = 3;
            seasonalityLabel.Text = "Сезонность";
            // 
            // seasonalityComboBox
            // 
            seasonalityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            seasonalityComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            seasonalityComboBox.FormattingEnabled = true;
            seasonalityComboBox.Items.AddRange(new object[] { "Зима", "Весна", "Лето", "Осень" });
            seasonalityComboBox.Location = new Point(512, 428);
            seasonalityComboBox.Margin = new Padding(3, 4, 3, 4);
            seasonalityComboBox.Name = "seasonalityComboBox";
            seasonalityComboBox.Size = new Size(188, 35);
            seasonalityComboBox.TabIndex = 6;
            seasonalityComboBox.SelectedIndexChanged += seasonalityComboBox_SelectedIndexChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(299, 544);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(103, 40);
            BackButton.TabIndex = 7;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // startDuration
            // 
            startDuration.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startDuration.Location = new Point(48, 432);
            startDuration.Margin = new Padding(3, 4, 3, 4);
            startDuration.Name = "startDuration";
            startDuration.Size = new Size(47, 30);
            startDuration.TabIndex = 8;
            startDuration.TextChanged += startDuration_TextChanged;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startLabel.Location = new Point(1, 432);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(47, 31);
            startLabel.TabIndex = 9;
            startLabel.Text = "От";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endLabel.Location = new Point(103, 432);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(47, 31);
            endLabel.TabIndex = 10;
            endLabel.Text = "До";
            // 
            // startLabel_1
            // 
            startLabel_1.AutoSize = true;
            startLabel_1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startLabel_1.Location = new Point(203, 432);
            startLabel_1.Name = "startLabel_1";
            startLabel_1.Size = new Size(47, 31);
            startLabel_1.TabIndex = 11;
            startLabel_1.Text = "От";
            // 
            // endDuration
            // 
            endDuration.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endDuration.Location = new Point(149, 433);
            endDuration.Margin = new Padding(3, 4, 3, 4);
            endDuration.Name = "endDuration";
            endDuration.Size = new Size(47, 30);
            endDuration.TabIndex = 13;
            endDuration.TextChanged += endDuration_TextChanged;
            // 
            // startBudget
            // 
            startBudget.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startBudget.Location = new Point(250, 433);
            startBudget.Margin = new Padding(3, 4, 3, 4);
            startBudget.Name = "startBudget";
            startBudget.Size = new Size(105, 30);
            startBudget.TabIndex = 14;
            startBudget.TextChanged += startBudget_TextChanged;
            // 
            // endLabel_1
            // 
            endLabel_1.AutoSize = true;
            endLabel_1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endLabel_1.Location = new Point(362, 435);
            endLabel_1.Name = "endLabel_1";
            endLabel_1.Size = new Size(47, 31);
            endLabel_1.TabIndex = 15;
            endLabel_1.Text = "До";
            // 
            // endBudget
            // 
            endBudget.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endBudget.Location = new Point(400, 432);
            endBudget.Margin = new Padding(3, 4, 3, 4);
            endBudget.Name = "endBudget";
            endBudget.Size = new Size(105, 30);
            endBudget.TabIndex = 16;
            endBudget.TextChanged += endBudget_TextChanged;
            // 
            // CharacteristicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(702, 600);
            Controls.Add(endBudget);
            Controls.Add(endLabel_1);
            Controls.Add(startBudget);
            Controls.Add(endDuration);
            Controls.Add(startLabel_1);
            Controls.Add(endLabel);
            Controls.Add(startLabel);
            Controls.Add(startDuration);
            Controls.Add(BackButton);
            Controls.Add(seasonalityComboBox);
            Controls.Add(seasonalityLabel);
            Controls.Add(budgetLabel);
            Controls.Add(durationLabel);
            Controls.Add(FilteredTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CharacteristicsForm";
            Text = "CharacteristicsForm";
            Load += CharacteristicsForm_Load;
            ((System.ComponentModel.ISupportInitialize)FilteredTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FilteredTable;
        private Label durationLabel;
        private Label budgetLabel;
        private Label seasonalityLabel;
        private ComboBox seasonalityComboBox;
        private Button BackButton;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private TextBox startDuration;
        private Label startLabel;
        private Label endLabel;
        private Label startLabel_1;
        private TextBox endDuration;
        private TextBox startBudget;
        private Label endLabel_1;
        private TextBox endBudget;
    }
}