namespace MemoryGame2
{
    partial class Main
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            tbTiles = new TextBox();
            tbShowingT = new TextBox();
            tbLives = new TextBox();
            tbSize = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbPlayer = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(296, 50);
            label1.TabIndex = 0;
            label1.Text = "Memory Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbPlayer);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 390);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Custum..." });
            comboBox1.Location = new Point(169, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 347);
            button1.Name = "button1";
            button1.Size = new Size(290, 37);
            button1.TabIndex = 4;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(tbTiles);
            groupBox2.Controls.Add(tbShowingT);
            groupBox2.Controls.Add(tbLives);
            groupBox2.Controls.Add(tbSize);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(6, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 214);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // tbTiles
            // 
            tbTiles.Enabled = false;
            tbTiles.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbTiles.Location = new Point(194, 151);
            tbTiles.Name = "tbTiles";
            tbTiles.Size = new Size(73, 33);
            tbTiles.TabIndex = 11;
            // 
            // tbShowingT
            // 
            tbShowingT.Enabled = false;
            tbShowingT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbShowingT.Location = new Point(194, 104);
            tbShowingT.Name = "tbShowingT";
            tbShowingT.Size = new Size(73, 33);
            tbShowingT.TabIndex = 10;
            // 
            // tbLives
            // 
            tbLives.Enabled = false;
            tbLives.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbLives.Location = new Point(194, 59);
            tbLives.Name = "tbLives";
            tbLives.Size = new Size(73, 33);
            tbLives.TabIndex = 9;
            // 
            // tbSize
            // 
            tbSize.Enabled = false;
            tbSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbSize.Location = new Point(194, 16);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(73, 33);
            tbSize.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 159);
            label7.Name = "label7";
            label7.Size = new Size(159, 25);
            label7.TabIndex = 7;
            label7.Text = "Number of Tiles:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 112);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 6;
            label6.Text = "Showing Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 67);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 5;
            label5.Text = "Number of Lives:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 4;
            label4.Text = "Board Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 2;
            label3.Text = "Difficulty";
            // 
            // tbPlayer
            // 
            tbPlayer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbPlayer.Location = new Point(6, 54);
            tbPlayer.Name = "tbPlayer";
            tbPlayer.Size = new Size(284, 33);
            tbPlayer.TabIndex = 1;
            tbPlayer.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(284, 23);
            label2.TabIndex = 0;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(320, 493);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox tbTiles;
        private TextBox tbShowingT;
        private TextBox tbLives;
        private TextBox tbSize;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbPlayer;
        private Label label2;
        private ComboBox comboBox1;
    }
}