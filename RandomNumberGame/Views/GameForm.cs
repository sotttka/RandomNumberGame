using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace RandomNumberGame
{
    public partial class GameForm : MaterialForm
    {
        private Random _random;

        private int _randomNumber;

        private int _attempts;

        private const int MAX_ATTEMPTS = 3;

        private const int MAX_NUMBER = 9;

        private const int MIN_NUMBER = 0;

        public GameForm()
        {
            InitializeComponent();
            InitDefaultDesign();

            _random = new Random();
            _randomNumber = _random.Next(MIN_NUMBER, MAX_NUMBER);
            _attempts = 0;
        }

        private void InitDefaultDesign()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void tryGuessNumber_Click(object sender, System.EventArgs e)
        {
            int result;
            if(!int.TryParse(inputGuessNumber.Text, out result))
            {
                answerLabel.Text = "Неверный формат ввода.";
                return;
            }

            attemptsLabel.Text = $"Попыток осталось: {MAX_ATTEMPTS - _attempts - 1}";

            answerLabel.Text = _randomNumber < result ? "Загаданное число меньше." : "Загаданное число больше.";
            _attempts++;

            IsNumberEqual(result);
            IsAttemptsEnd();
        }

        private bool IsAttemptsEnd()
        {
            if (_attempts == MAX_ATTEMPTS)
            {
                answerLabel.Text = "Вы проиграли.";
                _attempts = 0;
                _randomNumber = _random.Next(MIN_NUMBER, MAX_NUMBER);
                return true;
            }

            return false;
        }

        private bool IsNumberEqual(int number)
        {
            if (number == _randomNumber)
            {
                answerLabel.Text = "Вы угадали число!";
                _attempts = 0;
                _randomNumber = _random.Next(MIN_NUMBER, MAX_NUMBER);
                return true;
            }

            return false;
        }
    }
}
