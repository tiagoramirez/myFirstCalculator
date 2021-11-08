using System;

namespace myFirstCalculator
{
    public static class Calculadora
    {
        public static double Operation(double num1,double num2,int operation)
        {
            double ret=0;
            switch (operation)
            {
                case 1:ret = num1 + num2;
                    break;
                case 2: ret = num1 - num2;
                    break;
                case 3: ret = num1 * num2;
                    break;
                case 4: ret = num1 / num2;
                    break;
                case 5: ret = Math.Pow(num1, num2);
                    break;
                case 6: ret = Math.Sqrt(num1);
                    break;
                case 7: ret = 1 / num1;
                    break;
                case 8: ret = num1;
                    break;
                case 9: ret = num2;
                    break;
            }
            return ret;
        }

        public static void ClearAll(ref double num1,ref double num2,ref int operation,ref bool num2Turn)
        {
            num1 = 0;
            num2 = 0;
            operation = 0;
            num2Turn = false;
        }
    }
}