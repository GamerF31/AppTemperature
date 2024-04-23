using ChallengeApka;
using System;

class Program
{
    static void Main()
    {
        WriteLineColor(ConsoleColor.Cyan, "Dzień dobry");
        Thread.Sleep(1000);
        WriteLineColor(ConsoleColor.Magenta, "Wprowadź temperatury ostatniego tygodnia");

        var temperat = new Temperatura();
        int i = 0;

        while (i < 2)
        {
            WriteLineColor(ConsoleColor.Yellow, $"Dzień {i + 1}:");
            var input = Console.ReadLine();

            temperat.AddTemp(input);
            if (float.TryParse(input, out float result))
            {
                i++;
            }
            else
            {
                Console.WriteLine("Podałeś jakieś dziwne coś. Podaj temperaturę w postaci liczby.");
            }
        }

        var stats = temperat.GetStatistics();
        Console.WriteLine($"Najwyższa odnotowana temperatura to : {stats.Max}");
        Console.WriteLine($"Najniższa odnotowana temperatura to : {stats.Min}");
        Console.WriteLine($"Średnia odnotowana temperatura to : {stats.Average}");

        if (stats.Average < 0)
        {
            WriteLineColor(ConsoleColor.Blue, "Mamy zimę");
        }
        else if (stats.Average >= 0 && stats.Average < 10)
        {
            WriteLineColor(ConsoleColor.DarkYellow, "Mamy Jesień");
        }
        else if (stats.Average >= 10 && stats.Average < 20)
        {
            WriteLineColor(ConsoleColor.Green, "Mamy Wiosnę");
        }
        else
        {
            WriteLineColor(ConsoleColor.Yellow, "Mamy Lato");
        }
    }

    static void WriteLineColor(ConsoleColor color, string message)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
