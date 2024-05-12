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
            SelectionTable = new DataGridView();
            BackButton = new Button();
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
            EntryLabel.Size = new Size(504, 72);
            EntryLabel.TabIndex = 1;
            EntryLabel.Text = "Мои подборки";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SelectionTable
            // 
            SelectionTable.AllowUserToAddRows = false;
            SelectionTable.BackgroundColor = Color.White;
            SelectionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelectionTable.Location = new Point(0, 75);
            SelectionTable.Name = "SelectionTable";
            SelectionTable.ReadOnly = true;
            SelectionTable.Size = new Size(504, 345);
            SelectionTable.TabIndex = 4;
            SelectionTable.CellDoubleClick += SelectionTable_CellDoubleClick;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(189, 440);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 29);
            BackButton.TabIndex = 13;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 471);
            Controls.Add(BackButton);
            Controls.Add(SelectionTable);
            Controls.Add(EntryLabel);
            Name = "SelectionForm";
            Text = "SelectionForm";
            Load += SelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)SelectionTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label EntryLabel;
        private DataGridView SelectionTable;
        private Button BackButton;
    }
}