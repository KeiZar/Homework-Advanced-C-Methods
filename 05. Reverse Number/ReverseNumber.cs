using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


class ReverseNumber
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(input);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(double notReversed)
    {
        string stringNumber = notReversed.ToString();
        char[] reversed = stringNumber.ToCharArray();
        Array.Reverse(reversed);
        string reversedNumber = new string(reversed);
        double newNumber = double.Parse(reversedNumber);
        return newNumber;
    }
}

