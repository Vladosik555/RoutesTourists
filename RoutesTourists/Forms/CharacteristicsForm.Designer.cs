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
            durationComboBox = new ComboBox();
            budgetComboBox = new ComboBox();
            seasonalityComboBox = new ComboBox();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)FilteredTable).BeginInit();
            SuspendLayout();
            // 
            // FilteredTable
            // 
            FilteredTable.BackgroundColor = Color.White;
            FilteredTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilteredTable.Location = new Point(1, 1);
            FilteredTable.Name = "FilteredTable";
            FilteredTable.ReadOnly = true;
            FilteredTable.Size = new Size(524, 276);
            FilteredTable.TabIndex = 0;
            FilteredTable.CellDoubleClick += FilteredTable_CellDoubleClick;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            durationLabel.Location = new Point(23, 280);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(143, 24);
            durationLabel.TabIndex = 1;
            durationLabel.Text = "Длительность";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            budgetLabel.Location = new Point(227, 280);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(84, 24);
            budgetLabel.TabIndex = 2;
            budgetLabel.Text = "Бюджет";
            // 
            // seasonalityLabel
            // 
            seasonalityLabel.AutoSize = true;
            seasonalityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            seasonalityLabel.Location = new Point(381, 280);
            seasonalityLabel.Name = "seasonalityLabel";
            seasonalityLabel.Size = new Size(119, 24);
            seasonalityLabel.TabIndex = 3;
            seasonalityLabel.Text = "Сезонность";
            // 
            // durationComboBox
            // 
            durationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            durationComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            durationComboBox.FormattingEnabled = true;
            durationComboBox.Items.AddRange(new object[] { "0 - 3 дней", "4 - 7 дней", "7 - 12 дней", "12 - 20 дней", "20 - 30 дней" });
            durationComboBox.Location = new Point(12, 307);
            durationComboBox.Name = "durationComboBox";
            durationComboBox.Size = new Size(165, 29);
            durationComboBox.TabIndex = 4;
            durationComboBox.SelectedIndexChanged += durationComboBox_SelectedIndexChanged;
            // 
            // budgetComboBox
            // 
            budgetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            budgetComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetComboBox.FormattingEnabled = true;
            budgetComboBox.Items.AddRange(new object[] { "0 - 50000 рублей", "50000 - 100000 рублей", "100000 - 150000 рублей", "150000 - 200000 рублей", "200000 - 250000 рублей", "250000 - 300000 рублей", "более 300000 рублей" });
            budgetComboBox.Location = new Point(183, 307);
            budgetComboBox.Name = "budgetComboBox";
            budgetComboBox.Size = new Size(165, 29);
            budgetComboBox.TabIndex = 5;
            budgetComboBox.SelectedIndexChanged += budgetComboBox_SelectedIndexChanged;
            // 
            // seasonalityComboBox
            // 
            seasonalityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            seasonalityComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            seasonalityComboBox.FormattingEnabled = true;
            seasonalityComboBox.Items.AddRange(new object[] { "Зима", "Весна", "Лето", "Осень" });
            seasonalityComboBox.Location = new Point(354, 307);
            seasonalityComboBox.Name = "seasonalityComboBox";
            seasonalityComboBox.Size = new Size(165, 29);
            seasonalityComboBox.TabIndex = 6;
            seasonalityComboBox.SelectedIndexChanged += seasonalityComboBox_SelectedIndexChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(221, 408);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(90, 30);
            BackButton.TabIndex = 7;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CharacteristicsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(526, 450);
            Controls.Add(BackButton);
            Controls.Add(seasonalityComboBox);
            Controls.Add(budgetComboBox);
            Controls.Add(durationComboBox);
            Controls.Add(seasonalityLabel);
            Controls.Add(budgetLabel);
            Controls.Add(durationLabel);
            Controls.Add(FilteredTable);
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
        private ComboBox durationComboBox;
        private ComboBox budgetComboBox;
        private ComboBox seasonalityComboBox;
        private Button BackButton;
    }
}