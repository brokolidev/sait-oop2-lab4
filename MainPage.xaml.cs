namespace CalculatorApp
{
    // This is the MainPage class that is used to create the calculator app.
    public partial class MainPage : ContentPage
    {
        private string _mainDisplayText;
        private float _totalNumber;
        private string _calculatingMethod;
        private bool _isFirstNumber;

        // This is the constructor for the MainPage class.
        public MainPage()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);

            Reset();
        }

        // This method is used to reset the calculator app.
        private void Reset()
        {
            _mainDisplayText = "";
            _totalNumber = 0;
            _calculatingMethod = "";
            _isFirstNumber = true;
            UpdateDisplay();
        }

        // This method is used to update the display with the current mainDisplayText value.
        private void UpdateDisplay()
        {
            mainDisplay.Text = _mainDisplayText;
        }

        // This method is used to handle the event when the number buttons are clicked.
        private void NumberButton1_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "1": _mainDisplayText + "1";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton2_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "2": _mainDisplayText + "2";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton3_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "3": _mainDisplayText + "3";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton4_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "4": _mainDisplayText + "4";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton5_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "5": _mainDisplayText + "5";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton6_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "6": _mainDisplayText + "6";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton7_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "7": _mainDisplayText + "7";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton8_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "8": _mainDisplayText + "8";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton9_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "9": _mainDisplayText + "9";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        private void NumberButton0_Clicked(object sender, EventArgs e)
        {
            _mainDisplayText = _isFirstNumber ? "0": _mainDisplayText + "0";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();

        }

        // This method is used to handle the event when the function buttons are clicked.
        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            this.Reset();
        }

        // This method is used to handle the event when the . button is clicked.
        private void NumberDot_Clicked(object sender, EventArgs e)
        {

            // if it is already a decimal number, return
            if (_mainDisplayText.Contains(".") && !_isFirstNumber)
            {
                System.Diagnostics.Debug.WriteLine("The number is already a decimal number.");
                return;
            }

            _mainDisplayText = _isFirstNumber ? "." : _mainDisplayText + ".";
            _isFirstNumber = !_isFirstNumber && _isFirstNumber;
            UpdateDisplay();
        }

        // This method is used to handle the event when the function buttons are clicked.
        private void FuntionButtonPlus_Clicked(object sender, EventArgs e)
        {
            
            // check if there is a number to add
            if(String.IsNullOrEmpty(_mainDisplayText))
            {
                System.Diagnostics.Debug.WriteLine("No number to add.");
                return;
            }

            if (_calculatingMethod != "" && _calculatingMethod != "plus" && !_isFirstNumber)
            {
                Calculate();

                _calculatingMethod = "plus";
                return;
            }

            // preventing clicked multiple times
            if (_isFirstNumber)
            {
                return;
            }

            // save the method and the number
            _calculatingMethod = "plus";

            Calculate();
        }

        // This method is used to handle the event when the - button is clicked.
        private void FunctionButtonMinus_Clicked(object sender, EventArgs e)
        {
            // check if there is a number to subtract
            if (String.IsNullOrEmpty(_mainDisplayText))
            {
                System.Diagnostics.Debug.WriteLine("No number to subtract.");
                return;
            }

            if (_calculatingMethod != "" && _calculatingMethod != "minus" && !_isFirstNumber)
            {
                Calculate();

                _calculatingMethod = "minus";
                return;
            }

            
            if (_isFirstNumber)
            {
                return;
            }

            // save the method
            _calculatingMethod = "minus";

            Calculate();
        }


        // This method is used to handle the event when the * button is clicked.
        private void MultiplyButton_Clicked(object sender, EventArgs e)
        {
            // check if there is a number to multiply
            if (String.IsNullOrEmpty(_mainDisplayText))
            {
                System.Diagnostics.Debug.WriteLine("No number to multiply.");
                return;
            }

            if (_calculatingMethod != "" && _calculatingMethod != "multiply" && !_isFirstNumber)
            {
                Calculate();

                _calculatingMethod = "multiply";
                return;
            }

            // preventing clicked multiple times
            if (_isFirstNumber)
            {
                return;
            }

            // save the method and the number
            _calculatingMethod = "multiply";

            Calculate();
        }

        // This method is used to handle the event when the / button is clicked.
        private void DivisionButton_Clicked(object sender, EventArgs e)
        {
            // check if there is a number to divide
            if (String.IsNullOrEmpty(_mainDisplayText))
            {
                System.Diagnostics.Debug.WriteLine("No number to divide.");
                return;
            }

            // get number to divide
            float numberToDivide = float.Parse(_mainDisplayText);

            if (_calculatingMethod != "" && _calculatingMethod != "divide" && !_isFirstNumber)
            {
                Calculate();

                _calculatingMethod = "divide";
                return;
            }

            // preventing clicked multiple times
            if(_isFirstNumber)
            {
                return;
            }

            // save the method
            _calculatingMethod = "divide";


            Calculate();
        }

        // This method is used to handle the event when the = button is clicked.
        private void FunctionButtonEqual_Clicked(object sender, EventArgs e)
        {
            if (_totalNumber == 0)
            {
                System.Diagnostics.Debug.WriteLine("There was no calculation function selected.");
                return;
            }

            if (_mainDisplayText == "")
            {
                System.Diagnostics.Debug.WriteLine("Input any numbers for calculation.");
                return;
            }

            Calculate();

            // set the total number to 0 to start over
            _totalNumber = 0;
        }

        private void Calculate()
        {
            float numberToCalculate = float.Parse(_mainDisplayText);

            // protecting first number to be negative
            if (_totalNumber == 0 && _calculatingMethod == "minus")
            {
                numberToCalculate*= -1;
            }


            switch (this._calculatingMethod)
            {
                case "plus":
                    _totalNumber += numberToCalculate;
                    break;

                case "minus":
                    _totalNumber -= numberToCalculate;
                    break;

                case "multiply":

                    // preventing multiply by 0
                    if (_totalNumber == 0)
                    {
                        _totalNumber = numberToCalculate;
                    }
                    else
                    {
                        _totalNumber *= numberToCalculate;
                    }

                    break;

                case "divide":

                    // preventing divide by 0
                    if (_totalNumber == 0)
                    {
                        _totalNumber = numberToCalculate;
                    }
                    else
                    {
                        _totalNumber /= numberToCalculate;
                    }

                    break;

                default:
                    System.Diagnostics.Debug.WriteLine("No calculation method selected.");
                    return;

            }

            // update the main display text
            _mainDisplayText = $"{_totalNumber}";

            // protecting first number to be negative
            if (numberToCalculate == _totalNumber && _calculatingMethod == "minus")
            {
                _totalNumber *= -1;
            }

            _isFirstNumber = true;
            UpdateDisplay();
        }
    }

}
