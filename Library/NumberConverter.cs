using System;
namespace Library
{
    public class NumberConverter
    {
        public static string ToBaseFive(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Число должно быть натуральным (больше 0)");
            }
            string result = string.Empty;
            while (number > 0)
            {
                int remainder = number % 5;
                result = remainder.ToString() + result;
                number /= 5;
            }
            return result;
        }
    }
}
