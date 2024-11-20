using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite prvi broj:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite drugi broj:");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Odaberite operaciju:");
        Console.WriteLine("1 - Sabiranje");
        Console.WriteLine("2 - Oduzimanje");
        Console.WriteLine("3 - Množenje");
        Console.WriteLine("4 - Deljenje");

        int choice = int.Parse(Console.ReadLine());
        double result = 0;

        switch (choice)
        {
            case 1:
                result = firstNumber + secondNumber;
                Console.WriteLine($"Rezultat sabiranja: {result}");
                break;
            case 2:
                result = firstNumber - secondNumber;
                Console.WriteLine($"Rezultat oduzimanja: {result}");
                break;
            case 3:
                result = firstNumber * secondNumber;
                Console.WriteLine($"Rezultat množenja: {result}");
                break;
            case 4:
                if (secondNumber != 0)
                {
                    result = (double)firstNumber / secondNumber;
                    Console.WriteLine($"Rezultat deljenja: {result}");
                }
                else
                {
                    Console.WriteLine("Greška: Deljenje sa nulom nije dozvoljeno.");
                }
                break;
            default:
                Console.WriteLine("Nepoznata operacija.");
                break;
        }
    }
}


