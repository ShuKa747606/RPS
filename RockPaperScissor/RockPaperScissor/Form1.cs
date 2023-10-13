using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Name: Shubh Kansara
// Started: June 29, 2023
// Playing Rock Paper Scissor with a CPU
namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        int ScorePlayer = 0;
        int ScoreBot = 0;
        int NumClicks = 0;
        int NumDraw = 0;
        int RockClicks = 0;
        int PaperClicks = 0;
        int ScissorClicks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            lblNote.Text = "Note: " + "Number of times you click = Rock Clicks + Paper Clicks + Scissor Clicks";
            lblConsider.Text = "Consider: " + "Number of times you click = Your Score + Opponent's Score + Number of times draw";

            RockClicks = RockClicks + 1;
            lblRockClicks.Text = "Number of times Rock was clicked: " + RockClicks;

            txtPlayer.Text = "Rock";            
            Random rand = new Random();
            int Possibility = rand.Next(1, 4);
            if (Possibility == 1)
            {
                txtBot.Text = "Rock";
            }
            if (Possibility == 2)
            {
                txtBot.Text = "Paper";
            }
            if (Possibility == 3)
            {
                txtBot.Text = "Scissor" ;
            }

            // Determining who gets the point
            if (txtPlayer.Text == "Rock" && txtBot.Text == "Paper")
            {                
                ScoreBot = ScoreBot + 1;
                ScorePlayer = ScorePlayer + 0;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;                
            }
            if (txtPlayer.Text == "Rock" && txtBot.Text == "Scissor")
            {
                ScoreBot = ScoreBot + 0;
                ScorePlayer = ScorePlayer + 1;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;
            }
            if (txtPlayer.Text == "Rock" && txtBot.Text == "Rock")
            {
                ScoreBot = ScoreBot + 0;
                ScorePlayer = ScorePlayer + 0;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;
                NumDraw = NumDraw + 1;
                lblNumDraw.Text = "Number of times where a draw has occurred: " + NumDraw;
            }

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            lblNote.Text = "Note: " + "Number of times you click = Rock Clicks + Paper Clicks + Scissor Clicks";
            lblConsider.Text = "Consider: " + "Number of times you click = Your Score + Opponent's Score + Number of times draw";

            PaperClicks = PaperClicks + 1;
            lblPaperClicks.Text = "Number of times Paper was clicked: " + PaperClicks;

            txtPlayer.Text = "Paper";
            Random rand = new Random();
            int PossibilityTwo = rand.Next(1, 4);
            if (PossibilityTwo == 1)
            {
                txtBot.Text = "Rock";
            }
            if (PossibilityTwo == 2)
            {
                txtBot.Text = "Paper";
            }
            if (PossibilityTwo == 3)
            {
                txtBot.Text = "Scissor";
            }

            // Determining who gets the point
            if (txtPlayer.Text == "Paper" && txtBot.Text == "Paper")
            {
                ScoreBot = ScoreBot + 0;
                ScorePlayer = ScorePlayer + 0;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;
                NumDraw = NumDraw + 1;
                lblNumDraw.Text = "Number of times where a draw has occurred: " + NumDraw;
            }
            if (txtPlayer.Text == "Paper" && txtBot.Text == "Scissor")
            {
                ScoreBot = ScoreBot + 1;
                ScorePlayer = ScorePlayer + 0;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;
            }
            if (txtPlayer.Text == "Paper" && txtBot.Text == "Rock")
            {
                ScoreBot = ScoreBot + 0;
                ScorePlayer = ScorePlayer + 1;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;
            }
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            lblNote.Text = "Note: " + "Number of times you click = Rock Clicks + Paper Clicks + Scissor Clicks";
            lblConsider.Text = "Consider: " + "Number of times you click = Your Score + Opponent's Score + Number of times draw";

            ScissorClicks = ScissorClicks + 1;
            lblScissorClicks.Text = "Number of times Scissor was clicked: " + ScissorClicks;

            txtPlayer.Text = "Scissor";
            Random rand = new Random();
            int PossibilityThree = rand.Next(1, 4);
            if (PossibilityThree == 1)
            {
                txtBot.Text = "Rock";
            }
            if (PossibilityThree == 2)
            {
                txtBot.Text = "Paper";
            }
            if (PossibilityThree == 3)
            {
                txtBot.Text = "Scissor";
            }

            // Determining who gets the point
            if (txtPlayer.Text == "Scissor" && txtBot.Text == "Paper")
            {
                ScoreBot = ScoreBot + 0;
                ScorePlayer = ScorePlayer + 1;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;
            }
            if (txtPlayer.Text == "Scissor" && txtBot.Text == "Scissor")
            {
                ScoreBot = ScoreBot + 0;
                ScorePlayer = ScorePlayer + 0;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;
                NumDraw = NumDraw + 1;
                lblNumDraw.Text = "Number of times where a draw has occurred: " + NumDraw;
            }
            if (txtPlayer.Text == "Scissor" && txtBot.Text == "Rock")
            {
                ScoreBot = ScoreBot + 1;
                ScorePlayer = ScorePlayer + 0;
                lblScorePlayer.Text = "Score: " + ScorePlayer;
                lblScoreBot.Text = "Score: " + ScoreBot;
                NumClicks = NumClicks + 1;
                lblNumClicks.Text = "Number of Clicks: " + NumClicks;
            }
        }
    }
}
