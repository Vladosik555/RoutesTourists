namespace RoutesTourists.Forms
{
    partial class EditingForm
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            NameLabel = new Label();
            BackButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // EntryLabel
            // 
            EntryLabel.BackColor = Color.Cyan;
            EntryLabel.Dock = DockStyle.Top;
            EntryLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EntryLabel.Location = new Point(0, 0);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(459, 78);
            EntryLabel.TabIndex = 2;
            EntryLabel.Text = "Редактирование";
            EntryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(192, 255, 255);
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(190, 241);
            label8.Name = "label8";
            label8.Size = new Size(264, 23);
            label8.TabIndex = 74;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(192, 255, 255);
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(187, 201);
            label7.Name = "label7";
            label7.Size = new Size(267, 23);
            label7.TabIndex = 73;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(192, 255, 255);
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(187, 157);
            label6.Name = "label6";
            label6.Size = new Size(267, 23);
            label6.TabIndex = 72;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(192, 255, 255);
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(187, 118);
            label5.Name = "label5";
            label5.Size = new Size(267, 23);
            label5.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(96, 242);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 70;
            label4.Text = "Почта ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(7, 201);
            label3.Name = "label3";
            label3.Size = new Size(158, 22);
            label3.TabIndex = 69;
            label3.Text = "Номер телефона ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(72, 158);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 68;
            label1.Text = "Фамилия";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(118, 117);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(47, 22);
            NameLabel.TabIndex = 67;
            NameLabel.Text = "Имя";
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.Cyan;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(158, 328);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(121, 33);
            BackButton.TabIndex = 75;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Cyan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(132, 289);
            button1.Name = "button1";
            button1.Size = new Size(178, 33);
            button1.TabIndex = 76;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = false;
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 362);
            Controls.Add(button1);
            Controls.Add(BackButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(NameLabel);
            Controls.Add(EntryLabel);
            Name = "EditingForm";
            Text = "EditingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EntryLabel;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label NameLabel;
        private Button BackButton;
        private Button button1;
    }
}