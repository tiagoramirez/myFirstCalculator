using System.Windows;

namespace myFirstCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            _calc = new Calculator();
            this.DataContext = _calc;
        }

        private readonly Calculator _calc;

        private void Result(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_calc.GetResult());
        }

        private void NumberAction9(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(9);
        }

        private void NumberAction8(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(8);
        }

        private void NumberAction7(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(7);
        }

        private void NumberAction6(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(6);
        }

        private void NumberAction5(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(5);
        }

        private void NumberAction4(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(4);
        }

        private void NumberAction3(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(3);
        }

        private void NumberAction2(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(2);
        }

        private void NumberAction1(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(1);
        }
        
        private void NumberAction0(object sender, RoutedEventArgs e)
        {
            _calc.AddNumber(0);
        }

        private void SetOperation7(object sender, RoutedEventArgs e)
        {
            _calc.SetOperation("7");
        }

        private void SetOperation5(object sender, RoutedEventArgs e)
        {
            _calc.SetOperation("5");
        }

        private void SetOperation6(object sender, RoutedEventArgs e)
        {
            _calc.SetOperation("6");
        }

        private void SetOperation3(object sender, RoutedEventArgs e)
        {
            _calc.SetOperation("3");
        }

        private void SetOperation2(object sender, RoutedEventArgs e)
        {
            _calc.SetOperation("2");
        }

        private void SetOperation4(object sender, RoutedEventArgs e)
        {
            _calc.SetOperation("4");
        }

        private void SetOperation1(object sender, RoutedEventArgs e)
        {
            _calc.SetOperation("1");
        }
        
        private void ShowN1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"First number is: {_calc.Num1}");
        }
        
        private void ShowN2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Second number is: {_calc.Num2}");
        }

        private void ClearAll(object sender, RoutedEventArgs e)
        {
            _calc.ClearAll();
        }

        private void PreviousNumber(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{_calc.Res} is setted to number 1");
            _calc.Num1 = _calc.Res;
        }
    }
}