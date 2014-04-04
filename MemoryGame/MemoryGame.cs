using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryGame : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;
        Random randomGenerator = new Random();

        public MemoryGame()
        {
            InitializeComponent();
            InitCards();
        }

        private void InitCards()
        {
            List<string> icons = new List<string>() { "!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z" };
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                Label currentLabel = (Label)item;

                int randomNumber = randomGenerator.Next(icons.Count);
                currentLabel.Text = icons[randomNumber];
                currentLabel.ForeColor = currentLabel.BackColor;
                icons.RemoveAt(randomNumber);
            }
        }

        private void Cheat()
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                Label currentLabel = (Label)item;
                currentLabel.ForeColor = Color.Black;
            }

            CheckBoard();
        }      


        private void CheckBoard()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel.ForeColor == iconLabel.BackColor)
                {
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("You matched all the icons!\nPlay again?", "Congratulations!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InitCards();
            }
            else
            {
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            firstClicked.ForeColor = secondClicked.ForeColor = firstClicked.BackColor;
            firstClicked = secondClicked = null;
            timer1.Stop();
        }

        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Cheat();
                return;
            }

            if (timer1.Enabled == true)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckBoard();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            else
            {
                timer1.Start();
            }
        }

    }
}
