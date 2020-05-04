using System;
class Program
{
    static void Main()
    {
        int[] M = new int[] { 7, 12, 142, -8, 94, 55, 104, 5, 10, 27 };
        int zero = 0, oneDigit = 0, twoDigits = 0;
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 6; j++)
                if (M[i] == 0) zero++;
                else
                if (Math.Abs(M[i]) < 9) oneDigit++;
                else twoDigits++;
        Console.WriteLine(format: "однорозрядних чисел: {1} ", zero, oneDigit, twoDigits);
        Console.ReadKey();

    }
}