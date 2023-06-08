namespace MemoryGame2
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button2 = new Button();
            btnStartGame = new Button();
            groupBox2 = new GroupBox();
            lblLives = new Label();
            lblTiles = new Label();
            lblPlayer = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblTime = new Label();
            label1 = new Label();
            pnPictureBox = new Panel();
            timePlay = new System.Windows.Forms.Timer(components);
            timeShowing = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnStartGame);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 474);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(3, 300);
            button2.Name = "button2";
            button2.Size = new Size(227, 34);
            button2.TabIndex = 3;
            button2.Text = "Back To Main Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnStartGame
            // 
            btnStartGame.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartGame.Location = new Point(3, 248);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(227, 34);
            btnStartGame.TabIndex = 2;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblLives);
            groupBox2.Controls.Add(lblTiles);
            groupBox2.Controls.Add(lblPlayer);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(3, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 116);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblLives
            // 
            lblLives.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLives.Location = new Point(111, 85);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(110, 23);
            lblLives.TabIndex = 7;
            lblLives.Text = "Time";
            lblLives.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTiles
            // 
            lblTiles.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTiles.Location = new Point(111, 51);
            lblTiles.Name = "lblTiles";
            lblTiles.Size = new Size(110, 23);
            lblTiles.TabIndex = 6;
            lblTiles.Text = "Time";
            lblTiles.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayer
            // 
            lblPlayer.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.Location = new Point(111, 19);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(110, 23);
            lblPlayer.TabIndex = 5;
            lblPlayer.Text = "Time";
            lblPlayer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 85);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 4;
            label4.Text = "Lives Left :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 3;
            label3.Text = "Tiles Left :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 2;
            label2.Text = "Player :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTime);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(6, 58);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(221, 27);
            lblTime.TabIndex = 1;
            lblTime.Text = "0.0";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(221, 27);
            label1.TabIndex = 0;
            label1.Text = "Time";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnPictureBox
            // 
            pnPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnPictureBox.BackColor = Color.Khaki;
            pnPictureBox.Location = new Point(239, 2);
            pnPictureBox.Name = "pnPictureBox";
            pnPictureBox.Size = new Size(558, 473);
            pnPictureBox.TabIndex = 1;
            // 
            // timePlay
            // 
            timePlay.Tick += timePlay_Tick;
            // 
            // timeShowing
            // 
            timeShowing.Interval = 1000;
            timeShowing.Tick += timeShowing_Tick;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 476);
            Controls.Add(pnPictureBox);
            Controls.Add(panel1);
            Name = "Game";
            Text = "Game";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnPictureBox;
        private GroupBox groupBox2;
        private Label lblLives;
        private Label lblTiles;
        private Label lblPlayer;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblTime;
        private Label label1;
        private Button button2;
        private Button btnStartGame;
        private System.Windows.Forms.Timer timePlay;
        private System.Windows.Forms.Timer timeShowing;
    }
}