namespace FrogsInSwampWinFormsApp
{
    public partial class WinsForm : Form
    {
        private MainForm mainForm = new MainForm();

        public WinsForm()
        {
            InitializeComponent();
        }

        private void RestartGameButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void WinsForm_Shown(object sender, EventArgs e)
        {
            winsInfoLabel.Text = SetTextVictoryMessage(mainForm.NumberMovesFrogs, mainForm.MinNumberMovesToWins);
        }

        private string SetTextVictoryMessage(int numberMovesFrogs, int minNumberMovesToWins)
        {
            if (numberMovesFrogs > minNumberMovesToWins)
            {
                return "Поздравляем с победой! Но можно лучше! Попробуйте еще раз.";
            }
            else
            {
                return "Поздравляем с победой! Вы переместили лягушек за минимальное количество ходов!";
            }
        }
    }
}
