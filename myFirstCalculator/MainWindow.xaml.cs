﻿using System.Globalization;
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
            _num1 = 0;
            _num2 = 0;
            _operation = 0;
            _num2Turn = false;
        }

        private double _num1;
        private double _num2;
        private int _operation;
        private bool _num2Turn;

        private void Result(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_operation == 0
                ? "No se ingreso una operacion!!! Se reinician los valores"
                : Calculadora.Operation(_num1, _num2, _operation).ToString(CultureInfo.CurrentCulture));
            _num1 = 0;
            _num2 = 0;
            _operation = 0;
            _num2Turn = false;
        }

        private void NumberAction9(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 9;
            }
            else
            {
                _num1 = _num1 * 10 + 9;
            }
        }

        private void NumberAction8(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 8;
            }
            else
            {
                _num1 = _num1 * 10 + 8;
            }
        }

        private void NumberAction7(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 7;
            }
            else
            {
                _num1 = _num1 * 10 + 7;
            }
        }

        private void NumberAction6(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 6;
            }
            else
            {
                _num1 = _num1 * 10 + 6;
            }
        }

        private void NumberAction5(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 5;
            }
            else
            {
                _num1 = _num1 * 10 + 5;
            }
        }

        private void NumberAction4(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 4;
            }
            else
            {
                _num1 = _num1 * 10 + 4;
            }
        }

        private void NumberAction3(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 3;
            }
            else
            {
                _num1 = _num1 * 10 + 3;
            }
        }

        private void NumberAction2(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 2;
            }
            else
            {
                _num1 = _num1 * 10 + 2;
            }
        }

        private void NumberAction1(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 = _num2 * 10 + 1;
            }
            else
            {
                _num1 = _num1 * 10 + 1;
            }
        }
        
        private void NumberAction0(object sender, RoutedEventArgs e)
        {
            if (_num2Turn)
            {
                _num2 *= 10;
            }
            else
            {
                _num1 *= 10;
            }
        }

        private void SetOperation7(object sender, RoutedEventArgs e)
        {
            _operation = 7;
            _num2Turn=true;
        }

        private void SetOperation5(object sender, RoutedEventArgs e)
        {
            _operation = 5;
            _num2Turn=true;
        }

        private void SetOperation6(object sender, RoutedEventArgs e)
        {
            _operation = 6;
            _num2Turn=true;
        }

        private void SetOperation3(object sender, RoutedEventArgs e)
        {
            _operation = 3;
            _num2Turn = true;
        }

        private void SetOperation2(object sender, RoutedEventArgs e)
        {
            _operation = 2;
            _num2Turn = true;
        }

        private void SetOperation4(object sender, RoutedEventArgs e)
        {
            _operation = 4;
            _num2Turn = true;
        }

        private void SetOperation1(object sender, RoutedEventArgs e)
        {
            _operation = 1;
            _num2Turn = true;
        }
        
        private void MostrarN1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El primer numero es: "+_num1);
        }
        
        private void MostrarN2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El primer numero es: "+_num2);
        }

        private void ClearAll(object sender, RoutedEventArgs e)
        {
            Calculadora.ClearAll(ref _num1,ref _num2, ref _operation,ref _num2Turn);
        }
        
        private void ClearNumber(object sender, RoutedEventArgs e)
        {
            if (_num2Turn) _num2 = 0;
            else _num1 = 0;
        }
    }
}