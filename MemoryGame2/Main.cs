using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MemoryGame2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (DataInGame.Player != "")
            {
                tbPlayer.Text = DataInGame.Player;
            }
            if (DataInGame.Board_size != 0)
            {
                tbSize.Text = DataInGame.Board_size.ToString();
            }
            if (DataInGame.Lives != 0)
            {
                tbLives.Text = DataInGame.Lives.ToString();
            }
            if (DataInGame.Showing_time != 0)
            {
                tbShowingT.Text = DataInGame.Showing_time.ToString();
            }
            if (DataInGame.Tiles != 0)
            {
                tbTiles.Text = DataInGame.Tiles.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (tbPlayer.Text == "")
                {
                    MessageBox.Show("Please enter your name before the starts. It cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbSize.Text == "")
                {
                    MessageBox.Show("Please enter size board. It should be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbLives.Text == "")
                {
                    MessageBox.Show("Please enter number of lives. It should be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbShowingT.Text == "")
                {
                    MessageBox.Show("Please enter time showing before the starts. It should be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbTiles.Text == "")
                {
                    MessageBox.Show("Please enter number of tiles before the starts. It should be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataInGame.Player = tbPlayer.Text;
                DataInGame.Board_size = int.Parse(tbSize.Text);
                DataInGame.Lives = int.Parse(tbLives.Text);
                DataInGame.Showing_time = int.Parse(tbShowingT.Text);
                DataInGame.Tiles = int.Parse(tbTiles.Text);
                if (DataInGame.Board_size * DataInGame.Board_size < DataInGame.Tiles)
                {
                    MessageBox.Show("The number of answer Tiles cannot be more than  number of all tiles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();
                Game game = new Game();
                game.Closed += (s, args) => this.Close();
                game.Show();
            }
            catch {
                MessageBox.Show("Check your data and try again .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                tbSize.Enabled = false;
                tbLives.Enabled = false;
                tbShowingT.Enabled = false;
                tbTiles.Enabled = false;
                tbSize.Text = "5";
                tbLives.Text = "4";
                tbShowingT.Text = "3";
                tbTiles.Text = "5";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                tbSize.Enabled = false;
                tbLives.Enabled = false;
                tbShowingT.Enabled = false;
                tbTiles.Enabled = false;
                tbSize.Text = "6";
                tbLives.Text = "3";
                tbShowingT.Text = "2";
                tbTiles.Text = "6";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                tbSize.Enabled = false;
                tbLives.Enabled = false;
                tbShowingT.Enabled = false;
                tbTiles.Enabled = false;
                tbSize.Text = "7";
                tbLives.Text = "1";
                tbShowingT.Text = "1";
                tbTiles.Text = "7";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                tbSize.Enabled = true;
                tbLives.Enabled = true;
                tbShowingT.Enabled = true;
                tbTiles.Enabled = true;

            }
        }
    }
}
