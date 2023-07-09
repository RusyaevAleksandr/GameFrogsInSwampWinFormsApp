namespace FrogsInSwampWinFormsApp
{
    public partial class MainForm : Form
    {
        private int numberMovesFrogs = 0;

        private int minNumberMovesToWins = 24;

        public MainForm()
        {
            InitializeComponent();
        }

        private void frogPictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);

            if (EndGame())
            {
                if (CanBeFewerSteps(numberMovesLabel.Text))
                {
                    MessageBox.Show("¬ы справились за минимальное кол-во ходов!");
                }
                else
                {
                    var winsMessage = MessageBox.Show("ћожно улучшить результат. " +
                        "’отите попробовать еще раз?",
                        " онец игры", MessageBoxButtons.YesNo);
                    if (winsMessage == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    if (winsMessage == DialogResult.No)
                    {
                        MessageBox.Show("»гра закончилась. ¬ыберите действие в ћеню.");
                    }
                }
            }
        }

        private bool CanBeFewerSteps(string numberMovesLabel)
        {
            try
            {
                var presentValueMovesFrogs = Convert.ToInt32(numberMovesLabel);

                if (presentValueMovesFrogs < minNumberMovesToWins)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("“ак двигать нельз€!");
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
                frogLeftPictureBox1.Enabled = false;
                frogLeftPictureBox2.Enabled = false;
                frogLeftPictureBox3.Enabled = false;
                frogLeftPictureBox4.Enabled = false;

                frogRightPictureBox1.Enabled = false;
                frogRightPictureBox2.Enabled = false;
                frogRightPictureBox3.Enabled = false;
                frogRightPictureBox4.Enabled = false;

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
            MessageBox.Show($" оротка€ игра головоломка на логику.\n\n" +
                $"   Ќа листах в болоте сидит восемь л€гушек: четыре л€гушки смотр€т направо и четыре л€гушки смотр€т налево, между ними пустой листок.\n\n " +
                $"ѕри помощи кликов мыши нужно помен€ть их местами, чтобы четыре л€гушки которые смотр€т направо оказались справа, а четыре л€гушки которые смотр€т налево переместились влево, " +
                $"выполнить это нужно за минимальное кол-во ходов. " +
                $" ажда€ л€гушка может либо переместитьс€ вперед или назад на один шаг, либо перепрыгнуть через одну л€гушку, если за ней есть свободный лист.", "ѕравила игры");
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