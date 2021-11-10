namespace myFirstCalculator
{
    public class Calculator:Operation
    {
        public Calculator()
        {
            ClearAll();
            SetFullOperation(_num1,_num2);
        }
        
        private double _num1;
        public double Num1 { get=>_num1;
            set
            {
                _num1 = value;
                SetFullOperation(Num1, Num2);
                OnPropertyChanged("Num1");
            }
        }
        
        private double _num2;
        public double Num2 { get=>_num2;
            set
            {
                _num2 = value;
                SetFullOperation(Num1, Num2);
                OnPropertyChanged("Num2");
            }
        }

        private bool _num2Turn;

        private double _res;
        public double Res { get=>_res; set => _res = value;}

        public void ClearAll()
        {
            Num1 = 0;
            Num2 = 0;
            OperationStr = "0";
            _num2Turn = false;
            Res = 0;
            SetFullOperation(Num1, Num2);
        }

        private void ClearAllExceptResult()
        {
            Num1 = 0;
            Num2 = 0;
            OperationStr = "0";
            _num2Turn = false;
            SetFullOperation(Num1, Num2);
        }

        public void AddNumber(int number)
        {
            if (_num2Turn)
            {
                Num2 = Num2 * 10 + number;
            }
            else
            {
                Num1 = Num1 * 10 + number;
            }
            SetFullOperation(Num1, Num2);
        }
        
        public string GetResult()
        {
            switch (OperationStr)
            {
                case "0":
                {
                    ClearAllExceptResult();
                    return "You did not enter an operation!! Values will be restarted";
                }
                case "4" when _num2 == 0:
                {
                    ClearAllExceptResult();
                    return "Number can not be divided by 0";
                }
                default:
                {
                    _res = DoOperation(_num1,_num2);
                    ClearAllExceptResult();
                    return $"Result: {_res}";
                }
            }
        }
        public void SetOperation(string operation)
        {
            OperationStr = operation;
            SetFullOperation(Num1, Num2);
            _num2Turn = true;
        }
    }
}