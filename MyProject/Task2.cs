using System;

class Task2
{
    static void Main(string[] args)
    {
        int[][] numberMatrix =
        {
            new int[] { 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 }
        };

        Console.WriteLine("Matrix initialized.");

        int digit1 = numberMatrix[1][3]; // index 3 = 7
        int digit2 = numberMatrix[0][0]; // index 0 = 2
        int digit3 = numberMatrix[1][4]; // index 4 = 9

        string password = $"{digit1}{digit2}{digit3}";

        Console.WriteLine($"Password: {password}");
    }
}
 