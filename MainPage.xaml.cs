namespace CalculatorApp
{
    // This is the MainPage class that is used to create the calculator app.
    public partial class MainPage : ContentPage
    {
        private string _mainDisplayText;
        private int _firstNumber;
        private int _secondNumber;
        private int _totalNumber;
        private string _calculatingMethod;

        // This is the constructor for the MainPage class.
        public MainPage()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);
        }

        // This method is used to update the display with the current mainDisplayText value.
        public void updateDisplay()
        {
            mainDisplay.Text = _mainDisplayText;
        }

        // This method is used to handle the event when the number buttons are clicked.
        private void NumberButton1_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "1";
            updateDisplay();

        }

        private void NumberButton2_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "2";
            updateDisplay();

        }

        private void NumberButton3_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "3";
            updateDisplay();

        }

        private void NumberButton4_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "4";
            updateDisplay();

        }

        private void NumberButton5_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "5";
            updateDisplay();

        }

        private void NumberButton6_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "6";
            updateDisplay();

        }

        private void NumberButton7_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "7";
            updateDisplay();

        }

        private void NumberButton8_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "8";
            updateDisplay();

        }

        private void NumberButton9_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "9";
            updateDisplay();

        }

        private void NumberButton0_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText += "0";
            updateDisplay();

        }

        // This method is used to handle the event when the function buttons are clicked.
        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = "";
            _firstNumber = 0;
            _secondNumber = 0;
            _calculatingMethod = "";
            updateDisplay();
        }

        // This method is used to handle the event when the function buttons are clicked.
        private void FuntionButtonPlus_Clicked(object sender, EventArgs e)
        {
            if (_firstNumber == 0)
            {
                _firstNumber = int.Parse(_mainDisplayText);
            }

            _calculatingMethod = "plus";

            _mainDisplayText = "";

            //System.Diagnostics.Debug.WriteLine(firstNumber);
        }

        // This method is used to handle the event when the - button is clicked.
        private void FunctionButtonMinus_Clicked(object sender, EventArgs e)
        {
            if (_firstNumber == 0)
            {
                _firstNumber = int.Parse(_mainDisplayText);
            }

            _calculatingMethod = "plus";

            _mainDisplayText = "";
        }

        // This method is used to handle the event when the = button is clicked.
        private void FunctionButtonEqual_Clicked(object sender, EventArgs e)
        {
            if (_firstNumber == 0)
            {
                System.Diagnostics.Debug.WriteLine("There was no calculation function selected.");
                return;
            }

            if (_mainDisplayText == "")
            {
                System.Diagnostics.Debug.WriteLine("Second number needed.");
                return;
            }

            _secondNumber = int.Parse(_mainDisplayText);

            switch (_calculatingMethod)
            {
                case "plus":
                    int resultNumber = _firstNumber + _secondNumber;
                    _mainDisplayText = $"{resultNumber}";
                    updateDisplay();
                    break;
            }
        }
    }

}
