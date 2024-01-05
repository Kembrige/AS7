using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        string binary = "";

        while (num > 0)
        {
            int remainder = num % 2;
            binary = remainder + binary;
            num /= 2;
        }

        Console.WriteLine("Двоичная запись: " + binary);
    }
}