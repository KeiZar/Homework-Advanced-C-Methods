using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


class LastDigitOfNumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(GetDigitAsWord(inputNumber));
    }
    static string GetDigitAsWord(int number)
    {
        string[] numberAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int digitWord = number % 10;

        return numberAsWord[digitWord];
    }
}

