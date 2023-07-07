using System.Diagnostics.Metrics;

namespace FrogsInSwampWinFormsApp
{
    public partial class MainForm : Form
    {
        private int numberMovesFrogs = 0;

        private int minNumberMovesToWins = 24;

        public int NumberMovesFrogs
        {
            get { return numberMovesFrogs; }
            set { numberMovesFrogs = value; }
        }

        public int MinNumberMovesToWins
        {
            get { return minNumberMovesToWins; }
            set { minNumberMovesToWins = value; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void frogPictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);

            if (EndGame())
            {
                if (CanBeFewerSteps())
                {

                }
                WinsForm winsForm = new WinsForm();
                winsForm.Show();
            }
        }

        private bool CanBeFewerSteps()
        {
            if(numberMovesFrogs > minNumberMovesToWins)
            {
                return false;
            }

            return true;
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("Так двигать нельзя!");
            }
            else
            {
                var location = clickedPicture.Location;

                clickedPicture.Location = emptyPictureBox.Location;

                emptyPictureBox.Location = location;

                numberMovesFrogs++;

                numberMovesLabel.Text = numberMovesFrogs.ToString();                
            }
        }

        private bool EndGame()
        {
            if (frogLeftPictureBox1.Location.X > emptyPictureBox.Location.X &&
                frogLeftPictureBox2.Location.X > emptyPictureBox.Location.X &&
                frogLeftPictureBox3.Location.X > emptyPictureBox.Location.X &&
                frogLeftPictureBox4.Location.X > emptyPictureBox.Location.X &&
                frogRightPictureBox1.Location.X < emptyPictureBox.Location.X &&
                frogRightPictureBox2.Location.X < emptyPictureBox.Location.X &&
                frogRightPictureBox3.Location.X < emptyPictureBox.Location.X &&
                frogRightPictureBox4.Location.X < emptyPictureBox.Location.X)
            {
                return true;
            }

            return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rulesGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void forProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            minNumberMovesToWinsLabel.Text = minNumberMovesToWins.ToString();
        }
    }
}