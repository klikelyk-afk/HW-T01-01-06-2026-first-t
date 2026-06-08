using System;

class Program
{
    static void Task1()
    {
        Console.Write("Введiть число вiд 1 до 100: ");
        int number = Convert.ToInt32(Console.ReadLine());


        if (number < 1 || number > 100)
        {
            Console.WriteLine("Помилка! Число повинно бути в дiапазонi вiд 1 до 100.");
        }

        else if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
    static void Task2()
    {

        Console.Write("Введiть число (значення): ");
        double value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть вiдсоток, який потрiбно знайти: ");
        double percent = Convert.ToDouble(Console.ReadLine());

        double result = (value * percent) / 100;

        Console.WriteLine($"{percent}% вIд {value} дорiвнює: {result}");
    }

    static void Task3()
    {
        Console.Write("Введiть першу цифру: ");
        int d1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введiть другу цифру: ");
        int d2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введiть третю цифру: ");
        int d3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введiть четверту цифру: ");
        int d4 = Convert.ToInt32(Console.ReadLine());

        int finalNumber = (d1 * 1000) + (d2 * 100) + (d3 * 10) + d4;

        Console.WriteLine($"Сформоване число: {finalNumber}");
    }

    static void Task4()
    {
        Console.Write("Введiть шестизначне число: ");
        string input = Console.ReadLine();

        if (input.Length != 6)
        {
            Console.WriteLine("Помилка! Число має бути саме шестизначним.");
            return;
        }

        Console.Write("Введiть перший номер розряду (вiд 1 до 6): ");
        int pos1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введiть другий номер розряду (вiд 1 до 6): ");
        int pos2 = Convert.ToInt32(Console.ReadLine());

        int idx1 = pos1 - 1;
        int idx2 = pos2 - 1;

        char[] digits = input.ToCharArray();

        char temp = digits[idx1];
        digits[idx1] = digits[idx2];
        digits[idx2] = temp;

        string result = new string(digits);
        Console.WriteLine($"Результат обмiну: {result}");
    }

    static void Task5()
    {
        Console.Write("Введiть дату у форматi дд.мм.рррр (наприклад, 22.12.2021): ");
        string input = Console.ReadLine();


        if (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
        {
            Console.WriteLine("Помилка! Неправильний формат дати або такої дати не iснує.");
            return;
        }

        int month = parsedDate.Month;
        string season = "";

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                season = "Winter";
                break;
            case 3:
            case 4:
            case 5:
                season = "Spring";
                break;
            case 6:
            case 7:
            case 8:
                season = "Summer";
                break;
            case 9:
            case 10:
            case 11:
                season = "Autumn";
                break;
        }

        string dayOfWeek = parsedDate.DayOfWeek.ToString();

        Console.WriteLine($"Результат: {season} {dayOfWeek}");
    }

    static void Task6()
    {
        Console.Write("Введiть значення температури: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Оберiть напрямок конвертацiї:");
        Console.WriteLine("1 — з Цельсiя в Фаренгейт");
        Console.WriteLine("2 — з Фаренгейта в Цельсiй");
        Console.Write("Ваш вибiр (1 або 2): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            double fahrenheit = (temperature * 9 / 5) + 32;
            Console.WriteLine($"{temperature}°C дорiвнює {fahrenheit}°F");
        }
        else if (choice == "2")
        {
            double celsius = (temperature - 32) * 5 / 9;
            Console.WriteLine($"{temperature}°F дорiвнює {celsius}°C");
        }
        else
        {
            Console.WriteLine("Помилка! Невiрний вибiр операцiї.");
        }
    }

    static void Task7()
    {
        Console.Write("Введiть початок дiапазону: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введiть кiнець дiапазону: ");
        int end = Convert.ToInt32(Console.ReadLine());

        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
            Console.WriteLine($"[Нормалiзацiя] Межi змiнено: вiд {start} до {end}");
        }

        Console.WriteLine($"Парнi числа в дiапазонi вiд {start} до {end}:");

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }

    static void Task8()
    {
        Console.Write("Введiть число: ");
        string input = Console.ReadLine();

        int power = input.Length;

        double sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int digit = Convert.ToInt32(input[i].ToString());

            sum += Math.Pow(digit, power);
        }

        int originalNumber = Convert.ToInt32(input);

        if (sum == originalNumber)
        {
            Console.WriteLine($"Число {originalNumber} є числом Армстронга.");
        }
        else
        {
            Console.WriteLine($"Число {originalNumber} НЕ є числом Армстронга.");
        }
    }

    static void Task9()
    {
        Console.Write("Введiть число для перевiрки: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        if (sum == number && number > 0)
        {
            Console.WriteLine($"Число {number} є досконалим.");
        }
        else
        {
            Console.WriteLine($"Число {number} НЕ є досконалим.");
        }
    }

    static void Main()
        {
            Task9();
        }
    }
