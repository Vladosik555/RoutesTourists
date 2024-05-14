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
            AllSelectionTable = new DataGridView();
            EntryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AllSelectionTable).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(189, 441);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 29);
            BackButton.TabIndex = 16;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AllSelectionTable
            // 
            AllSelectionTable.AllowUserToAddRows = false;
            AllSelectionTable.BackgroundColor = Color.White;
            AllSelectionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllSelectionTable.Location = new Point(0, 76);
            AllSelectionTable.Name = "AllSelectionTable";
            AllSelectionTable.ReadOnly = true;
            AllSelectionTable.Size = new Size(504, 345);
            AllSelectionTable.TabIndex = 15;
            AllSelectionTable.CellDoubleClick += AllSelectionTable_CellDoubleClick;
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(504, 72);
            EntryLabel.TabIndex = 14;
            EntryLabel.Text = "Все подборки";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AllSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 471);
            Controls.Add(BackButton);
            Controls.Add(AllSelectionTable);
            Controls.Add(EntryLabel);
            Name = "AllSelectionForm";
            Text = "AllSelectionForm";
            Load += AllSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)AllSelectionTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private DataGridView AllSelectionTable;
        private Label EntryLabel;
    }
}