using System.Windows.Forms;

namespace MemoryGame2
{
    public partial class Game : Form
    {
        int width = 80;
        Random rnd = new Random();
        List<PictureBox> listPictureBoxs = new List<PictureBox>();
        List<Label> Listlabels = new List<Label>();
        int currentTiles = 1;
        int showingTime = DataInGame.Showing_time;
        int milisecond = 0;
        int second = 0;
        int lives = DataInGame.Lives;
        public Game()
        {
            InitializeComponent();
            lblPlayer.Text = DataInGame.Player;
            lblLives.Text = DataInGame.Lives.ToString();
            lblTiles.Text = DataInGame.Tiles.ToString();
            CreateListBox();

            this.Size = new Size(panel1.Width + width * DataInGame.Board_size + DataInGame.Board_size * 10 + width / 2,
                                 width / 2 + width * DataInGame.Board_size + DataInGame.Board_size * 10);
        }

        public void CreateListBox()
        {
            int y = 0;
            for (int i = 0; i < DataInGame.Board_size; i++)
            {
                int x = 0;
                for (int j = 0; j < DataInGame.Board_size; j++)
                {
                    MakePictureBox(x, y);
                    x += (width + 10);
                }
                y += (width + 10);
            }
        }

        public void hideLable()
        {
            for (int i = 0; i < Listlabels.Count; i++)
            {
                Listlabels[i].Visible = false;
            }
        }

        private void MakePictureBox(int x, int y)
        {
            PictureBox pbox = new PictureBox();
            pbox.Size = new Size(width, width);
            pbox.Location = new Point(x, y);
            pbox.BackColor = ColorTranslator.FromHtml("#287DF4");
            pbox.Click += PictureBox_Click;
            listPictureBoxs.Add(pbox);
            pnPictureBox.Controls.Add(pbox);
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            if (timePlay.Enabled)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Tag != null)
                {
                    if ((int)pictureBox.Tag == currentTiles)
                    {
                        pictureBox.Controls[0].Visible = true;
                        pictureBox.BackColor = ColorTranslator.FromHtml("#29FF38");
                        lblTiles.Text = (DataInGame.Tiles - currentTiles).ToString();
                        if (currentTiles == DataInGame.Tiles)
                        {
                            timePlay.Stop();
                            MessageBox.Show("You slove the puzzle in " + second + "." + milisecond + " second", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        currentTiles++;
                    }
                    else
                    {
                        pictureBox.BackColor = ColorTranslator.FromHtml("#E34053");
                        lives--;
                        lblLives.Text = lives.ToString();
                    }

                }
                else
                {
                    pictureBox.BackColor = ColorTranslator.FromHtml("#E34053");
                    lives--;
                    lblLives.Text = lives.ToString();
                }
                if (lives == 0)
                {
                    GameOver();
                }

            }
        }


        public void setNumberInBox()
        {

            for (int i = 0; i < DataInGame.Tiles; i++)
            {
                int num;
                do
                {
                    num = rnd.Next(0, listPictureBoxs.Count());
                }
                while (listPictureBoxs[num].Tag != null);
                listPictureBoxs[num].Tag = (i + 1);
                Label lbl = new Label();
                lbl.Text = (i + 1).ToString();
                lbl.Tag = (i + 1);
                lbl.Width = width;
                lbl.Height = width;
                lbl.Font = new Font("Segoe UI", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                listPictureBoxs[num].Controls.Add(lbl);
                Listlabels.Add(lbl);
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (!(btnStartGame.Text == "Try Again"))
            {
                btnStartGame.Text = "Try Again";
            }
            if (timePlay.Enabled)
            {
                timePlay.Stop();
            }
            if (timeShowing.Enabled)
            {
                timeShowing.Stop();
            }
            startGame();
            timeShowing.Start();

        }

        private void timePlay_Tick(object sender, EventArgs e)
        {
            milisecond++;
            if (milisecond % 10 == 0)
            {
                second++;
                milisecond = 0;
            }
            lblTime.Text = second + "." + milisecond;
        }

        private void timeShowing_Tick(object sender, EventArgs e)
        {
            showingTime--;
            lblTime.Text = showingTime.ToString();
            if (showingTime == 0)
            {
                timeShowing.Stop();
                hideLable();
                timePlay.Start();
            }
        }

        public void startGame()
        {
            milisecond = 0;
            second = 0;
            showingTime = DataInGame.Showing_time;
            lives = DataInGame.Lives;
            currentTiles = 1;
            lblTime.Text = showingTime.ToString();
            lblLives.Text = lives.ToString();
            lblTiles.Text = DataInGame.Tiles.ToString();
            Listlabels.Clear();
            foreach (var item in listPictureBoxs)
            {
                item.BackColor = ColorTranslator.FromHtml("#287DF4");
                item.Tag = null;
                item.Controls.Clear();
            }
            setNumberInBox();
        }
        public void GameOver()
        {
            timePlay.Stop();
            MessageBox.Show("Your live over and You lost. Try Again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (var item in Listlabels)
            {
                item.Visible = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }
    }
}