using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace myFirstCalculator
{
    public class Operation:INotifyPropertyChanged
    {
        protected Operation()
        {
            _operation = "1";
        }

        private string _operation;
        public string OperationStr
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged("OperationStr");
            }
        }

        private string _fullOperation;
        public string FullOperation
        {
            get => _fullOperation;
            set
            {
                _fullOperation = value;
                OnPropertyChanged("FullOperation");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected double DoOperation(double num1,double num2)
        {
            double ret=777;
            switch (_operation)
            {
                case "1":ret = num1 + num2;
                    break;
                case "2": ret = num1 - num2;
                    break;
                case "3": ret = num1 * num2;
                    break;
                case "4": ret = num1 / num2;
                    break;
                case "5": ret = Math.Pow(num1, num2);
                    break;
                case "6": ret = Math.Sqrt(num1);
                    break;
                case "7": ret = 1 / num1;
                    break;
            }
            return ret;
        }

        protected void SetFullOperation(double num1,double num2)
        {
            FullOperation= num1 + " " + GetOperationSymbol() + " " + num2;
        }

        private string GetOperationSymbol()
        {
            switch (_operation)
            {
                case "0": return " ~~~~~~ ";
                case "1": return "+";
                case "2": return "-";
                case "3": return "*";
                case "4": return "/";
                case "5": return "^";
                case "6": return "<-----SQR(X)";
                case "7": return "<-----1/X";
                default: return "";
            }
        }
    }
}