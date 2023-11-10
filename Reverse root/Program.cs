using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        NumberFormatInfo info = NumberFormatInfo.InvariantInfo;
        string[] numbers = Console.In.ReadToEnd().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            double root = Math.Sqrt(double.Parse(numbers[i], info));
            Console.WriteLine(string.Format(info, "{0:F4}", root));
        }
    }
}