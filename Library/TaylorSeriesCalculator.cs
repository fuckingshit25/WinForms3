using System;

namespace Library
{
    public static class TaylorSeriesCalculator
    {
        public static double CalculateArctg(double x, double precision, out int termsCount)
        {
            if (x >= -1)
            {
                throw new ArgumentOutOfRangeException("x", "x должен быть меньше -1");
            }

            double sum = Math.PI / 2;
            double term = -1 / x;
            int n = 0;
            termsCount = 0;

            while (Math.Abs(term) >= precision)
            {
                sum += term;
                termsCount++;
                n++;
                if (x == 0) // Проверка на деление на ноль
                {
                    throw new DivideByZeroException("Деление на ноль.");
                }
                term = -term * (2 * n - 1) / (2 * n + 1) / (x * x);
            }

            return sum;
        }
    }
}
